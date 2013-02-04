using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using OpenSync.Core.Configuration;
using Rackspace.Cloudfiles;

namespace OpenSync.Core
{
    public class FileManager
    {
        private bool _isAuthenticated;
        private Credentials _credentials;
        private Connection _connection;
        private Container _container;

        public FileManager(Credentials credentials)
        {
            InitializeClass(credentials, "WindowsClientContainer");
        }

        public FileManager(Credentials credentials, string containerName)
        {
            
        }

        private void InitializeClass(Credentials credentials, string containerName)
        {
            _credentials = credentials;
            _connection = new CF_Connection(new UserCredentials(_credentials.User, _credentials.Key));
            _container = new CF_Container(_connection, containerName);

        }

        public bool Authenticate()
        {
            if (_isAuthenticated) return _isAuthenticated;
            try
            {
                _connection.Authenticate();
                _isAuthenticated = true;
            }
            catch (Exception)
            {
                _isAuthenticated = false;
            }
            return _isAuthenticated;
        }

        public void SaveFile(string fileName)
        {
            var file = new FileInfo(fileName);
            SaveFile(file.OpenRead());
        }

        public void SaveFile(FileStream stream)
        {
            SaveFile(stream, stream.Name);

        }

        public void SaveFile(Stream stream, string fileName)
        {
            if (!Authenticate()) throw new InvalidOperationException("Unable to authenticate");
            CreateContainer();
            var fileObject = new CF_Object(_connection, _container, new CF_Client(), fileName);
            fileObject.Write(stream);
            stream.Close();

        }

        private void CreateContainer()
        {
            var account = new CF_Account(_connection);
            _container = account.CreateContainer(_container.Name);
        }

        public Stream ReadFile(string fileName)
        {
            if (!Authenticate()) throw new InvalidOperationException("Unable to authenticate");
            var fileObject = new CF_Object(_connection, _container.Name, fileName);
            return fileObject.Read();
        }
    }
}
