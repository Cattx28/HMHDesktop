namespace Apresentação
{
    partial class frmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            panel1 = new Panel();
            btnModerador = new Button();
            btnDenuncias = new Button();
            btnPsicologos = new Button();
            btnUsuarios = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnFechar = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 62, 112);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnModerador);
            panel1.Controls.Add(btnDenuncias);
            panel1.Controls.Add(btnPsicologos);
            panel1.Controls.Add(btnUsuarios);
            panel1.Location = new Point(-8, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 757);
            panel1.TabIndex = 0;
            // 
            // btnModerador
            // 
            btnModerador.BackColor = Color.FromArgb(19, 62, 112);
            btnModerador.BackgroundImageLayout = ImageLayout.Zoom;
            btnModerador.FlatStyle = FlatStyle.Popup;
            btnModerador.Font = new Font("Segoe UI Semilight", 11F);
            btnModerador.ForeColor = Color.FromArgb(226, 239, 239);
            btnModerador.Image = (Image)resources.GetObject("btnModerador.Image");
            btnModerador.ImageAlign = ContentAlignment.MiddleLeft;
            btnModerador.Location = new Point(8, 95);
            btnModerador.Name = "btnModerador";
            btnModerador.Size = new Size(233, 45);
            btnModerador.TabIndex = 1;
            btnModerador.Text = "Moderadores";
            btnModerador.UseVisualStyleBackColor = false;
            btnModerador.Click += btnModerador_Click;
            // 
            // btnDenuncias
            // 
            btnDenuncias.BackColor = Color.FromArgb(19, 62, 112);
            btnDenuncias.FlatStyle = FlatStyle.Popup;
            btnDenuncias.Font = new Font("Segoe UI Semilight", 11F);
            btnDenuncias.ForeColor = Color.FromArgb(226, 239, 239);
            btnDenuncias.Image = (Image)resources.GetObject("btnDenuncias.Image");
            btnDenuncias.ImageAlign = ContentAlignment.MiddleLeft;
            btnDenuncias.Location = new Point(8, 227);
            btnDenuncias.Name = "btnDenuncias";
            btnDenuncias.Size = new Size(233, 45);
            btnDenuncias.TabIndex = 4;
            btnDenuncias.Text = "Denúncias";
            btnDenuncias.UseVisualStyleBackColor = false;
            btnDenuncias.Click += btnDenuncias_Click;
            // 
            // btnPsicologos
            // 
            btnPsicologos.BackColor = Color.FromArgb(19, 62, 112);
            btnPsicologos.BackgroundImageLayout = ImageLayout.Zoom;
            btnPsicologos.FlatStyle = FlatStyle.Popup;
            btnPsicologos.Font = new Font("Segoe UI Semilight", 11F);
            btnPsicologos.ForeColor = Color.FromArgb(226, 239, 239);
            btnPsicologos.Image = (Image)resources.GetObject("btnPsicologos.Image");
            btnPsicologos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPsicologos.Location = new Point(9, 183);
            btnPsicologos.Name = "btnPsicologos";
            btnPsicologos.Size = new Size(233, 45);
            btnPsicologos.TabIndex = 3;
            btnPsicologos.Text = "Psicólogos";
            btnPsicologos.UseVisualStyleBackColor = false;
            btnPsicologos.Click += btnPsicologos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(19, 62, 112);
            btnUsuarios.BackgroundImageLayout = ImageLayout.Zoom;
            btnUsuarios.FlatStyle = FlatStyle.Popup;
            btnUsuarios.Font = new Font("Segoe UI Semilight", 11F);
            btnUsuarios.ForeColor = Color.FromArgb(226, 239, 239);
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(8, 139);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(233, 45);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(19, 62, 112);
            label1.Location = new Point(248, 25);
            label1.Name = "label1";
            label1.Size = new Size(319, 41);
            label1.TabIndex = 1;
            label1.Text = "MODO MODERADOR";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(180, 202, 232);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1495, 86);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._64_Sem_Título_20240908014550;
            pictureBox1.Location = new Point(0, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(180, 202, 232);
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Center;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(1374, 25);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 38);
            btnFechar.TabIndex = 6;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 62, 112);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semilight", 11F);
            button1.ForeColor = Color.FromArgb(226, 239, 239);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(8, 271);
            button1.Name = "button1";
            button1.Size = new Size(233, 45);
            button1.TabIndex = 5;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 227, 241);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1448, 730);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(192, 255, 255);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmInicial";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnUsuarios;
        private Button btnPsicologos;
        private Button btnDenuncias;
        private Label label1;
        private Panel panel2;
        private Button btnFechar;
        private Button btnModerador;
        private PictureBox pictureBox1;
        private Button button1;
    }
}