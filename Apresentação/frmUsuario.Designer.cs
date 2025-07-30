namespace Apresentação
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            dgUsuario = new DataGridView();
            grpDados = new GroupBox();
            txtEmail = new TextBox();
            label4 = new Label();
            txtIdade = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnInativar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnVoltar = new Button();
            btnMostraInativos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUsuario).BeginInit();
            grpDados.SuspendLayout();
            SuspendLayout();
            // 
            // dgUsuario
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(180, 202, 232);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(19, 62, 112);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(104, 160, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(19, 62, 112);
            dgUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgUsuario.BackgroundColor = Color.FromArgb(208, 226, 241);
            dgUsuario.BorderStyle = BorderStyle.None;
            dgUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 68, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 99, 159);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 138, 182);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 118, 166);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            dgUsuario.EnableHeadersVisualStyles = false;
            dgUsuario.GridColor = Color.FromArgb(208, 226, 241);
            dgUsuario.Location = new Point(213, 282);
            dgUsuario.Name = "dgUsuario";
            dgUsuario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgUsuario.RowHeadersVisible = false;
            dgUsuario.RowHeadersWidth = 51;
            dgUsuario.Size = new Size(998, 347);
            dgUsuario.TabIndex = 0;
            dgUsuario.SelectionChanged += dgUsuario_SelectionChanged;
            // 
            // grpDados
            // 
            grpDados.BackColor = Color.FromArgb(208, 226, 241);
            grpDados.Controls.Add(txtEmail);
            grpDados.Controls.Add(label4);
            grpDados.Controls.Add(txtIdade);
            grpDados.Controls.Add(label3);
            grpDados.Controls.Add(txtNome);
            grpDados.Controls.Add(label2);
            grpDados.Controls.Add(txtId);
            grpDados.Controls.Add(label1);
            grpDados.FlatStyle = FlatStyle.System;
            grpDados.Location = new Point(212, 94);
            grpDados.Name = "grpDados";
            grpDados.Size = new Size(903, 166);
            grpDados.TabIndex = 1;
            grpDados.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(208, 226, 241);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(38, 68, 102);
            txtEmail.Location = new Point(69, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(825, 30);
            txtEmail.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(38, 68, 102);
            label4.Location = new Point(0, 114);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 14;
            label4.Text = "EMAIL:";
            // 
            // txtIdade
            // 
            txtIdade.BackColor = Color.FromArgb(208, 226, 241);
            txtIdade.BorderStyle = BorderStyle.FixedSingle;
            txtIdade.Cursor = Cursors.IBeam;
            txtIdade.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdade.ForeColor = Color.FromArgb(38, 68, 102);
            txtIdade.Location = new Point(775, 67);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(119, 30);
            txtIdade.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(38, 68, 102);
            label3.Location = new Point(650, 67);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 12;
            label3.Text = "FAIXA ETÁRIA:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(208, 226, 241);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(38, 68, 102);
            txtNome.Location = new Point(69, 67);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(575, 30);
            txtNome.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(38, 68, 102);
            label2.Location = new Point(0, 68);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 10;
            label2.Text = "NOME:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(208, 226, 241);
            txtId.BorderStyle = BorderStyle.None;
            txtId.Cursor = Cursors.No;
            txtId.Font = new Font("Segoe UI Semibold", 12.7000008F, FontStyle.Bold);
            txtId.ForeColor = Color.FromArgb(38, 68, 102);
            txtId.Location = new Point(33, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(44, 29);
            txtId.TabIndex = 9;
            txtId.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(38, 68, 102);
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 28);
            label1.TabIndex = 8;
            label1.Text = "ID: ";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(19, 62, 112);
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(226, 239, 239);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1139, 191);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(71, 47);
            btnBuscar.TabIndex = 7;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnInativar
            // 
            btnInativar.BackColor = Color.Maroon;
            btnInativar.FlatStyle = FlatStyle.Popup;
            btnInativar.Font = new Font("Segoe UI Semilight", 12F);
            btnInativar.ForeColor = Color.FromArgb(226, 239, 239);
            btnInativar.Location = new Point(355, 660);
            btnInativar.Name = "btnInativar";
            btnInativar.Size = new Size(135, 40);
            btnInativar.TabIndex = 2;
            btnInativar.Text = "Inativar";
            btnInativar.UseVisualStyleBackColor = false;
            btnInativar.Click += btnInativar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Maroon;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Segoe UI Semilight", 12F);
            btnExcluir.ForeColor = Color.FromArgb(226, 239, 239);
            btnExcluir.Location = new Point(212, 660);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(135, 40);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(19, 62, 112);
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI Semilight", 12F);
            btnEditar.ForeColor = Color.FromArgb(226, 239, 239);
            btnEditar.Location = new Point(497, 660);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(135, 40);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(108, 138, 182);
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.FromArgb(226, 239, 239);
            btnSalvar.Location = new Point(980, 660);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 40);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(19, 62, 112);
            btnVoltar.BackgroundImageLayout = ImageLayout.Zoom;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.FromArgb(226, 239, 239);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(1127, 660);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(83, 40);
            btnVoltar.TabIndex = 6;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnMostraInativos
            // 
            btnMostraInativos.BackColor = Color.FromArgb(108, 138, 182);
            btnMostraInativos.FlatStyle = FlatStyle.Popup;
            btnMostraInativos.Font = new Font("Segoe UI Semilight", 12F);
            btnMostraInativos.ForeColor = Color.FromArgb(226, 239, 239);
            btnMostraInativos.Location = new Point(706, 660);
            btnMostraInativos.Name = "btnMostraInativos";
            btnMostraInativos.Size = new Size(206, 40);
            btnMostraInativos.TabIndex = 9;
            btnMostraInativos.Text = "Mostrar Inativos";
            btnMostraInativos.UseVisualStyleBackColor = false;
            btnMostraInativos.Click += btnMostraInativos_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 226, 241);
            ClientSize = new Size(1240, 725);
            Controls.Add(btnMostraInativos);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnInativar);
            Controls.Add(grpDados);
            Controls.Add(dgUsuario);
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmUsuario";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgUsuario).EndInit();
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgUsuario;
        private GroupBox grpDados;
        private Button btnInativar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnVoltar;
        private Button btnBuscar;
        private TextBox txtId;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtSenha;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtIdade;
        private Label label3;
        private Button btnMostraInativos;
    }
}