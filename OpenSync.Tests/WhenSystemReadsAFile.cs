using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenSync.Core;
using OpenSync.Tests.Helpers;

namespace OpenSync.Tests
{
    [TestFixture]
    public class WhenSystemReadsAFile
    {
        [Test]
        public void ItShouldReadTheFileFromTheCloudWithoutErrors()
        {
            var fileManager = new FileManager(CredentialsHelper.GetCredentials());
            var stream = fileManager.ReadFile("SampleStream.txt");
            var streamReader = new StreamReader(stream);
            Assert.IsNotNullOrEmpty(streamReader.ReadToEnd());
        }

    }
}
