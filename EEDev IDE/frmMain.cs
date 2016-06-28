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
using EEDev_IDE.Forms.Dialog;
using EEDev_IDE.Forms.Docking;
using EEDev_IDE.Forms.Splash;
using WeifenLuo.WinFormsUI.Docking;

namespace EEDev_IDE
{
    public partial class FrmMain : Form
    {

        private bool _saveLayout = true;
        private DeserializeDockContent _deserializeDockContent;

        private FrmStartUpWindow _startupWindow = new FrmStartUpWindow();
        private readonly string _configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");


        public FrmMain()
        {
            InitializeComponent();
            var splash = new FrmSplash();

      //      splash.Show();
            _deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);


        }



        #region Start Window Events

        private void _startupWindow_NewProjectEvent()
        {
            ToggleMenuMain();
            ToggleToolstripMain();
            NewProject();
            ToggleMenuMain();
            ToggleToolstripMain();
        }

        private void LoadStartUpWindow()
        {
            if (_startupWindow != null || !_startupWindow.IsDisposed)
            {
                try
                {
                    _startupWindow.NewProjectEvent += _startupWindow_NewProjectEvent;
                    _startupWindow.Show(dockPanel, DockState.Document);
                }
                catch (Exception)
                {
                    _startupWindow = new FrmStartUpWindow();
                    _startupWindow.NewProjectEvent += _startupWindow_NewProjectEvent;
                    _startupWindow.Show(dockPanel, DockState.Document);
                }

            }
            else
            {
                _startupWindow = new FrmStartUpWindow();
                _startupWindow.NewProjectEvent += _startupWindow_NewProjectEvent;
                _startupWindow.Show(dockPanel, DockState.Document);
            }
        }

        private void CloseStartWindow()
        {
            _startupWindow.NewProjectEvent -= _startupWindow_NewProjectEvent;
            _startupWindow.Close();
        }
        #endregion

        #region Docking Methods
        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(FrmStartUpWindow).ToString())
            {
                startWindowToolStripMenuItem.Checked = true;
                return _startupWindow;
            }
            else
                LoadStartUpWindow();

            return null;
        }

        #endregion

        #region Main Form Events
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(_configFile))
                dockPanel.LoadFromXml(_configFile, _deserializeDockContent);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_saveLayout)
                dockPanel.SaveAsXml(_configFile);
        }

        #endregion

        #region Main Menu
        private void ToggleMenuMain()
        {
            menuMain.Enabled = !menuMain.Enabled;
        }

        #region File Menu

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        private void NewProject()
        {
            var frmNewProject = new FrmNewProject();
            var dr = frmNewProject.ShowDialog();

            if (dr == DialogResult.OK)
            {

            }
        }


        #endregion

        #region View Menu

        private void startWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleStartWindow();
        }

        private void ToggleStartWindow()
        {
            if (startWindowToolStripMenuItem.Checked)
            {
                startWindowToolStripMenuItem.Checked = false;
                CloseStartWindow();
            }
            else
            {
                startWindowToolStripMenuItem.Checked = true;
                LoadStartUpWindow();
            }
        }

        #endregion



        #endregion

        #region Main ToolStrip
        private void ToggleToolstripMain()
        {
            toolstripMain.Enabled = !toolstripMain.Enabled;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ToggleStartWindow();
        }



        #endregion


    }
}
