using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;



namespace ProtocolRegiryWindows
{
    public partial class frmProtoColRegister : Form
    {
        public frmProtoColRegister()
        {
            InitializeComponent();
        }

      

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    var path = openFileDialog1.FileName;
                    txtExePath.Text = path;
                    //MessageBox.Show(path,"Message");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void FrmProtoColRegister_Load(object sender, EventArgs e)
        {
           



            

        }

        private void txtProtocol_TextChanged(object sender, EventArgs e)
        {

        }


        private void WriteRegistry(string ProtocolName,string ProtocalUrl,string HandlerEXEPath,string PrinterName)
        {

            HandlerEXEPath = HandlerEXEPath.Replace("\"","");
            HandlerEXEPath = HandlerEXEPath.Replace("%1", "");
            ProtocalUrl = ProtocalUrl.Replace("URL:", "");

            const string userRoot = "HKEY_CLASSES_ROOT";
             string subkey = ProtocolName;
             string keyName = userRoot + "\\" + subkey;
            Registry.SetValue(keyName, "", "URL:"+ ProtocalUrl);
            Registry.SetValue(keyName, "PrinterName", PrinterName,RegistryValueKind.String);
            Registry.SetValue(keyName, "URL Protocol", "");
            Registry.SetValue(keyName, "EditFlags", "2", RegistryValueKind.DWord);

            string keyNameN = userRoot + "\\" + subkey + "\\" + "shell";

            Registry.SetValue(keyNameN, "", "open");

            keyNameN = userRoot + "\\" + subkey + "\\" + "shell" + "\\" + "open";
            Registry.SetValue(keyNameN, "", "");

            keyNameN = userRoot + "\\" + subkey + "\\" + "shell" + "\\" + "open" + "\\" + "command";
            Registry.SetValue(keyNameN, "","\"" + HandlerEXEPath + "\" \"%1\"", RegistryValueKind.String);
            
            MessageBox.Show("Done");
        }


        private void ReadRegistry()
        {
            try
            {

            


            const string userRoot = "HKEY_CLASSES_ROOT";
            string subkey = txtProtocol.Text.Trim();
            string keyName = userRoot + "\\" + subkey;
            Registry.SetValue(keyName, "", "URL:plplprint");
                txtprotocolUrl.Text = Registry.GetValue(keyName, "", "").ToString();
            CboInstalledPrinter.Text = Registry.GetValue(keyName, "PrinterName","").ToString();           
            
             keyName = userRoot + "\\" + subkey + "\\" + "shell" + "\\" + "open" + "\\" + "command";

            string ExePath = Registry.GetValue(keyName, "", "").ToString();
            txtExePath.Text = ExePath;
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnRegiter_Click(object sender, EventArgs e)
        {


            WriteRegistry(txtProtocol.Text.Trim(),txtprotocolUrl.Text.Trim(),txtExePath.Text.Trim(),CboInstalledPrinter.Text.Trim());


        }

        private void BtnGetInstalledPrinter_Click(object sender, EventArgs e)
        {
            CboInstalledPrinter.Items.Clear();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                CboInstalledPrinter.Items.Add(printer);
            }
            MessageBox.Show("done");
        }

        private void BtnReadRegistry_Click(object sender, EventArgs e)
        {
            ReadRegistry();
        }
    }
}
