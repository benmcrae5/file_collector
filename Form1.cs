using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_collector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_folderSearch_Click(object sender, EventArgs e)
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //Process.Start(Path.Join( @"C:\users\bmcrae", userName ) );
            //Process.Start(@"C:\users\benmc");
            string path = Path.Combine(@"C:\users", userName);

            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    string[] folders = Directory.GetDirectories(folderBrowser.SelectedPath);

                    list_folders_origins.Items.Add(folderBrowser.SelectedPath);

                    if (!check_getSubDirectories.Checked)
                    {
                        return;
                    }                        
                    
                    for (int x = 0; x < folders.Length; x++)
                    {
                        if (x > 8) { break; }

                        list_folders_origins.Items.Add(folders[x]);
                        Global.originFolderList[x] = folders[x];
                    }
                }
            }
        }
    }
}
