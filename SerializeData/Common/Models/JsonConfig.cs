using System;

namespace SerializeData
{
    [Serializable]
    public class JsonConfig
    {
        public EmailConfig Email { get; set; }
        public LoginProviderConfig LoginProvider { get; set; }
    }
}
