namespace miArbol
{
    partial class frmArbol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNodo = new System.Windows.Forms.Label();
            this.tbNodo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblNodo
            // 
            this.lblNodo.AutoSize = true;
            this.lblNodo.Location = new System.Drawing.Point(36, 34);
            this.lblNodo.Name = "lblNodo";
            this.lblNodo.Size = new System.Drawing.Size(106, 13);
            this.lblNodo.TabIndex = 0;
            this.lblNodo.Text = "Ingresa un elemento:";
            // 
            // tbNodo
            // 
            this.tbNodo.Location = new System.Drawing.Point(149, 34);
            this.tbNodo.Name = "tbNodo";
            this.tbNodo.Size = new System.Drawing.Size(217, 20);
            this.tbNodo.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(389, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 53);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tvArbol
            // 
            this.tvArbol.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvArbol.Location = new System.Drawing.Point(39, 106);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(463, 293);
            this.tvArbol.TabIndex = 4;
            this.tvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArbol_AfterSelect_1);
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 482);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNodo);
            this.Controls.Add(this.lblNodo);
            this.Name = "frmArbol";
            this.Text = "frmArbol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNodo;
        private System.Windows.Forms.TextBox tbNodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TreeView tvArbol;
    }
}