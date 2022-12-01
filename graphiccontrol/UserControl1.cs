using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graphiccontrol
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public Graphics g;
        public Pen pen0 = new Pen(Color.Black, 1);
        public Brush brush0 = new SolidBrush(Color.Black);
        public Font font0 = new Font("Arial", 10);

        private void UserControl1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }
    }
}
