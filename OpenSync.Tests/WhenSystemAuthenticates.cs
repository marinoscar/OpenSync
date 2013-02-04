using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using OpenSync.Core;
using OpenSync.Core.Configuration;
using OpenSync.Tests.Helpers;

namespace OpenSync.Tests
{
    [TestFixture]
    public class WhenSystemAuthenticates
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ItShouldAuthenticateWithValidCredentialsInXmlFile()
        {
            var credentials = CredentialsHelper.GetCredentials();
            var fileManager = new FileManager(credentials);
            Assert.IsTrue(fileManager.Authenticate());
        }
    }
}
