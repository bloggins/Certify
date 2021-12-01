//start
using System.Text;
using System.Linq;
using System;
﻿namespace Certify.Lib
{
    class LdapSearchOptions
    {
        public LdapSearchOptions()
        {
            Domain = null;
            LdapServer = null;
        }
        public string? Domain { get; set; }
        public string? LdapServer { get; set; }
    }
}
