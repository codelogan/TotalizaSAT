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
            this.sair = new System.Windows.Forms.Button();
            this.txtCaminhoXML = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.AbrePasta = new System.Windows.Forms.Button();
            this.dgvHashCupons = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashCupons)).BeginInit();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(499, 279);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(69, 34);
            this.sair.TabIndex = 1;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // txtCaminhoXML
            // 
            this.txtCaminhoXML.Location = new System.Drawing.Point(159, 12);
            this.txtCaminhoXML.Name = "txtCaminhoXML";
            this.txtCaminhoXML.Size = new System.Drawing.Size(471, 20);
            this.txtCaminhoXML.TabIndex = 3;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(216, 287);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(48, 16);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total:";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // AbrePasta
            // 
            this.AbrePasta.Location = new System.Drawing.Point(642, 11);
            this.AbrePasta.Name = "AbrePasta";
            this.AbrePasta.Size = new System.Drawing.Size(118, 22);
            this.AbrePasta.TabIndex = 6;
            this.AbrePasta.Text = "Abrir pasta";
            this.AbrePasta.UseVisualStyleBackColor = true;
            this.AbrePasta.Click += new System.EventHandler(this.AbrePasta_Click);
            // 
            // dgvHashCupons
            // 
            this.dgvHashCupons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHashCupons.Location = new System.Drawing.Point(12, 38);
            this.dgvHashCupons.Name = "dgvHashCupons";
            this.dgvHashCupons.Size = new System.Drawing.Size(851, 222);
            this.dgvHashCupons.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Caminho:";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(394, 279);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(65, 34);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrar.Location = new System.Drawing.Point(271, 329);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(297, 15);
            this.lblMostrar.TabIndex = 11;
            this.lblMostrar.Text = "Selecione a pasta onde se encontram os arquivos XML SAT.";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 353);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHashCupons);
            this.Controls.Add(this.AbrePasta);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.txtCaminhoXML);
            this.Controls.Add(this.sair);
            this.Name = "Principal";
            this.Text = "Totalizador de Cupons fiscais SAT";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashCupons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox txtCaminhoXML;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button AbrePasta;
        private System.Windows.Forms.DataGridView dgvHashCupons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblMostrar;
    }
}

