using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestResolution
{
    public partial class Form1 : Form
    {
        SolidBrush wallBrush = new SolidBrush(Color.DodgerBlue);

        public Form1()
        {
            InitializeComponent();         
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(wallBrush, 0, 0, 600, 10); //top line
            e.Graphics.FillRectangle(wallBrush, 0, 0, 10, 400); //left line
            e.Graphics.FillRectangle(wallBrush, 0, 390, 600, 10); //bottom line
            e.Graphics.FillRectangle(wallBrush, 590, 0, 10, 400); //right line
        }

    }
}
