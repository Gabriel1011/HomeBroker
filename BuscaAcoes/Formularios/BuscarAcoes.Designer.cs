﻿namespace BuscaAcoes
{
    partial class BuscarAcoes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ckbTop = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDataAtualizacao = new System.Windows.Forms.Label();
            this.ckbAtualizar = new System.Windows.Forms.CheckBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnRedimencionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaisRentavel = new System.Windows.Forms.Label();
            this.lblMenoRentavel = new System.Windows.Forms.Label();
            this.lblPossiveisCompras = new System.Windows.Forms.Label();
            this.lblTotalRentabilidade = new System.Windows.Forms.Label();
            this.lblTotalGanho = new System.Windows.Forms.Label();
            this.lblTotalPerda = new System.Windows.Forms.Label();
            this.lblTotalInvestido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalRetorno = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGerarResumo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(632, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ckbTop
            // 
            this.ckbTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbTop.AutoSize = true;
            this.ckbTop.Location = new System.Drawing.Point(102, 412);
            this.ckbTop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ckbTop.Name = "ckbTop";
            this.ckbTop.Size = new System.Drawing.Size(68, 22);
            this.ckbTop.TabIndex = 1;
            this.ckbTop.Text = "Visivel";
            this.ckbTop.UseVisualStyleBackColor = true;
            this.ckbTop.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 437);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Atualizado:";
            // 
            // lbDataAtualizacao
            // 
            this.lbDataAtualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDataAtualizacao.AutoSize = true;
            this.lbDataAtualizacao.Location = new System.Drawing.Point(116, 437);
            this.lbDataAtualizacao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDataAtualizacao.Name = "lbDataAtualizacao";
            this.lbDataAtualizacao.Size = new System.Drawing.Size(13, 18);
            this.lbDataAtualizacao.TabIndex = 3;
            this.lbDataAtualizacao.Text = "-";
            // 
            // ckbAtualizar
            // 
            this.ckbAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbAtualizar.AutoSize = true;
            this.ckbAtualizar.Location = new System.Drawing.Point(10, 412);
            this.ckbAtualizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ckbAtualizar.Name = "ckbAtualizar";
            this.ckbAtualizar.Size = new System.Drawing.Size(83, 22);
            this.ckbAtualizar.TabIndex = 4;
            this.ckbAtualizar.Text = "Atualizar";
            this.ckbAtualizar.UseVisualStyleBackColor = true;
            this.ckbAtualizar.CheckedChanged += new System.EventHandler(this.ckbAtualizar_CheckedChanged);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastro.Location = new System.Drawing.Point(851, 409);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(61, 26);
            this.btnCadastro.TabIndex = 5;
            this.btnCadastro.Text = "Ativos";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnRedimencionar
            // 
            this.btnRedimencionar.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.btnRedimencionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRedimencionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRedimencionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedimencionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRedimencionar.Location = new System.Drawing.Point(2, 437);
            this.btnRedimencionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedimencionar.Name = "btnRedimencionar";
            this.btnRedimencionar.Size = new System.Drawing.Size(20, 22);
            this.btnRedimencionar.TabIndex = 6;
            this.btnRedimencionar.Text = ">";
            this.btnRedimencionar.UseVisualStyleBackColor = false;
            this.btnRedimencionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ativo Mais Rentavel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Possiveis Compras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rentabilidade Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total de Ganhos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total de Perda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ativo Menos Rentavel:";
            // 
            // lblMaisRentavel
            // 
            this.lblMaisRentavel.AutoSize = true;
            this.lblMaisRentavel.Location = new System.Drawing.Point(790, 40);
            this.lblMaisRentavel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaisRentavel.Name = "lblMaisRentavel";
            this.lblMaisRentavel.Size = new System.Drawing.Size(13, 18);
            this.lblMaisRentavel.TabIndex = 17;
            this.lblMaisRentavel.Text = "-";
            // 
            // lblMenoRentavel
            // 
            this.lblMenoRentavel.AutoSize = true;
            this.lblMenoRentavel.Location = new System.Drawing.Point(805, 58);
            this.lblMenoRentavel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenoRentavel.Name = "lblMenoRentavel";
            this.lblMenoRentavel.Size = new System.Drawing.Size(13, 18);
            this.lblMenoRentavel.TabIndex = 18;
            this.lblMenoRentavel.Text = "-";
            // 
            // lblPossiveisCompras
            // 
            this.lblPossiveisCompras.AutoSize = true;
            this.lblPossiveisCompras.Location = new System.Drawing.Point(639, 185);
            this.lblPossiveisCompras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPossiveisCompras.Name = "lblPossiveisCompras";
            this.lblPossiveisCompras.Size = new System.Drawing.Size(13, 18);
            this.lblPossiveisCompras.TabIndex = 19;
            this.lblPossiveisCompras.Text = "-";
            // 
            // lblTotalRentabilidade
            // 
            this.lblTotalRentabilidade.AutoSize = true;
            this.lblTotalRentabilidade.Location = new System.Drawing.Point(786, 149);
            this.lblTotalRentabilidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRentabilidade.Name = "lblTotalRentabilidade";
            this.lblTotalRentabilidade.Size = new System.Drawing.Size(13, 18);
            this.lblTotalRentabilidade.TabIndex = 20;
            this.lblTotalRentabilidade.Text = "-";
            // 
            // lblTotalGanho
            // 
            this.lblTotalGanho.AutoSize = true;
            this.lblTotalGanho.Location = new System.Drawing.Point(768, 131);
            this.lblTotalGanho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalGanho.Name = "lblTotalGanho";
            this.lblTotalGanho.Size = new System.Drawing.Size(13, 18);
            this.lblTotalGanho.TabIndex = 21;
            this.lblTotalGanho.Text = "-";
            // 
            // lblTotalPerda
            // 
            this.lblTotalPerda.AutoSize = true;
            this.lblTotalPerda.Location = new System.Drawing.Point(757, 113);
            this.lblTotalPerda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPerda.Name = "lblTotalPerda";
            this.lblTotalPerda.Size = new System.Drawing.Size(13, 18);
            this.lblTotalPerda.TabIndex = 22;
            this.lblTotalPerda.Text = "-";
            // 
            // lblTotalInvestido
            // 
            this.lblTotalInvestido.AutoSize = true;
            this.lblTotalInvestido.Location = new System.Drawing.Point(750, 76);
            this.lblTotalInvestido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalInvestido.Name = "lblTotalInvestido";
            this.lblTotalInvestido.Size = new System.Drawing.Size(13, 18);
            this.lblTotalInvestido.TabIndex = 24;
            this.lblTotalInvestido.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(639, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total Investido:";
            // 
            // lblTotalRetorno
            // 
            this.lblTotalRetorno.AutoSize = true;
            this.lblTotalRetorno.Location = new System.Drawing.Point(750, 94);
            this.lblTotalRetorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRetorno.Name = "lblTotalRetorno";
            this.lblTotalRetorno.Size = new System.Drawing.Size(13, 18);
            this.lblTotalRetorno.TabIndex = 26;
            this.lblTotalRetorno.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(639, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total Retorno:";
            // 
            // btnGerarResumo
            // 
            this.btnGerarResumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarResumo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGerarResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarResumo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarResumo.Location = new System.Drawing.Point(635, 378);
            this.btnGerarResumo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerarResumo.Name = "btnGerarResumo";
            this.btnGerarResumo.Size = new System.Drawing.Size(126, 26);
            this.btnGerarResumo.TabIndex = 27;
            this.btnGerarResumo.Text = "Gravar Resumo";
            this.btnGerarResumo.UseVisualStyleBackColor = false;
            this.btnGerarResumo.Click += new System.EventHandler(this.btnGerarResumo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(901, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BuscarAcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 464);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGerarResumo);
            this.Controls.Add(this.lblTotalRetorno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalInvestido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalPerda);
            this.Controls.Add(this.lblTotalGanho);
            this.Controls.Add(this.lblTotalRentabilidade);
            this.Controls.Add(this.lblPossiveisCompras);
            this.Controls.Add(this.lblMenoRentavel);
            this.Controls.Add(this.lblMaisRentavel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRedimencionar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.ckbAtualizar);
            this.Controls.Add(this.lbDataAtualizacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbTop);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "BuscarAcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Ações";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.BuscarAcoes_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BuscarAcoes_MouseDoubleClick);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.ckbTop, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbDataAtualizacao, 0);
            this.Controls.SetChildIndex(this.ckbAtualizar, 0);
            this.Controls.SetChildIndex(this.btnCadastro, 0);
            this.Controls.SetChildIndex(this.btnRedimencionar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.lblMaisRentavel, 0);
            this.Controls.SetChildIndex(this.lblMenoRentavel, 0);
            this.Controls.SetChildIndex(this.lblPossiveisCompras, 0);
            this.Controls.SetChildIndex(this.lblTotalRentabilidade, 0);
            this.Controls.SetChildIndex(this.lblTotalGanho, 0);
            this.Controls.SetChildIndex(this.lblTotalPerda, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lblTotalInvestido, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.lblTotalRetorno, 0);
            this.Controls.SetChildIndex(this.btnGerarResumo, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ckbTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDataAtualizacao;
        private System.Windows.Forms.CheckBox ckbAtualizar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnRedimencionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaisRentavel;
        private System.Windows.Forms.Label lblMenoRentavel;
        private System.Windows.Forms.Label lblPossiveisCompras;
        private System.Windows.Forms.Label lblTotalRentabilidade;
        private System.Windows.Forms.Label lblTotalGanho;
        private System.Windows.Forms.Label lblTotalPerda;
        private System.Windows.Forms.Label lblTotalInvestido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalRetorno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGerarResumo;
        private System.Windows.Forms.Button btnClose;
    }
}

