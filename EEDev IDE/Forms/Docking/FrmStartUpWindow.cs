using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using WeifenLuo.WinFormsUI.Docking;

namespace EEDev_IDE.Forms.Docking
{
    public partial class FrmStartUpWindow : DockContent
    {

        public delegate void NewProjectEventHandler();
        public event NewProjectEventHandler NewProjectEvent;

        public FrmStartUpWindow()
        {
            InitializeComponent();
            lblVersion.Text = GetVersion();
        }

        private string GetVersion()
        {
           return Assembly.GetEntryAssembly().GetName().Version.ToString(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewProjectEvent?.Invoke();
        }
    }
}
