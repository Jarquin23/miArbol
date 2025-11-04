using System;
using System.Drawing;
using System.Windows.Forms;

namespace miArbol
{
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tvArbol.SelectedNode != null)
            {
                tvArbol.SelectedNode.Nodes.Add(tbNodo.Text);
            }
            if (tvArbol.Nodes.Count == 0)
            {
                tvArbol.Nodes.Add(tbNodo.Text);
            }
            tvArbol.ExpandAll();
        }


        private void tvArbol_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void tvArbol_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node == tvArbol.SelectedNode)
            {
                e.Graphics.FillRectangle(Brushes.BlueViolet, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, tvArbol.Font, e.Bounds, Color.White, TextFormatFlags.Default);
            }
            else
            {
                e.DrawDefault = true;
            }
        }
    }
}