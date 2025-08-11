namespace Apresentação
{
    partial class frmMotivo
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
            label1 = new Label();
            txtMotivo = new TextBox();
            btnEnviar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(226, 239, 239);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = Color.FromArgb(208, 226, 241);
            txtMotivo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotivo.Location = new Point(21, 49);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(367, 79);
            txtMotivo.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(188, 215, 227);
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.FromArgb(19, 62, 112);
            btnEnviar.Location = new Point(415, 74);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 31);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(226, 239, 239);
            btnFechar.BackgroundImageLayout = ImageLayout.Zoom;
            btnFechar.Location = new Point(503, 7);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(24, 22);
            btnFechar.TabIndex = 7;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmMotivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 62, 112);
            ClientSize = new Size(533, 153);
            Controls.Add(btnFechar);
            Controls.Add(btnEnviar);
            Controls.Add(txtMotivo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMotivo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmBusca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMotivo;
        private Button btnEnviar;
        private Button btnFechar;
    }
}