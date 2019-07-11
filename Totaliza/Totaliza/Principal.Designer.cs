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
            this.LblTotal = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvHashCupons = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaminhoXML = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AbrePasta = new System.Windows.Forms.Button();
            this.dtpFimPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioPeriodo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sfdExportarArquivoXlsx = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashCupons)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(750, 60);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(106, 34);
            this.sair.TabIndex = 1;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(727, 23);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(43, 15);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total:";
            // 
            // ofd1
            // 
            this.ofd1.InitialDirectory = "C:\\SAT\\";
            // 
            // dgvHashCupons
            // 
            this.dgvHashCupons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHashCupons.Location = new System.Drawing.Point(6, 19);
            this.dgvHashCupons.Name = "dgvHashCupons";
            this.dgvHashCupons.Size = new System.Drawing.Size(850, 265);
            this.dgvHashCupons.TabIndex = 8;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(640, 60);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(106, 34);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(267, 23);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(394, 17);
            this.lblMostrar.TabIndex = 11;
            this.lblMostrar.Text = "Selecione a pasta onde se encontram os arquivos XML SAT.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Caminho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "a";
            // 
            // txtCaminhoXML
            // 
            this.txtCaminhoXML.Location = new System.Drawing.Point(88, 20);
            this.txtCaminhoXML.Name = "txtCaminhoXML";
            this.txtCaminhoXML.Size = new System.Drawing.Size(302, 21);
            this.txtCaminhoXML.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Arquivos gerados de:";
            // 
            // AbrePasta
            // 
            this.AbrePasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrePasta.Location = new System.Drawing.Point(396, 19);
            this.AbrePasta.Name = "AbrePasta";
            this.AbrePasta.Size = new System.Drawing.Size(118, 54);
            this.AbrePasta.TabIndex = 18;
            this.AbrePasta.Text = "Abrir pasta";
            this.AbrePasta.UseVisualStyleBackColor = true;
            this.AbrePasta.Click += new System.EventHandler(this.AbrePasta_Click);
            // 
            // dtpFimPeriodo
            // 
            this.dtpFimPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFimPeriodo.Location = new System.Drawing.Point(291, 52);
            this.dtpFimPeriodo.Name = "dtpFimPeriodo";
            this.dtpFimPeriodo.Size = new System.Drawing.Size(99, 21);
            this.dtpFimPeriodo.TabIndex = 21;
            this.dtpFimPeriodo.ValueChanged += new System.EventHandler(this.dtpFimPeriodo_ValueChanged);
            // 
            // dtpInicioPeriodo
            // 
            this.dtpInicioPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioPeriodo.Location = new System.Drawing.Point(165, 52);
            this.dtpInicioPeriodo.Name = "dtpInicioPeriodo";
            this.dtpInicioPeriodo.Size = new System.Drawing.Size(100, 21);
            this.dtpInicioPeriodo.TabIndex = 20;
            this.dtpInicioPeriodo.ValueChanged += new System.EventHandler(this.dtpInicioPeriodo_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AbrePasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpInicioPeriodo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFimPeriodo);
            this.groupBox1.Controls.Add(this.txtCaminhoXML);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 83);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Critérios de busca:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHashCupons);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 290);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cupons Fiscais encontrados:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sair);
            this.groupBox3.Controls.Add(this.lblMostrar);
            this.groupBox3.Controls.Add(this.LblTotal);
            this.groupBox3.Controls.Add(this.btnExportar);
            this.groupBox3.Location = new System.Drawing.Point(12, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(862, 100);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Totalizador de Cupons fiscais SAT";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashCupons)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.DataGridView dgvHashCupons;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaminhoXML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AbrePasta;
        private System.Windows.Forms.DateTimePicker dtpFimPeriodo;
        private System.Windows.Forms.DateTimePicker dtpInicioPeriodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog sfdExportarArquivoXlsx;
    }
}

