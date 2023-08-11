using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterForm
{
    public partial class Form1 : Form
    {
        //using the decision of clicking the mouse button to paint.
        bool ShouldPaint { get; set; } = false;
        
        //default constructor
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        //Drawing a circle whenever mouse moves with its button down.
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint) 
            {
                // a Using statement for Graphics object.
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Crimson), e.X, e.Y, 10, 10);
                    
                }

            }
        }
    }
}
