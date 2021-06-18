using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using OnlinerTests.Settings;
using System.Linq;
using System.Threading;

namespace OnlinerTests.Helpers
{
    public class GmailHelper
    {
        private static readonly string[] Scopes = { GmailService.Scope.GmailReadonly };
        private const string ApplicationName = "Gmail API .NET Quickstart";
        private static readonly string ClientId = AppSettings.ReadSettings("ClientId");
        private static readonly string ClientSecret = AppSettings.ReadSettings("ClientSecret");

        public static bool IsMailPresent(string senderName)
        {
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = ClientId,
                    ClientSecret = ClientSecret
                },
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore("Analytics.Auth.Store")).Result;

            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            var inboxListRequest = service.Users.Messages.List("onlinertestsel@gmail.com");
            inboxListRequest.LabelIds = "INBOX";
            inboxListRequest.IncludeSpamTrash = false;
            var emailListResponse = inboxListRequest.Execute();
            var message = service.Users.Messages.Get("onlinertestsel@gmail.com", emailListResponse.Messages.FirstOrDefault()?.Id).Execute();
            return message.Snippet.Contains(senderName);
        }
    }
}



