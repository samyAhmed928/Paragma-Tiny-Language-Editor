namespace Tiny_language_project
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Code_editor = new System.Windows.Forms.RichTextBox();
            this.upper_bar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Clear_btn = new System.Windows.Forms.PictureBox();
            this.open_file_btn = new System.Windows.Forms.PictureBox();
            this.Save_btn = new System.Windows.Forms.PictureBox();
            this.Run_btn = new System.Windows.Forms.PictureBox();
            this.title_bar = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Tokens_table = new System.Windows.Forms.DataGridView();
            this.Lexim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tokens_gb = new System.Windows.Forms.GroupBox();
            this.Errors_gb = new System.Windows.Forms.GroupBox();
            this.errors_tx = new System.Windows.Forms.RichTextBox();
            this.line_num_tx = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upper_bar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clear_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_file_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Run_btn)).BeginInit();
            this.title_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tokens_table)).BeginInit();
            this.Tokens_gb.SuspendLayout();
            this.Errors_gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Code_editor
            // 
            this.Code_editor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Code_editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(65)))));
            this.Code_editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code_editor.EnableAutoDragDrop = true;
            this.Code_editor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_editor.ForeColor = System.Drawing.Color.Violet;
            this.Code_editor.Location = new System.Drawing.Point(63, 13);
            this.Code_editor.Name = "Code_editor";
            this.Code_editor.Size = new System.Drawing.Size(463, 483);
            this.Code_editor.TabIndex = 2;
            this.Code_editor.Text = "";
            this.Code_editor.TextChanged += new System.EventHandler(this.Code_editor_TextChanged_1);
            // 
            // upper_bar
            // 
            this.upper_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(65)))));
            this.upper_bar.Controls.Add(this.panel2);
            this.upper_bar.Controls.Add(this.title_bar);
            this.upper_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_bar.Location = new System.Drawing.Point(0, 0);
            this.upper_bar.Name = "upper_bar";
            this.upper_bar.Size = new System.Drawing.Size(1222, 67);
            this.upper_bar.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Clear_btn);
            this.panel2.Controls.Add(this.open_file_btn);
            this.panel2.Controls.Add(this.Save_btn);
            this.panel2.Controls.Add(this.Run_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 29);
            this.panel2.TabIndex = 4;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Image = global::Tiny_language_project.Properties.Resources.icons8_broom_50;
            this.Clear_btn.Location = new System.Drawing.Point(531, 5);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(32, 27);
            this.Clear_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Clear_btn.TabIndex = 5;
            this.Clear_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.Clear_btn, "Clear");
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // open_file_btn
            // 
            this.open_file_btn.Image = global::Tiny_language_project.Properties.Resources.folder;
            this.open_file_btn.Location = new System.Drawing.Point(667, 2);
            this.open_file_btn.Name = "open_file_btn";
            this.open_file_btn.Size = new System.Drawing.Size(32, 27);
            this.open_file_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.open_file_btn.TabIndex = 5;
            this.open_file_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.open_file_btn, "Open file");
            this.open_file_btn.Click += new System.EventHandler(this.open_file_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Image = global::Tiny_language_project.Properties.Resources.disk;
            this.Save_btn.Location = new System.Drawing.Point(598, 5);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(27, 24);
            this.Save_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Save_btn.TabIndex = 5;
            this.Save_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.Save_btn, "Save file");
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Run_btn
            // 
            this.Run_btn.Image = global::Tiny_language_project.Properties.Resources.icons8_play_50;
            this.Run_btn.Location = new System.Drawing.Point(463, 5);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(32, 27);
            this.Run_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Run_btn.TabIndex = 5;
            this.Run_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.Run_btn, "Run");
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // title_bar
            // 
            this.title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(65)))));
            this.title_bar.Controls.Add(this.minimize_btn);
            this.title_bar.Controls.Add(this.Close_btn);
            this.title_bar.Controls.Add(this.Title);
            this.title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar.Location = new System.Drawing.Point(0, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(1222, 40);
            this.title_bar.TabIndex = 5;
            this.title_bar.Paint += new System.Windows.Forms.PaintEventHandler(this.title_bar_Paint);
            this.title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            this.title_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Image = global::Tiny_language_project.Properties.Resources.icons8_subtract_30;
            this.minimize_btn.Location = new System.Drawing.Point(1138, 5);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(32, 27);
            this.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_btn.TabIndex = 5;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Image = global::Tiny_language_project.Properties.Resources.close_480px;
            this.Close_btn.Location = new System.Drawing.Point(1181, 6);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(32, 27);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_btn.TabIndex = 5;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Thwar_Fared", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Bisque;
            this.Title.Location = new System.Drawing.Point(5, 2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(96, 34);
            this.Title.TabIndex = 4;
            this.Title.Text = "Paragma";
            // 
            // Tokens_table
            // 
            this.Tokens_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(65)))));
            this.Tokens_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tokens_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Tokens_table.ColumnHeadersHeight = 40;
            this.Tokens_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexim,
            this.Token});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tokens_table.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tokens_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tokens_table.EnableHeadersVisualStyles = false;
            this.Tokens_table.GridColor = System.Drawing.Color.White;
            this.Tokens_table.Location = new System.Drawing.Point(3, 29);
            this.Tokens_table.Name = "Tokens_table";
            this.Tokens_table.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tokens_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Tokens_table.RowHeadersWidth = 30;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.Tokens_table.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Tokens_table.Size = new System.Drawing.Size(297, 194);
            this.Tokens_table.TabIndex = 0;
            // 
            // Lexim
            // 
            this.Lexim.HeaderText = "Lexim";
            this.Lexim.Name = "Lexim";
            this.Lexim.ReadOnly = true;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            // 
            // Tokens_gb
            // 
            this.Tokens_gb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tokens_gb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.Tokens_gb.Controls.Add(this.Tokens_table);
            this.Tokens_gb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tokens_gb.ForeColor = System.Drawing.Color.White;
            this.Tokens_gb.Location = new System.Drawing.Point(542, 13);
            this.Tokens_gb.Name = "Tokens_gb";
            this.Tokens_gb.Size = new System.Drawing.Size(303, 226);
            this.Tokens_gb.TabIndex = 1;
            this.Tokens_gb.TabStop = false;
            this.Tokens_gb.Text = "Tokens";
            // 
            // Errors_gb
            // 
            this.Errors_gb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Errors_gb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.Errors_gb.Controls.Add(this.errors_tx);
            this.Errors_gb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Errors_gb.ForeColor = System.Drawing.Color.White;
            this.Errors_gb.Location = new System.Drawing.Point(539, 267);
            this.Errors_gb.Name = "Errors_gb";
            this.Errors_gb.Size = new System.Drawing.Size(306, 229);
            this.Errors_gb.TabIndex = 2;
            this.Errors_gb.TabStop = false;
            this.Errors_gb.Text = "Erorrs";
            // 
            // errors_tx
            // 
            this.errors_tx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(65)))));
            this.errors_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errors_tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errors_tx.ForeColor = System.Drawing.Color.Gray;
            this.errors_tx.Location = new System.Drawing.Point(3, 29);
            this.errors_tx.Name = "errors_tx";
            this.errors_tx.ReadOnly = true;
            this.errors_tx.Size = new System.Drawing.Size(300, 197);
            this.errors_tx.TabIndex = 0;
            this.errors_tx.Text = "Empty";
            // 
            // line_num_tx
            // 
            this.line_num_tx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line_num_tx.BackColor = System.Drawing.Color.MidnightBlue;
            this.line_num_tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.line_num_tx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.line_num_tx.ForeColor = System.Drawing.Color.Cyan;
            this.line_num_tx.Location = new System.Drawing.Point(12, 13);
            this.line_num_tx.Name = "line_num_tx";
            this.line_num_tx.ReadOnly = true;
            this.line_num_tx.Size = new System.Drawing.Size(42, 483);
            this.line_num_tx.TabIndex = 4;
            this.line_num_tx.Text = "";
            this.line_num_tx.TextChanged += new System.EventHandler(this.line_num_tx_TextChanged);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(869, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 483);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parse Tree";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(65)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.LineColor = System.Drawing.Color.Aqua;
            this.treeView1.Location = new System.Drawing.Point(3, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(335, 451);
            this.treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.line_num_tx);
            this.panel1.Controls.Add(this.Errors_gb);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Code_editor);
            this.panel1.Controls.Add(this.Tokens_gb);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 529);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1222, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.upper_bar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.upper_bar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Clear_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_file_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Run_btn)).EndInit();
            this.title_bar.ResumeLayout(false);
            this.title_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tokens_table)).EndInit();
            this.Tokens_gb.ResumeLayout(false);
            this.Errors_gb.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Code_editor;
        private System.Windows.Forms.Panel upper_bar;
        private System.Windows.Forms.DataGridView Tokens_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.GroupBox Tokens_gb;
        private System.Windows.Forms.GroupBox Errors_gb;
        private System.Windows.Forms.RichTextBox errors_tx;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.PictureBox Run_btn;
        private System.Windows.Forms.PictureBox Clear_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox line_num_tx;
        private System.Windows.Forms.PictureBox Save_btn;
        private System.Windows.Forms.PictureBox open_file_btn;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
    }
}

