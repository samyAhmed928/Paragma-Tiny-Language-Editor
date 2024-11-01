namespace Tiny_language_project
{
    partial class Loading_form
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
			this.components = new System.ComponentModel.Container();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.Precentage_lb = new System.Windows.Forms.Label();
			this.Status_lb = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.progressBar1.Location = new System.Drawing.Point(4, 422);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(821, 12);
			this.progressBar1.TabIndex = 1;
			// 
			// Precentage_lb
			// 
			this.Precentage_lb.AutoSize = true;
			this.Precentage_lb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Precentage_lb.ForeColor = System.Drawing.Color.NavajoWhite;
			this.Precentage_lb.Location = new System.Drawing.Point(783, 399);
			this.Precentage_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Precentage_lb.Name = "Precentage_lb";
			this.Precentage_lb.Size = new System.Drawing.Size(35, 23);
			this.Precentage_lb.TabIndex = 2;
			this.Precentage_lb.Text = "0%";
			// 
			// Status_lb
			// 
			this.Status_lb.AutoSize = true;
			this.Status_lb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Status_lb.ForeColor = System.Drawing.Color.Tan;
			this.Status_lb.Location = new System.Drawing.Point(4, 398);
			this.Status_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Status_lb.Name = "Status_lb";
			this.Status_lb.Size = new System.Drawing.Size(172, 21);
			this.Status_lb.TabIndex = 2;
			this.Status_lb.Text = "reload resources....";
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Tiny_language_project.Properties.Resources.Pragma;
			this.pictureBox1.Location = new System.Drawing.Point(4, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(813, 379);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Loading_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(825, 437);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Status_lb);
			this.Controls.Add(this.Precentage_lb);
			this.Controls.Add(this.progressBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Loading_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loading_form";
			this.Load += new System.EventHandler(this.Loading_form_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Precentage_lb;
        private System.Windows.Forms.Label Status_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}