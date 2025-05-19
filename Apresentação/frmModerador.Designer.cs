namespace Apresentação
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            btnAdm = new Button();
            btnMod = new Button();
            btnTornarAdm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgModerador).BeginInit();
            grpDados.SuspendLayout();
            SuspendLayout();
            // 
            // dgModerador
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(180, 202, 232);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(19, 62, 112);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(104, 160, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(19, 62, 112);
            dgModerador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgModerador.BackgroundColor = Color.FromArgb(208, 226, 241);
            dgModerador.BorderStyle = BorderStyle.None;
            dgModerador.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 68, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 99, 159);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgModerador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgModerador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 138, 182);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 118, 166);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgModerador.DefaultCellStyle = dataGridViewCellStyle3;
            dgModerador.EnableHeadersVisualStyles = false;
            dgModerador.GridColor = Color.FromArgb(208, 226, 241);
            dgModerador.Location = new Point(213, 350);
            dgModerador.Name = "dgModerador";
            dgModerador.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgModerador.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgModerador.RowHeadersVisible = false;
            dgModerador.RowHeadersWidth = 51;
            dgModerador.Size = new Size(998, 279);
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
            btnAdicionar.Size = new Size(135, 55);
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
            btnExcluir.Location = new Point(373, 644);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(135, 55);
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
            btnEditar.Location = new Point(526, 644);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(135, 55);
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
            btnSalvar.Location = new Point(679, 644);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 55);
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
            // btnAdm
            // 
            btnAdm.BackColor = Color.FromArgb(108, 138, 182);
            btnAdm.FlatStyle = FlatStyle.Popup;
            btnAdm.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdm.ForeColor = Color.FromArgb(226, 239, 239);
            btnAdm.Location = new Point(212, 274);
            btnAdm.Name = "btnAdm";
            btnAdm.Size = new Size(296, 55);
            btnAdm.TabIndex = 12;
            btnAdm.Text = "ADMINISTRADORES";
            btnAdm.UseVisualStyleBackColor = false;
            btnAdm.Click += btnAdm_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.FromArgb(108, 138, 182);
            btnMod.FlatStyle = FlatStyle.Popup;
            btnMod.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMod.ForeColor = Color.FromArgb(226, 239, 239);
            btnMod.Location = new Point(544, 274);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(296, 55);
            btnMod.TabIndex = 13;
            btnMod.Text = "MODERADORES";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click;
            // 
            // btnTornarAdm
            // 
            btnTornarAdm.BackColor = Color.FromArgb(108, 138, 182);
            btnTornarAdm.FlatStyle = FlatStyle.Popup;
            btnTornarAdm.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTornarAdm.ForeColor = Color.FromArgb(226, 239, 239);
            btnTornarAdm.Location = new Point(832, 644);
            btnTornarAdm.Name = "btnTornarAdm";
            btnTornarAdm.Size = new Size(163, 55);
            btnTornarAdm.TabIndex = 14;
            btnTornarAdm.Text = "TORNAR ADM";
            btnTornarAdm.UseVisualStyleBackColor = false;
            btnTornarAdm.Click += btnTornarAdm_Click;
            // 
            // frmModerador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 226, 241);
            ClientSize = new Size(1240, 725);
            Controls.Add(btnTornarAdm);
            Controls.Add(btnMod);
            Controls.Add(btnAdm);
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
        private Button btnAdm;
        private Button btnMod;
        private Button btnTornarAdm;
    }
}