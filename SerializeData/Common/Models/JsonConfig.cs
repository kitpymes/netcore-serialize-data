using System;

namespace SerializeData
{
    [Serializable]
    public class JsonConfig
    {
        public bool IsMultitenancy { get; set; }
        public bool IsConfirmedAccount { get; set; }
        public string DefaultConnectionName { get; set; }
        public string DefaultCompanyName { get; set; }
        public string DefaultIdentityProvider { get; set; }
        public string DefaultPlainPassword { get; set; }
        public EmailConfig EmailConfig { get; set; }
        public LoginProviderConfig LoginProviderConfig { get; set; }
    }
}
