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
    public class WhenSystemWritesAFile
    {
        [Test]
        public void ItShouldWriteTheFileToTheCloudWithoutErrors()
        {
            var fileStream = "MY TEST STREAM".ToCharArray().Select(Convert.ToByte).ToArray();
            var memoryStream = new MemoryStream(fileStream);
            var fileManager = new FileManager(CredentialsHelper.GetCredentials());
            fileManager.SaveFile(memoryStream, "SampleStream.txt");
        }
    }
}
