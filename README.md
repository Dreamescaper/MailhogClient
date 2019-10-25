# MailhogClient
.NET client for MailHog

Usage example:
```csharp
var mailhogClient = new MailhogClient(new Uri("https://mailhog.mydomain.com/"));
var messages = await mailhogClient.GetMessagesAsync();
var subjects = messages.Items.Select(m => m.Subject);
```
