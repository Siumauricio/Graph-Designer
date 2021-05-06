using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph.Designer.Forms
{
    class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            using (var path = new GraphicsPath() )
            {
                path.AddEllipse(2, 2, ClientSize.Width - 5, ClientSize.Height - 5);
                this.Region = new Region(path);
            }
            base.OnPaint(e);
        }
    }

}
