using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph.Designer.Forms
{
    public partial class GraphDrawing : Form
    {
        public GraphDrawing()
        {
            InitializeComponent();
        }

        private void GraphDrawing_Load(object sender, EventArgs e)
        {
            Label Label = new Label();
            Label.Location = new System.Drawing.Point(50, 50);
            Label.Width = 45;
            Label.Height = 30;
            Label.Font = new Font(Label.Font.FontFamily, 14);
            Label.Name = "lblTest";
            Label.Text = "123";
            this.Controls.Add(Label);
        }

        private void GraphDrawing_Paint(object sender, PaintEventArgs e)
        {
            var lbl = this.Controls.Find("lblTest", true); // find label with name

            foreach (var item in lbl)
            // there can be multiple lblTest with same name so I used foreach (this is optional btw you can remove it)
            {
                Label tempLabel = item as Label;
                Pen myPen = new Pen(Color.Black, 4);
                e.Graphics.DrawEllipse(myPen, new Rectangle(tempLabel.Location.X - (tempLabel.Width / 2),
                tempLabel.Location.Y - (tempLabel.Height / 2), tempLabel.Width+40, tempLabel.Height+40));
                myPen.Dispose();
            }
        }
    }
}
