using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenSync.Core.Configuration;

namespace OpenSync.Tests.Helpers
{
    public partial class ApiCredentials : Form
    {
        public ApiCredentials()
        {
            InitializeComponent();
        }

        private void OkCommandClick(object sender, EventArgs e)
        {
            var crendentials = new Credentials() { Key = keyInput.Text, User = userNameInput.Text };
            crendentials.ToXmlFile("credentials.xml");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
