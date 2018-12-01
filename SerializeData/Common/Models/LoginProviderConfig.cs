using System;

namespace SerializeData
{
    [Serializable]
    public class LoginProviderConfig
    {
        public string GoogleClientId { get; set; }
        public string GoogleClientSecret { get; set; }
        public string TwitterConsumerKey { get; set; }
        public string TwitterConsumerSecret { get; set; }
        public string GitHubClientId { get; set; }
        public string GitHubClientSecret { get; set; }
        public string MicrosoftClientId { get; set; }
        public string MicrosoftClientSecret { get; set; }
        public string FacebookAppId { get; set; }
        public string FacebookAppSecret { get; set; }
    }
}
