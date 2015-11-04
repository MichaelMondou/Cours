using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphX
{
    public partial class GraphXForm : Form
    {
        public static readonly Size sizeLimit = new Size(470, 375);

        private bool responsiveMode = false;
        private Point origin = new Point(0, 0);

        private List<Vertex> vertexes = new List<Vertex>();
        private Vertex hoveredVertex;
        private Vertex selectedVertex;
        private Vertex grabbedVertex;
        
        private List<Edge> edges = new List<Edge>();
        private Edge temporaryEdge;

        public GraphXForm()
        {
            InitializeComponent();
            CollapseProperties(true);
        }

        #region Vertexes functions
        /*FONCTIONS_DES_SOMMETS****************************************/

        //Cette fonction permet d'ajouter le sommet donné au graphe.
        private void AddVertex(Vertex vertex)
        {
            vertexes.Add(vertex);
            mainPanel.Refresh();
        }

        //Cette fonction permet de sélectionner le sommet donné, et déselectionner l'ancien (s'il existe).
        private void SelectVertex(Vertex other, MouseButtons button)
        {
            if (selectedVertex != null)
            {
                selectedVertex.Color = selectedVertex.TrueColor;
            }
            selectedVertex = other;
            selectedVertex.Color = Vertex.selectedColor;
            OpenSelectedVertexProperties();

            if (button == MouseButtons.Left)
            {
                grabbedVertex = selectedVertex;
            }
            mainPanel.Refresh();
        }

        //Cette fonction permet de faire bouger le sommet qui a été attrapé.
        private void MoveGrabbedVertex(Point p)
        {
            if(grabbedVertex != null)
            {
                grabbedVertex.Location = p;
                mainPanel.Refresh();
            }
        }

        //Cette fonction permet de lâcher le sommet qui a été attrapé.
        private void ReleaseGrabbedVertex()
        {
            grabbedVertex = null;
            mainPanel.Refresh();
        }

        //Cette fonction permet de changer la couleur du sommet donné (celui qui est survolé par la souris, s'il existe).
        private void HoverVertex(Vertex nextHoveredVertex)
        {
            if (hoveredVertex != null)
            {
                if (hoveredVertex != selectedVertex)
                {
                    hoveredVertex.Color = hoveredVertex.TrueColor;
                }
            }
            hoveredVertex = nextHoveredVertex;
            if (hoveredVertex != selectedVertex)
            {
                hoveredVertex.Color = Vertex.hoveredColor;
            }
            mainPanel.Refresh();
        }

        //Cette fonction permet de libérer le sommet sélectionné (s'il existe).
        private void ReleaseHoveredVertex()
        {
            if (hoveredVertex != null)
            {
                hoveredVertex.Color = hoveredVertex.TrueColor;
                hoveredVertex = null;
                mainPanel.Refresh();
            }
        }

        /**************************************************************/
        #endregion

        #region Edges functions
        /*FONCTIONS_DES_ARETES*****************************************/

        //Cette fonction permet d'ajouter une arête à partir de l'arête temporaire.
        private void AddEdge(Point destination)
        {
            temporaryEdge.Destination = CheckWhoContains(destination);
            edges.Add(temporaryEdge);
            temporaryEdge = null;
            mainPanel.Refresh();
        }

        //Cette fonction permet d'ajouter une arête temporaire, en attente de la placer sur un autre sommet.
        private void WaitForEdgePlacement(Point destination)
        {
            temporaryEdge = new Edge(selectedVertex, new Vertex(destination));
        }

        //Cette fonction permet de faire en sorte que l'arête temporaire suive la souris.
        private void MoveTemporaryEdge(Point p)
        {
            if (temporaryEdge != null)
            {
                temporaryEdge.Destination.Location = p;
                mainPanel.Refresh();
            }
        }

        /**************************************************************/
        #endregion

        #region Paint functions
        /*FONCTIONS_DE_DESSIN*********************************/

        //Cette fonction permet de dessiner tous les sommets.
        private void PaintVertexes(Graphics g)
        {
            foreach (Vertex v in vertexes)
            {
                v.Paint(origin, Font, g);
            }
        }

        //Cette fonction permet de dessiner toutes les arêtes.
        private void PaintEdges(Graphics g)
        {
            foreach (Edge ed in edges)
            {
                ed.Paint(origin, Font, g);
            }

            if (temporaryEdge != null)
            {
                temporaryEdge.Destination.Paint(origin, Font, g);
                temporaryEdge.Paint(origin, Font, g);
            }
        }

        /**************************************************************/
        #endregion

        #region Event functions [Keep out]
        /*FONCTIONS_EVENEMENTS*****************************************/

        #region Paint Events

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            PaintVertexes(e.Graphics);
            PaintEdges(e.Graphics);
        }

        #endregion

        #region Window Events

        private void GraphXForm_SizeChanged(object sender, EventArgs e)
        {
            responsiveMode = Size.Width < sizeLimit.Width || Size.Height < sizeLimit.Height;
            if (responsiveMode)
            {
                CollapseProperties(!responsiveMode);
                buttonCollapse.Visible = !responsiveMode;
            }
            else
            {
                buttonCollapse.Visible = !responsiveMode;
            }
        }

        #endregion

        #region Collapse Region Events

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            CollapseProperties(mainSplitContainer.Panel2Collapsed);
        }

        #endregion

        #region ScrollBar Events

        private void horizontalScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            origin = new Point(-horizontalScrollBar.Value, 0);
            mainPanel.Refresh();
        }

        #endregion

        #region Properties Events

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (selectedVertex != null)
            {
                selectedVertex.Name = textBoxName.Text;
                mainPanel.Refresh();
            }
        }

        private void numericUpDownLocationX_ValueChanged(object sender, EventArgs e)
        {
            if (selectedVertex != null)
            {
                selectedVertex.Location = new Point((int)numericUpDownLocationX.Value, selectedVertex.Location.Y);
                mainPanel.Refresh();
            }
        }

        private void numericUpDownLocationY_ValueChanged(object sender, EventArgs e)
        {
            if (selectedVertex != null)
            {
                selectedVertex.Location = new Point(selectedVertex.Location.X, (int)numericUpDownLocationY.Value);
                mainPanel.Refresh();
            }
        }

        private void numericUpDownSizeWidth_ValueChanged(object sender, EventArgs e)
        {
            if (selectedVertex != null)
            {
                selectedVertex.Size = new Size((int)numericUpDownSizeWidth.Value, selectedVertex.Size.Height);
                mainPanel.Refresh();
            }
        }

        private void numericUpDownSizeHeight_ValueChanged(object sender, EventArgs e)
        {
            if (selectedVertex != null)
            {
                selectedVertex.Size = new Size(selectedVertex.Size.Width, (int)numericUpDownSizeHeight.Value);
                mainPanel.Refresh();
            }
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            if (selectedVertex != null)
            {
                selectedVertex.Width = (byte)numericUpDownWidth.Value;
                mainPanel.Refresh();
            }
        }

        private void labelBoxColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (selectedVertex != null)
                {
                    labelBoxColor.BackColor = dialog.Color;
                    selectedVertex.TrueColor = labelBoxColor.BackColor;
                    selectedVertex.Color = labelBoxColor.BackColor;
                    mainPanel.Refresh();
                }
            }
        }

        #endregion

        #region Mouse Events

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Vertex vertex = new Vertex(e.Location);
            Vertex other = CheckWhoIntersects(vertex);

            if (other == null)
            {
                AddVertex(vertex);
            }
            else
            {
                SelectVertex(other, e.Button);

                if(e.Button == MouseButtons.Right)
                {
                    if (temporaryEdge == null)
                    {
                        WaitForEdgePlacement(e.Location);
                    }
                    else
                    {
                        AddEdge(e.Location);
                    }
                }
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Vertex nextHoveredVertex = CheckWhoContains(e.Location);

            if(nextHoveredVertex != null)
            {
                if(hoveredVertex != nextHoveredVertex)
                {
                    HoverVertex(nextHoveredVertex);
                }
            }
            else
            {
                if (hoveredVertex != selectedVertex)
                {
                    ReleaseHoveredVertex();
                }
            }

            MoveGrabbedVertex(e.Location);
            MoveTemporaryEdge(e.Location);
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(grabbedVertex != null)
            {
                ReleaseGrabbedVertex();
            }
        }

        #endregion

        /**************************************************************/
        #endregion

        #region Utility functions [Keep out]
        /*FONCTIONS_UTILITAIRES*****************************************/

        //Cette fonction permet d'ouvrir les propriétés d'un sommet dans la fenêtre de droite. On peut les modifier en temps réel !
        private void OpenSelectedVertexProperties()
        {
            if (selectedVertex != null)
            {
                CollapseProperties(true);
                textBoxName.Text = selectedVertex.Name;
                numericUpDownLocationX.Value = selectedVertex.Location.X;
                numericUpDownLocationY.Value = selectedVertex.Location.Y;
                numericUpDownSizeWidth.Value = selectedVertex.Size.Width;
                numericUpDownSizeHeight.Value = selectedVertex.Size.Height;
                numericUpDownWidth.Value = selectedVertex.Width;
                labelBoxColor.BackColor = selectedVertex.TrueColor;
            }
        }

        //Cette fonction permet le bon fonctionnement du système d'ouverture/fermeture de la fenêtre de droite.
        private void CollapseProperties(bool open)
        {
            mainSplitContainer.Panel2Collapsed = !open;
            horizontalScrollBar.Visible = open;
            horizontalScrollBar.LargeChange = Size.Width - mainSplitContainer.Panel2.Width;
            horizontalScrollBar.Maximum = Size.Width;
            if (!open)
            {
                buttonCollapse.Image = GraphX.Properties.Resources.tinyleftarrow;
            }
            else
            {
                buttonCollapse.Image = GraphX.Properties.Resources.tinyrightarrow;
            }
            origin = new Point(0, 0);
            mainPanel.Refresh();
        }

        //Cette fonction permet de vérifier si un sommet contient le point donné, et de le renvoyer.
        private Vertex CheckWhoContains(Point point)
        {
            foreach (Vertex v in vertexes)
            {
                if (v.Contains(point))
                {
                    return v;
                }
            }
            return null;
        }

        //Cette fonction permet de savoir si une sommet donné possède une ou plusieurs intersections avec un autre, et de le renvoyer.
        private Vertex CheckWhoIntersects(Vertex vertex)
        {
            foreach (Vertex v in vertexes)
            {
                if (v.Intersects(vertex) && v != vertex)
                {
                    return v;
                }
            }
            return null;
        }

        /**************************************************************/
        #endregion
    }
}