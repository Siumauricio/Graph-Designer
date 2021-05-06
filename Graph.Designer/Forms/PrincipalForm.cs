using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graph.Designer.Structure;
namespace Graph.Designer.Forms
{
    public partial class PrincipalForm : Form
    {
        List<Graphs> Graph;
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Graph = new List<Graphs>();
            AddVertex(textBox1.Text);
            AddEdges(textBox2.Text);
            GraphDrawing graphDrawing = new GraphDrawing(this.Graph);
            graphDrawing.Show();
        }
        private void AddVertex(string textbox)
        {
            string vertex = textbox.Substring(1, textbox.Length - 2);
            var vertex_Array = vertex.Split(",").ToList();

            for (int i = 0; i < vertex_Array.Count; i++)
            {
                var data = new Graphs()
                {
                    Node = int.Parse(vertex_Array[i])
                };
                Graph.Add(data);
            }
        }
        private void AddEdges(string textbox)
        {
            string edges = textbox.Substring(1, textbox.Length - 2);
            var edges_Array = edges.Split(".").ToList();
            for (int i = 0; i < edges_Array.Count; i++)
            {
                string test = edges_Array[i].Substring(1, edges_Array[i].Length - 2);
                var list = test.Split(",").ToList();
                Graphs INode = Graph.Find(data => data.Node == int.Parse(list[0])); //Search Node for add Edges.
                INode.Edges.Add(int.Parse(list[1]));
            }
        }

        private void button1_Move(object sender, EventArgs e)
        {

        }
    }
}
