﻿using System;

namespace SerializeData
{
    [Serializable]
    public class EmailConfig
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
