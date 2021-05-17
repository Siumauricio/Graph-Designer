using Graph.Designer.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graph.Designer.Forms
{
    public partial class GraphDrawing : Form
    {
        List<Graphs> Graph;
        List<Graphs> GraphAlgorithm;
        List<int> lstQuantity = new List<int>();
        List<int> Path;
        int drawOption = 0;
        Pen penPath;
        int[,] table;

        public GraphDrawing(List<Graphs> _graphs)
        {
            InitializeComponent();
            this.Graph = _graphs;
            this.GraphAlgorithm = _graphs;
        }

        private void GraphDrawing_Load(object sender, EventArgs e)
        {
            Paint_Graph();
            SetGradeGraph();
            SumGradeGraph();
            MinusGradeGraph();
            ListEdges();
            ConvertToGraph();
            CyclicFunction();
        }

        private void ListEdges()
        {
            for (int i = 0; i < this.Graph.Count; i++)
            {
                this.lst1.Items.Add(this.Graph[i].Node);
                this.lst2.Items.Add(this.Graph[i].Node);
            }
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
                this.lstQuantity.Add(Graph[i].Edges.Count());//ups
                if (Graph[i].Edges.Count > gradeGraph)
                {
                    gradeGraph = Graph[i].Edges.Count;
                }
            }
            label2.Text = "" + gradeGraph;
        }

        private void SumGradeGraph()
        {
            int sumGraph = 0;
            for (int i = 0; i < this.Graph.Count; i++)
            {
                sumGraph += this.Graph[i].Node;
            }
            this.label3.Text = "" + sumGraph;
        }

        private void MinusGradeGraph()
        {
            int minus = this.Graph[0].Node;
            for (int i = 0; i < this.Graph.Count; i++)
            {
                if (this.Graph[i].Node < minus)
                {
                    minus = this.Graph[i].Node;
                }
            }
            this.label5.Text = "" + minus;
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
            this.penPath = new Pen(Color.Blue);
            this.penPath.Width = 3.0F;

            switch (drawOption)
            {
                case 1:
                    if (Path.Count > 1)
                    {
                        for (int i = 0; i < this.Path.Count(); i++)
                        {
                            if (i == this.Path.Count() - 1) { break; }
                            for (int j = 0; j < this.Graph.Count(); j++)
                            {

                                if (this.Graph[j].Node == this.Path[i])
                                {
                                    Graphs nodeB = Graph.Find(data => data.Node == this.Path[i + 1]);
                                    int NodeBpositionX = nodeB.PositionX;
                                    int NodeBpositionY = nodeB.PositionY;
                                    e.Graphics.DrawLine(penPath, new Point(this.Graph[j].PositionX + 40, this.Graph[j].PositionY + 30), new Point(NodeBpositionX + 40, NodeBpositionY + 30));
                                    break;
                                }

                            }

                        }
                    }
                    break;

                default:
                    break;

            }

        }

        private void DrawCurve(Graphs NodeA, PaintEventArgs e)//draw the line
        {
            int NodeApositionX = NodeA.PositionX;
            int NodeApositionY = NodeA.PositionY;
            for (int i = 0; i < NodeA.Edges.Count; i++)
            {
                if (NodeA.Node == NodeA.Edges[i])//esto me sirve
                {
                    Rectangle rect = new Rectangle(NodeA.PositionX + 5, NodeA.PositionY - 5, 40, 90);
                    e.Graphics.DrawArc(new Pen(new SolidBrush(Color.Black), 3), rect, -20, -150);
                }
                else
                {
                    Graphs nodeB = Graph.Find(data => data.Node == NodeA.Edges[i]);
                    int NodeBpositionX = nodeB.PositionX;
                    int NodeBpositionY = nodeB.PositionY;
                    Pen pen = new Pen(Color.Black);
                    e.Graphics.DrawLine(pen, new Point(NodeA.PositionX + 40, NodeA.PositionY + 30), new Point(NodeBpositionX + 40, NodeBpositionY + 30));//aqui
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btEncontrar_Click(object sender, EventArgs e)
        {
            if (this.lst1.SelectedItem == null || this.lst2.SelectedItem == null)
            {
                MessageBox.Show("Favor seleccione un inicio y un final correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int startVertex = int.Parse(this.lst1.SelectedItem.ToString());
            int endVertex = int.Parse(this.lst2.SelectedItem.ToString());
            if (startVertex == endVertex)
            {
                MessageBox.Show("Favor seleccione dos vertices distintos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!HasItEdges(startVertex) || !HasItEdges(endVertex))
            {
                MessageBox.Show("No es posible crear una ruta entre los vertices", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Path = new List<int>();
            table = new int[Graph.Count(), 4];
            LoadTable(startVertex);
            FindPath();
            LoadPath(startVertex, endVertex);
            this.drawOption = 1;
            Invalidate();
        }


        private void LoadTable(int startVertex)
        {

            for (int i = 0; i < this.GraphAlgorithm.Count(); i++)
            {
                table[i, 0] = 0; //visitado
                table[i, 1] = int.MaxValue;  //distancia
                table[i, 2] = 0;  //padre
                table[i, 3] = Graph[i].Node; //el nodo
                if (this.GraphAlgorithm[i].Node == startVertex)
                {
                    table[GetIndex(this.GraphAlgorithm[i].Node), 1] = 0;
                }
            }

        }

        private void FindPath()
        {
            for (int i = 0; i < this.GraphAlgorithm.Count(); i++)
            {
                for (int j = 0; j < this.GraphAlgorithm.Count(); j++)
                {
                    if (table[j, 0] == 0 && table[j, 1] == i)
                    {
                        table[j, 0] = 1;
                        for (int k = 0; k < this.GraphAlgorithm.Count(); k++)
                        {
                            if (IsAdyacent(j, k) == 1)
                            {
                                if (table[k, 1] == int.MaxValue)
                                {
                                    table[k, 1] = i + 1;
                                    table[k, 2] = this.GraphAlgorithm[j].Node;
                                }
                            }
                        }
                    }
                }
            }
        }


        private void LoadPath(int startVertex, int endVertex)
        {
            int nodo = endVertex;
            while (nodo != startVertex)
            {
                Path.Add(nodo);
                nodo = table[GetIndex(nodo), 2];
            }
            Path.Add(startVertex);
            Path.Reverse();
        }
        private int GetIndex(int vertex)
        {
            for (int i = 0; i < this.GraphAlgorithm.Count(); i++)
            {
                if (this.GraphAlgorithm[i].Node == vertex)
                {
                    return i;
                }
            }
            return -1;
        }

        private int IsAdyacent(int vertexIndex, int edgeIndex)
        {
            int vertex = this.GraphAlgorithm[vertexIndex].Node;
            int edge = this.GraphAlgorithm[edgeIndex].Node;

            for (int i = 0; i < GraphAlgorithm.Count(); i++)
            {
                if (this.GraphAlgorithm[i].Node == vertex)
                {
                    for (int j = 0; j < this.GraphAlgorithm[i].Edges.Count; j++)
                    {
                        if (this.GraphAlgorithm[i].Edges[j] == edge)
                        {
                            return 1;
                        }
                    }

                }

            }
            return 0;
        }

        private void ConvertToGraph()
        {
            for (int i = 0; i < GraphAlgorithm.Count; i++)
            {
                for (int j = 0; j < this.lstQuantity[i]; j++)
                {
                    for (int k = 0; k < GraphAlgorithm.Count; k++)
                    {
                        if (GraphAlgorithm[i].Edges[j] == GraphAlgorithm[k].Node)
                        {//si edge 3 de node 1  equal node 3      
                            if (GraphAlgorithm[k].Edges.Find(result => result == GraphAlgorithm[i].Edges[j]) != 1)
                            {  // if edges from node 3 found edge 3 from node 1  
                                GraphAlgorithm[k].Edges.Add(GraphAlgorithm[i].Node);
                            }
                        }
                    }
                }
            }
        }

        private bool HasItEdges(int vertex)
        {
            for (int i = 0; i < this.GraphAlgorithm.Count; i++)
            {
                if (this.GraphAlgorithm[i].Node == vertex)
                {
                    if (this.GraphAlgorithm[i].Edges.Count > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private bool IsCyclic()
        {
            bool[] visited = new bool[this.GraphAlgorithm.Count()];

            for (int i = 0; i < this.GraphAlgorithm.Count(); i++)
            {
                visited[i] = false;
            }
            for (int i = 0; i < this.GraphAlgorithm.Count(); i++)
            {
                if (!visited[i])
                {
                    if (IsCyclicVertex(i, visited, -1))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsCyclicVertex(int i, bool[] visited, int parent)
        {
            visited[i] = true;
            for (int j = 0; j < this.GraphAlgorithm[i].Edges.Count(); j++)
            {
                if (!visited[GetIndex(this.GraphAlgorithm[i].Edges[j])])
                {
                    if (IsCyclicVertex(GetIndex(this.GraphAlgorithm[i].Edges[j]), visited, i))
                    {
                        return true;
                    }
                }
                else if (GetIndex(this.GraphAlgorithm[i].Edges[j]) != parent)
                {
                    return true;
                }
            }
            return false;
        }

        private void CyclicFunction()
        {
            if (IsCyclic())
            {
                this.label8.Text = "Si";
                return;
            }
            this.label8.Text = "No";
        }

    }
}


/*
 * 
 * 
 *     private void SumGradeGraph()
        {
            int sumGraph = 0;
            for (int i = 0; i < this.Graph.Count; i++)
            {
                if (this.Graph[i].Edges.Count > 0)
                {
                    for (int j = 0; j < this.Graph[i].Edges.Count; j++)
                    {
                        sumGraph += this.Graph[i].Edges[j];
                    }
                    break;
                }
            }
            this.label3.Text = "" + sumGraph;
        }
 */

