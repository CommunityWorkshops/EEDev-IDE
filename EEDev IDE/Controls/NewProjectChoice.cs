using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEDev_IDE.Controls
{
    public partial class NewProjectChoice : UserControl
    {

        public delegate void NewProjectTypeSelectedHandler(string projectName);
        public event NewProjectTypeSelectedHandler NewProjectTypeSelectedEvent;

        private string _projectName;

        private static Dictionary<string, bool> selectedControlDictionary = new Dictionary<string, bool>();

        public NewProjectChoice(Image projectImage, string projectName)
        {
            InitializeComponent();

            if (projectImage == null) throw new ArgumentNullException(nameof(projectImage), "Cannot be null");
            if (projectName == null) throw new ArgumentNullException(nameof(projectName), "Cannot be null");

            pbProjectImage.Image = projectImage;
            lblProjectType.Text = projectName;
            _projectName = projectName;

            selectedControlDictionary.Add(_projectName,false);
        }

        public void Selected()
        {
            Dictionary<string, bool> changeControlDictionary = new Dictionary<string, bool>();

            foreach (var pair in selectedControlDictionary)
            {
                if (pair.Value == true) changeControlDictionary.Add(pair.Key, false);
                if (pair.Key == _projectName) changeControlDictionary.Add(pair.Key, true);
            }

            foreach (var pair in changeControlDictionary)
            {
                selectedControlDictionary.Remove(pair.Key);
                selectedControlDictionary.Add(pair.Key,pair.Value);
            }

            changeControlDictionary.Clear();
            DoMouseEnter();
            
        }


        private void NewProjectChoice_MouseUp(object sender, MouseEventArgs e)
        {
            DoMouseUp();
        }

        private void DoMouseUp()
        {
            lblProjectType.BackColor = Color.CornflowerBlue;
            NewProjectTypeSelectedEvent?.Invoke(_projectName);
        }

        private void NewProjectChoice_MouseEnter(object sender, EventArgs e)
        {
            DoMouseEnter();
        }

        private void DoMouseEnter()
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void NewProjectChoice_MouseLeave(object sender, EventArgs e)
        {
            DoMouseLeave();
        }

        private void DoMouseLeave()
        {
            BorderStyle = BorderStyle.None;
        }

        private void NewProjectChoice_MouseDown(object sender, MouseEventArgs e)
        {
            DoMouseDown();
        }

        private void DoMouseDown()
        {
            lblProjectType.BackColor = Color.DarkCyan;
        }

        private void pbProjectImage_MouseEnter(object sender, EventArgs e)
        {
            DoMouseEnter();
        }

        private void pbProjectImage_MouseDown(object sender, MouseEventArgs e)
        {
            DoMouseDown();
        }

        private void pbProjectImage_MouseLeave(object sender, EventArgs e)
        {
            DoMouseLeave();
        }

        private void pbProjectImage_MouseUp(object sender, MouseEventArgs e)
        {
            DoMouseUp();
        }

        private void lblProjectType_MouseDown(object sender, MouseEventArgs e)
        {
            DoMouseDown();
        }

        private void lblProjectType_MouseEnter(object sender, EventArgs e)
        {
            DoMouseEnter();
        }

        private void lblProjectType_MouseLeave(object sender, EventArgs e)
        {
            DoMouseLeave();
        }

        private void lblProjectType_MouseUp(object sender, MouseEventArgs e)
        {
            DoMouseUp();
        }
    }
}
