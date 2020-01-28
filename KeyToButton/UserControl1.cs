using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyToButton
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World.  This key was pressed: " + e.ToString());
        }

        private void button1_KeyDown(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar > 0)
           
                button1_Click(this, new EventArgs());    
        }
    }
}
