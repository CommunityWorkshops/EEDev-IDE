using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEDev_IDE.Forms.Splash
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private int _secs = 0;
        private void timerGui_Tick(object sender, EventArgs e)
        {
            if (_secs >= 5)
                Close();
            else
                _secs ++;
        }
    }
}
