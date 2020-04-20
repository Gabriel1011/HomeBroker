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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton();
            this.btnCadastrarCompra = new BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton();
            this.numValorPago = new BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerTextBox();
            this.homeBrokerLabel1 = new BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerLabel();
            this.homeBrokerLabel2 = new BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.homeBrokerLabel2);
            this.groupBox1.Controls.Add(this.homeBrokerLabel1);
            this.groupBox1.Controls.Add(this.numValorPago);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.btnCadastrarCompra);
            this.groupBox1.Controls.Add(this.numQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemover.Location = new System.Drawing.Point(440, 18);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(83, 25);
            this.btnRemover.TabIndex = 36;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCadastrarCompra
            // 
            this.btnCadastrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCadastrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCadastrarCompra.Location = new System.Drawing.Point(350, 18);
            this.btnCadastrarCompra.Name = "btnCadastrarCompra";
            this.btnCadastrarCompra.Size = new System.Drawing.Size(84, 26);
            this.btnCadastrarCompra.TabIndex = 35;
            this.btnCadastrarCompra.Text = "Cadastrar";
            this.btnCadastrarCompra.UseVisualStyleBackColor = false;
            this.btnCadastrarCompra.Click += new System.EventHandler(this.btnCadastrarCompra_Click);
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
            this.groupBox2.Size = new System.Drawing.Size(529, 329);
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
            this.dataGridView1.Size = new System.Drawing.Size(517, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClose.Location = new System.Drawing.Point(513, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // numValorPago
            // 
            this.numValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numValorPago.Location = new System.Drawing.Point(59, 20);
            this.numValorPago.Name = "numValorPago";
            this.numValorPago.Size = new System.Drawing.Size(100, 24);
            this.numValorPago.TabIndex = 37;
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
            // CompraAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 446);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompraAtivos";
            this.Text = "Compras de aivo";
            this.Load += new System.EventHandler(this.CompraAtivos_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton btnRemover;
        private BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton btnCadastrarCompra;
        private BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton btnClose;
        private BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerLabel homeBrokerLabel1;
        private BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerTextBox numValorPago;
        private BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados.HomeBrokerLabel homeBrokerLabel2;
    }
}