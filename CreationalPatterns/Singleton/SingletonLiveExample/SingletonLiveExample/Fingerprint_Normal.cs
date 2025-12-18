using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonLiveExample
{
    public class Fingerprint_Normal
    {
        public string Owner { get; set; }

        public Fingerprint_Normal(string owner)
        {
            Owner = owner;
        }

        public string GetInfo()
        {
            return $"Fingerprint of {Owner}";
        }
    }
}
