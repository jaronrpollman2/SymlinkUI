using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymlinkUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_Source.ReadOnly = true;
            txt_Target.ReadOnly = true;
            txt_Target.Text = "Pick a source file before a Target";
        }

        private void btn_browseSources_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fileDialog = new FolderBrowserDialog())
            {
                if(DialogResult.OK == fileDialog.ShowDialog())
                {
                    string fileName = fileDialog.SelectedPath;
                    txt_Source.Text = fileName;
                    btn_BrowseTarget.Enabled = true;
                    txt_Target.Enabled = true;
                }
            }
        }

        private void btn_BrowseTarget_Click(object sender, EventArgs e)
        {
            if (txt_Source.Text == "")
            {
                label3.Text = "Pick a source first";
            }
            else
            {
                txt_Target.Clear();
                using (FolderBrowserDialog fileDialog = new FolderBrowserDialog())
                {
                    if (DialogResult.OK == fileDialog.ShowDialog())
                    {
                        string fileName = fileDialog.SelectedPath;
                        fileName += txt_Source.Text.Substring(txt_Source.Text.LastIndexOf(@"\"));
                        txt_Target.Text = fileName;
                    }
                }
            }
        }

        private void btn_CreateSymlink_Click(object sender, EventArgs e)
        {

            try
            {
                //Check if the Directory Exists and delete
                var dir = new DirectoryInfo(txt_Target.Text);
                //Check Directory Existence
                if(dir.Exists)
                    dir.Delete(true);

                //Create a new symlink to the directory
                if (SymLink.CreateSymLink(txt_Target.Text, txt_Source.Text, E_SymLink.Directory))
                    label3.Text = "Symlink Created";
                else
                    label3.Text = "Symlink failed";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
