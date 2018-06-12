namespace Totaliza
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Totalizar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.txtCaminhoXML = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.AbrePasta = new System.Windows.Forms.Button();
            this.dgvHashCupons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashCupons)).BeginInit();
            this.SuspendLayout();
            // 
            // Totalizar
            // 
            this.Totalizar.Location = new System.Drawing.Point(12, 286);
            this.Totalizar.Name = "Totalizar";
            this.Totalizar.Size = new System.Drawing.Size(63, 35);
            this.Totalizar.TabIndex = 0;
            this.Totalizar.Text = "Totalizar";
            this.Totalizar.UseVisualStyleBackColor = true;
            this.Totalizar.Click += new System.EventHandler(this.Totalizar_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(427, 286);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(69, 34);
            this.sair.TabIndex = 1;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // txtCaminhoXML
            // 
            this.txtCaminhoXML.Location = new System.Drawing.Point(12, 23);
            this.txtCaminhoXML.Name = "txtCaminhoXML";
            this.txtCaminhoXML.Size = new System.Drawing.Size(360, 20);
            this.txtCaminhoXML.TabIndex = 3;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(104, 297);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(35, 13);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "label1";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // AbrePasta
            // 
            this.AbrePasta.Location = new System.Drawing.Point(378, 23);
            this.AbrePasta.Name = "AbrePasta";
            this.AbrePasta.Size = new System.Drawing.Size(118, 19);
            this.AbrePasta.TabIndex = 6;
            this.AbrePasta.Text = "Abrir pasta";
            this.AbrePasta.UseVisualStyleBackColor = true;
            this.AbrePasta.Click += new System.EventHandler(this.AbrePasta_Click);
            // 
            // dgvHashCupons
            // 
            this.dgvHashCupons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHashCupons.Location = new System.Drawing.Point(12, 61);
            this.dgvHashCupons.Name = "dgvHashCupons";
            this.dgvHashCupons.Size = new System.Drawing.Size(994, 207);
            this.dgvHashCupons.TabIndex = 8;
            this.dgvHashCupons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHashCupons_CellContentClick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 332);
            this.Controls.Add(this.dgvHashCupons);
            this.Controls.Add(this.AbrePasta);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.txtCaminhoXML);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.Totalizar);
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashCupons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Totalizar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox txtCaminhoXML;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button AbrePasta;
        private System.Windows.Forms.DataGridView dgvHashCupons;
    }
}

