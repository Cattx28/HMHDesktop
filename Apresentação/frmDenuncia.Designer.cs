﻿namespace Apresentação
{
    partial class frmDenuncia
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDenuncia));
            dgDenuncia = new DataGridView();
            btnExcluir = new Button();
            btnMensagem = new Button();
            btnRespostas = new Button();
            btnBuscar = new Button();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgDenuncia).BeginInit();
            SuspendLayout();
            // 
            // dgDenuncia
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(180, 202, 232);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(19, 62, 112);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(104, 160, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(19, 62, 112);
            dgDenuncia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgDenuncia.BackgroundColor = Color.FromArgb(208, 226, 241);
            dgDenuncia.BorderStyle = BorderStyle.None;
            dgDenuncia.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 68, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 99, 159);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgDenuncia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgDenuncia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 138, 182);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 118, 166);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgDenuncia.DefaultCellStyle = dataGridViewCellStyle3;
            dgDenuncia.EnableHeadersVisualStyles = false;
            dgDenuncia.GridColor = Color.FromArgb(208, 226, 241);
            dgDenuncia.Location = new Point(220, 206);
            dgDenuncia.Name = "dgDenuncia";
            dgDenuncia.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgDenuncia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgDenuncia.RowHeadersVisible = false;
            dgDenuncia.RowHeadersWidth = 51;
            dgDenuncia.Size = new Size(998, 423);
            dgDenuncia.TabIndex = 0;
            dgDenuncia.SelectionChanged += dgDenuncia_SelectionChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(108, 138, 182);
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Segoe UI Semilight", 12F);
            btnExcluir.ForeColor = Color.FromArgb(226, 239, 239);
            btnExcluir.Location = new Point(220, 644);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(264, 55);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "EXCLUIR MENSAGEM";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnMensagem
            // 
            btnMensagem.BackColor = Color.FromArgb(108, 138, 182);
            btnMensagem.FlatStyle = FlatStyle.Popup;
            btnMensagem.Font = new Font("Segoe UI Semilight", 12F);
            btnMensagem.ForeColor = Color.FromArgb(226, 239, 239);
            btnMensagem.Location = new Point(220, 133);
            btnMensagem.Name = "btnMensagem";
            btnMensagem.Size = new Size(184, 55);
            btnMensagem.TabIndex = 8;
            btnMensagem.Text = "MENSAGENS";
            btnMensagem.UseVisualStyleBackColor = false;
            btnMensagem.Click += btnMensagem_Click;
            // 
            // btnRespostas
            // 
            btnRespostas.BackColor = Color.FromArgb(108, 138, 182);
            btnRespostas.FlatStyle = FlatStyle.Popup;
            btnRespostas.Font = new Font("Segoe UI Semilight", 12F);
            btnRespostas.ForeColor = Color.FromArgb(226, 239, 239);
            btnRespostas.Location = new Point(434, 133);
            btnRespostas.Name = "btnRespostas";
            btnRespostas.Size = new Size(184, 55);
            btnRespostas.TabIndex = 9;
            btnRespostas.Text = "RESPOSTAS";
            btnRespostas.UseVisualStyleBackColor = false;
            btnRespostas.Click += btnRespostas_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(108, 138, 182);
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(226, 239, 239);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1123, 133);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 55);
            btnBuscar.TabIndex = 12;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(828, 150);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 13;
            txtId.Visible = false;
            // 
            // frmDenuncia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 226, 241);
            ClientSize = new Size(1240, 725);
            Controls.Add(txtId);
            Controls.Add(btnBuscar);
            Controls.Add(btnRespostas);
            Controls.Add(btnMensagem);
            Controls.Add(btnExcluir);
            Controls.Add(dgDenuncia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDenuncia";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmDenuncias";
            ((System.ComponentModel.ISupportInitialize)dgDenuncia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDenuncia;
        private Button btnExcluir;
        private Button btnMensagem;
        private Button btnRespostas;
        private Button btnBuscar;
        private TextBox txtId;
    }
}