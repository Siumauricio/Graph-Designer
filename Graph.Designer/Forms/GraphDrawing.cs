using Graph.Designer.Structure;
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
        List<Graphs> Graph;
        public GraphDrawing(List<Graphs> _graphs)
        {
            InitializeComponent();
            this.Graph = _graphs;
        }

        private void GraphDrawing_Load(object sender, EventArgs e)
        {
            Paint_Graph();
            SetGradeGraph();
        }
        private void Paint_Graph()
        {
            int x = 130;
            int y = 110;
            int spaces = 0;
            for (int i = 0; i < Graph.Count; i++)
            {
                RoundButton roundButton = new RoundButton();
                roundButton.Location = new Point(x, y);
                roundButton.Width = 52;
                roundButton.Height = 54;
                roundButton.Name = Graph[i].Node.ToString();
                roundButton.Font = new Font("Arial", 12, FontStyle.Bold);
                roundButton.Text = Graph[i].Node.ToString();
                roundButton.LocationChanged += new EventHandler(RountButton_Move);
                this.Controls.Add(roundButton);
                ControlExtension.Draggable(roundButton, true);
                Graph[i].PositionX = x;
                Graph[i].PositionY = y;
                x += 150;
                spaces++;
                if (spaces == 3)
                {
                    y += 100;
                    x = 130;
                    spaces = 0;
                }
            }
        }
        private void SetGradeGraph()
        {
            int gradeGraph = 0;
            for (int i = 0; i < Graph.Count; i++)
            {
                if (Graph[i].Edges.Count > gradeGraph)
                {
                    gradeGraph = Graph[i].Edges.Count;
                }
            }
            label2.Text = ""+gradeGraph;
        }
        private void RountButton_Move(object sender, EventArgs e)
        {
            Button cb = (Button)sender;
            string strName = cb.AccessibleName;
            Graphs graph = Graph.Find(data => data.Node == int.Parse(cb.Name));
            graph.PositionX = cb.Bounds.X;
            graph.PositionY = cb.Bounds.Y;
            this.Invalidate();
        }

        private void GraphDrawing_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Graph.Count; i++)
            {
                 DrawCurve(Graph[i], e);
            }
        }
        private void DrawCurve(Graphs NodeA,PaintEventArgs e)
        {
            int NodeApositionX = NodeA.PositionX;
            int NodeApositionY = NodeA.PositionY;
            for (int i = 0; i < NodeA.Edges.Count; i++)
            {
                if (NodeA.Node == NodeA.Edges[i])
                {
                    Rectangle rect = new Rectangle(NodeA.PositionX + 5, NodeA.PositionY -5, 40, 90);
                    e.Graphics.DrawArc(new Pen(new SolidBrush(Color.Black), 3), rect, -20, -150);
                }
                else
                {
                    Graphs nodeB = Graph.Find(data => data.Node == NodeA.Edges[i]);
                    int NodeBpositionX = nodeB.PositionX;
                    int NodeBpositionY = nodeB.PositionY;
                    Pen pen = new Pen(Color.Black);
                    e.Graphics.DrawLine(pen, new Point(NodeA.PositionX + 40, NodeA.PositionY + 30), new Point(NodeBpositionX + 40, NodeBpositionY + 30));
                }
            }
        }
    }
}
