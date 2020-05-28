using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            //do some work upon clicking the button
            MessageBox.Show((sender as Button).Text);
        }
    }
    //now were done, lets build it
}
