using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Apresentação
{
        partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            pictureBox1 = new PictureBox();
            blueGradientProgressBar1 = new SeuNamespace.BlueGradientProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(703, 413);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // blueGradientProgressBar1
            // 
            blueGradientProgressBar1.Location = new Point(164, 312);
            blueGradientProgressBar1.Name = "blueGradientProgressBar1";
            blueGradientProgressBar1.Size = new Size(376, 12);
            blueGradientProgressBar1.TabIndex = 4;
            // 
            // frmSplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 413);
            Controls.Add(blueGradientProgressBar1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLoading";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private SeuNamespace.BlueGradientProgressBar blueGradientProgressBar1;
    }
    }