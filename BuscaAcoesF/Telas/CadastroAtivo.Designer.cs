﻿namespace BuscaAcoesF.Formularios
{
    partial class CadastroAtivo
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
            this.label6 = new System.Windows.Forms.Label();
            this.numQuantidadeCotas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numOrdem = new System.Windows.Forms.NumericUpDown();
            this.numValorDesejado = new System.Windows.Forms.TextBox();
            this.numValorbaixa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.homeBrokerGroupBox1 = new BuscaAcoesF.Formularios.Estilo.HomeBrokerGroupBox();
            this.btnRemover = new BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton();
            this.btnSalvar = new BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton();
            this.homeBrokerGroupBox2 = new BuscaAcoesF.Formularios.Estilo.HomeBrokerGroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeCotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdem)).BeginInit();
            this.homeBrokerGroupBox1.SuspendLayout();
            this.homeBrokerGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cotas:";
            // 
            // numQuantidadeCotas
            // 
            this.numQuantidadeCotas.Location = new System.Drawing.Point(332, 46);
            this.numQuantidadeCotas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantidadeCotas.Name = "numQuantidadeCotas";
            this.numQuantidadeCotas.Size = new System.Drawing.Size(67, 20);
            this.numQuantidadeCotas.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ordem:";
            // 
            // numOrdem
            // 
            this.numOrdem.Location = new System.Drawing.Point(332, 20);
            this.numOrdem.Name = "numOrdem";
            this.numOrdem.Size = new System.Drawing.Size(67, 20);
            this.numOrdem.TabIndex = 12;
            // 
            // numValorDesejado
            // 
            this.numValorDesejado.Location = new System.Drawing.Point(62, 46);
            this.numValorDesejado.Name = "numValorDesejado";
            this.numValorDesejado.Size = new System.Drawing.Size(87, 20);
            this.numValorDesejado.TabIndex = 8;
            // 
            // numValorbaixa
            // 
            this.numValorbaixa.Location = new System.Drawing.Point(196, 20);
            this.numValorbaixa.Name = "numValorbaixa";
            this.numValorbaixa.Size = new System.Drawing.Size(87, 20);
            this.numValorbaixa.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baixa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desejado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ativo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(62, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(87, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // homeBrokerGroupBox1
            // 
            this.homeBrokerGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeBrokerGroupBox1.Controls.Add(this.btnRemover);
            this.homeBrokerGroupBox1.Controls.Add(this.btnSalvar);
            this.homeBrokerGroupBox1.Controls.Add(this.label6);
            this.homeBrokerGroupBox1.Controls.Add(this.numQuantidadeCotas);
            this.homeBrokerGroupBox1.Controls.Add(this.txtCodigo);
            this.homeBrokerGroupBox1.Controls.Add(this.label5);
            this.homeBrokerGroupBox1.Controls.Add(this.label1);
            this.homeBrokerGroupBox1.Controls.Add(this.numOrdem);
            this.homeBrokerGroupBox1.Controls.Add(this.label2);
            this.homeBrokerGroupBox1.Controls.Add(this.label3);
            this.homeBrokerGroupBox1.Controls.Add(this.numValorDesejado);
            this.homeBrokerGroupBox1.Controls.Add(this.numValorbaixa);
            this.homeBrokerGroupBox1.Location = new System.Drawing.Point(7, 59);
            this.homeBrokerGroupBox1.Name = "homeBrokerGroupBox1";
            this.homeBrokerGroupBox1.Size = new System.Drawing.Size(646, 83);
            this.homeBrokerGroupBox1.TabIndex = 1;
            this.homeBrokerGroupBox1.TabStop = false;
            this.homeBrokerGroupBox1.Text = "homeBrokerGroupBox1";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemover.Location = new System.Drawing.Point(557, 19);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(83, 45);
            this.btnRemover.TabIndex = 34;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSalvar.Location = new System.Drawing.Point(476, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 45);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // homeBrokerGroupBox2
            // 
            this.homeBrokerGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeBrokerGroupBox2.Controls.Add(this.dataGridView1);
            this.homeBrokerGroupBox2.Location = new System.Drawing.Point(7, 148);
            this.homeBrokerGroupBox2.Name = "homeBrokerGroupBox2";
            this.homeBrokerGroupBox2.Size = new System.Drawing.Size(645, 457);
            this.homeBrokerGroupBox2.TabIndex = 1;
            this.homeBrokerGroupBox2.TabStop = false;
            this.homeBrokerGroupBox2.Text = "homeBrokerGroupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(631, 443);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClose.Location = new System.Drawing.Point(623, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // CadastroAtivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 611);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.homeBrokerGroupBox2);
            this.Controls.Add(this.homeBrokerGroupBox1);
            this.MaximizeBox = false;
            this.Name = "CadastroAtivo";
            this.Text = "CadastroAtivo";
            this.Load += new System.EventHandler(this.CadastroAtivo_Load);
            this.Controls.SetChildIndex(this.homeBrokerGroupBox1, 0);
            this.Controls.SetChildIndex(this.homeBrokerGroupBox2, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeCotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdem)).EndInit();
            this.homeBrokerGroupBox1.ResumeLayout(false);
            this.homeBrokerGroupBox1.PerformLayout();
            this.homeBrokerGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numValorDesejado;
        private System.Windows.Forms.TextBox numValorbaixa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numOrdem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numQuantidadeCotas;
        private Formularios.Estilo.HomeBrokerGroupBox homeBrokerGroupBox1;
        private BuscaAcoesF.Formularios.Estilo.HomeBrokerGroupBox homeBrokerGroupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton btnRemover;
        private BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton btnSalvar;
        private BuscaAcoesF.Formularios.Estilo.HomeBrokerFlatButton btnClose;
    }
}