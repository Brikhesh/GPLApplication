namespace GPLApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Cmd_Box = new System.Windows.Forms.TextBox();
            this.txt_Exec_Cmd = new System.Windows.Forms.TextBox();
            this.DisplayPnl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // txt_Cmd_Box
            // 
            this.txt_Cmd_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cmd_Box.Location = new System.Drawing.Point(219, 55);
            this.txt_Cmd_Box.Multiline = true;
            this.txt_Cmd_Box.Name = "txt_Cmd_Box";
            this.txt_Cmd_Box.Size = new System.Drawing.Size(310, 102);
            this.txt_Cmd_Box.TabIndex = 12;
            this.txt_Cmd_Box.TextChanged += new System.EventHandler(this.txt_Cmd_Box_TextChanged);
            // 
            // txt_Exec_Cmd
            // 
            this.txt_Exec_Cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Exec_Cmd.Location = new System.Drawing.Point(114, 546);
            this.txt_Exec_Cmd.Name = "txt_Exec_Cmd";
            this.txt_Exec_Cmd.Size = new System.Drawing.Size(482, 30);
            this.txt_Exec_Cmd.TabIndex = 13;
            this.txt_Exec_Cmd.TextChanged += new System.EventHandler(this.txt_Exec_Cmd_TextChanged);
            // 
            // DisplayPnl
            // 
            this.DisplayPnl.Location = new System.Drawing.Point(12, 175);
            this.DisplayPnl.Name = "DisplayPnl";
            this.DisplayPnl.Size = new System.Drawing.Size(775, 342);
            this.DisplayPnl.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 641);
            this.Controls.Add(this.DisplayPnl);
            this.Controls.Add(this.txt_Exec_Cmd);
            this.Controls.Add(this.txt_Cmd_Box);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Cmd_Box;
        private System.Windows.Forms.TextBox txt_Exec_Cmd;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel DisplayPnl;
    }
}