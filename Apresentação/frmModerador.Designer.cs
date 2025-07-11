﻿namespace Apresentação
{
    partial class frmModerador
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModerador));
            dgModerador = new DataGridView();
            grpDados = new GroupBox();
            txtSenha = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgModerador).BeginInit();
            grpDados.SuspendLayout();
            SuspendLayout();
            // 
            // dgModerador
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(180, 202, 232);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(19, 62, 112);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(104, 160, 205);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(19, 62, 112);
            dgModerador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgModerador.BackgroundColor = Color.FromArgb(208, 226, 241);
            dgModerador.BorderStyle = BorderStyle.None;
            dgModerador.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(38, 68, 102);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(30, 99, 159);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgModerador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgModerador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(108, 138, 182);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(64, 118, 166);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgModerador.DefaultCellStyle = dataGridViewCellStyle7;
            dgModerador.EnableHeadersVisualStyles = false;
            dgModerador.GridColor = Color.FromArgb(208, 226, 241);
            dgModerador.Location = new Point(213, 249);
            dgModerador.Name = "dgModerador";
            dgModerador.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgModerador.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgModerador.RowHeadersVisible = false;
            dgModerador.RowHeadersWidth = 51;
            dgModerador.Size = new Size(998, 380);
            dgModerador.TabIndex = 0;
            dgModerador.SelectionChanged += dgModerador_SelectionChanged;
            // 
            // grpDados
            // 
            grpDados.BackColor = Color.FromArgb(208, 226, 241);
            grpDados.Controls.Add(txtSenha);
            grpDados.Controls.Add(label5);
            grpDados.Controls.Add(txtEmail);
            grpDados.Controls.Add(label4);
            grpDados.Controls.Add(txtNome);
            grpDados.Controls.Add(label2);
            grpDados.Controls.Add(txtId);
            grpDados.Controls.Add(label1);
            grpDados.FlatStyle = FlatStyle.System;
            grpDados.Location = new Point(212, 94);
            grpDados.Name = "grpDados";
            grpDados.Size = new Size(907, 174);
            grpDados.TabIndex = 1;
            grpDados.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(208, 226, 241);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(38, 68, 102);
            txtSenha.Location = new Point(644, 113);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(252, 30);
            txtSenha.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.FromArgb(38, 68, 102);
            label5.Location = new Point(571, 114);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 27;
            label5.Text = "SENHA:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(208, 226, 241);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(38, 68, 102);
            txtEmail.Location = new Point(71, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(494, 30);
            txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(38, 68, 102);
            label4.Location = new Point(2, 113);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 25;
            label4.Text = "EMAIL:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(208, 226, 241);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(38, 68, 102);
            txtNome.Location = new Point(71, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(825, 30);
            txtNome.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(38, 68, 102);
            label2.Location = new Point(2, 67);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 21;
            label2.Text = "NOME:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(208, 226, 241);
            txtId.BorderStyle = BorderStyle.None;
            txtId.Cursor = Cursors.No;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Semibold", 12.7000008F, FontStyle.Bold);
            txtId.ForeColor = Color.FromArgb(38, 68, 102);
            txtId.Location = new Point(35, 11);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(44, 29);
            txtId.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(38, 68, 102);
            label1.Location = new Point(2, 11);
            label1.Name = "label1";
            label1.Size = new Size(40, 28);
            label1.TabIndex = 19;
            label1.Text = "ID: ";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(108, 138, 182);
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(226, 239, 239);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1140, 196);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(71, 47);
            btnBuscar.TabIndex = 11;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(108, 138, 182);
            btnAdicionar.FlatStyle = FlatStyle.Popup;
            btnAdicionar.Font = new Font("Segoe UI Semilight", 12F);
            btnAdicionar.ForeColor = Color.FromArgb(226, 239, 239);
            btnAdicionar.Location = new Point(220, 644);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(177, 55);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(108, 138, 182);
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Segoe UI Semilight", 12F);
            btnExcluir.ForeColor = Color.FromArgb(226, 239, 239);
            btnExcluir.Location = new Point(417, 644);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(162, 55);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(108, 138, 182);
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI Semilight", 12F);
            btnEditar.ForeColor = Color.FromArgb(226, 239, 239);
            btnEditar.Location = new Point(600, 644);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(181, 55);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(108, 138, 182);
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.FromArgb(226, 239, 239);
            btnSalvar.Location = new Point(802, 644);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(179, 55);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(108, 138, 182);
            btnVoltar.BackgroundImageLayout = ImageLayout.Zoom;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.FromArgb(226, 239, 239);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(1127, 644);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(83, 55);
            btnVoltar.TabIndex = 5;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmModerador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 226, 241);
            ClientSize = new Size(1240, 725);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(grpDados);
            Controls.Add(dgModerador);
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmModerador";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmModerador";
            ((System.ComponentModel.ISupportInitialize)dgModerador).EndInit();
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgModerador;
        private GroupBox grpDados;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnVoltar;
        private Button btnBuscar;
        private TextBox txtSenha;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}