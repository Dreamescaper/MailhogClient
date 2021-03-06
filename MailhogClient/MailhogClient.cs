﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Mailhog.Models;
using Newtonsoft.Json;

namespace Mailhog
{
    public class MailhogClient
    {
        private readonly HttpClient _httpClient;

        public MailhogClient(Uri mailhogUrl)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = mailhogUrl
            };
        }

        public MailhogClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <summary>
        /// Retrieve a list of messages
        /// </summary>
        /// <param name="start">Start index</param>
        /// <param name="limit">Number of messages</param>
        public Task<Messages> GetMessagesAsync(int start = 0, int limit = 50)
        {
            return GetAsync<Messages>($"/api/v2/messages?start={start}&limit={limit}");
        }

        public Task<Message> GetMessageAsync(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return GetAsync<Message>("/api/v1/messages/" + id);
        }

        /// <summary>
        /// Search messages
        /// </summary>
        /// <param name="kind">Kind of search</param>
        /// <param name="query">Search parameter</param>
        /// <param name="start">Start index</param>
        /// <param name="limit">Number of messages</param>
        public Task<Messages> SearchAsync(SearchKind kind, string query, int start = 0, int limit = 50)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));

            var kindQuery = kind.ToString().ToLower();

            return GetAsync<Messages>($"/api/v2/search?kind={kindQuery}&query={WebUtility.UrlEncode(query)}&start={start}&limit={limit}");
        }

        public Task DeleteAsync(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return _httpClient.DeleteAsync("/api/v1/messages/" + id);
        }

        private async Task<T> GetAsync<T>(string url)
        {
            var response = await _httpClient.GetAsync(url).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                var message = content
                    ?? response.ReasonPhrase
                    ?? ($"{(int)response.StatusCode} {response.StatusCode}");

                throw new HttpRequestException(message);
            }

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
