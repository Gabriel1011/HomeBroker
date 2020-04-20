namespace BuscaAcoesF.Formularios
{
    partial class CompraAtivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraAtivos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton();
            this.btnSalvar = new BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton();
            this.homeBrokerLabel2 = new BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerLabel();
            this.homeBrokerLabel1 = new BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerLabel();
            this.numValorPago = new BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerTextBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFechar = new BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HamoBrokerCloseButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.homeBrokerLabel2);
            this.groupBox1.Controls.Add(this.homeBrokerLabel1);
            this.groupBox1.Controls.Add(this.numValorPago);
            this.groupBox1.Controls.Add(this.numQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(477, 13);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(110, 35);
            this.btnRemover.TabIndex = 41;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(361, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 35);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnCadastrarCompra_Click);
            // 
            // homeBrokerLabel2
            // 
            this.homeBrokerLabel2.AutoSize = true;
            this.homeBrokerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.homeBrokerLabel2.ForeColor = System.Drawing.Color.White;
            this.homeBrokerLabel2.Location = new System.Drawing.Point(165, 23);
            this.homeBrokerLabel2.Name = "homeBrokerLabel2";
            this.homeBrokerLabel2.Size = new System.Drawing.Size(87, 18);
            this.homeBrokerLabel2.TabIndex = 39;
            this.homeBrokerLabel2.Text = "Quantidade:";
            // 
            // homeBrokerLabel1
            // 
            this.homeBrokerLabel1.AutoSize = true;
            this.homeBrokerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.homeBrokerLabel1.ForeColor = System.Drawing.Color.White;
            this.homeBrokerLabel1.Location = new System.Drawing.Point(6, 23);
            this.homeBrokerLabel1.Name = "homeBrokerLabel1";
            this.homeBrokerLabel1.Size = new System.Drawing.Size(47, 18);
            this.homeBrokerLabel1.TabIndex = 38;
            this.homeBrokerLabel1.Text = "Pago:";
            this.homeBrokerLabel1.Click += new System.EventHandler(this.homeBrokerLabel1_Click);
            // 
            // numValorPago
            // 
            this.numValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numValorPago.Location = new System.Drawing.Point(56, 20);
            this.numValorPago.Name = "numValorPago";
            this.numValorPago.Size = new System.Drawing.Size(100, 24);
            this.numValorPago.TabIndex = 37;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(258, 23);
            this.numQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(53, 20);
            this.numQuantidade.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(581, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(582, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 35;
            this.btnFechar.TabStop = false;
            // 
            // CompraAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 446);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompraAtivos";
            this.Text = "Compras de aivo";
            this.Load += new System.EventHandler(this.CompraAtivos_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerLabel homeBrokerLabel1;
        private BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerTextBox numValorPago;
        private BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerLabel homeBrokerLabel2;
        private Estilo.HomeBrokerFlatButton btnRemover;
        private Estilo.HomeBrokerFlatButton btnSalvar;
        private Telas.Estilo.ComponentesPersonalizados.HamoBrokerCloseButton btnFechar;
    }
}