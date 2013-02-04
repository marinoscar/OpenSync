using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenSync.Core.Configuration;

namespace OpenSync.Tests.Helpers
{
    public class CredentialsHelper
    {
        public static Credentials GetCredentials()
        {
            var credentials = Credentials.TryToGetFromXmlFile("credentials.xml");
            if (credentials == null)
            {
                var form = new ApiCredentials();
                if (form.ShowDialog() == DialogResult.Cancel) throw new InvalidOperationException("Need to provide credentials");
                return Credentials.FromXmlFile("credentials.xml");
            }
            return credentials;
        }
    }
}
