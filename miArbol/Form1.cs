using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miArbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            TreeNode nodoRaiz = new TreeNode("UAM");
            TreeNode nodoHijo1 = new TreeNode("FIA");
            TreeNode nodoHijo2 = new TreeNode("FCAE");
            TreeNode isi = new TreeNode("Ingeniería en Sistemas");
            TreeNode ic = new TreeNode("Ingeniería Civil");
            TreeNode con = new TreeNode("Contabilidad");
            TreeNode ae = new TreeNode("Administración de Empresas");

            nodoHijo1.Nodes.Add(isi);
            nodoHijo1.Nodes.Add(ic);
            nodoHijo2.Nodes.Add(con);
            nodoHijo2.Nodes.Add(ae);

            nodoRaiz.Nodes.Add(nodoHijo1);
            nodoRaiz.Nodes.Add(nodoHijo2);
            tvArbol.Nodes.Add(nodoRaiz);
            
            
        }
    }
}
