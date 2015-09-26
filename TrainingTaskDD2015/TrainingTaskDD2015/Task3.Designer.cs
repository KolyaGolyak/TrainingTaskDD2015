namespace TrainingTaskDD2015
{
    partial class Task3
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
            this.someShitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createRectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.someShitToolStripMenuItem,
            this.createRectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(325, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // someShitToolStripMenuItem
            // 
            this.someShitToolStripMenuItem.Name = "someShitToolStripMenuItem";
            this.someShitToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.someShitToolStripMenuItem.Text = "Button?";
            this.someShitToolStripMenuItem.Click += new System.EventHandler(this.someShitToolStripMenuItem_Click);
            // 
            // createRectToolStripMenuItem
            // 
            this.createRectToolStripMenuItem.Name = "createRectToolStripMenuItem";
            this.createRectToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.createRectToolStripMenuItem.Text = "CreateRect";
            this.createRectToolStripMenuItem.Click += new System.EventHandler(this.createRectToolStripMenuItem_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 288);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Task3";
            this.Text = "Task3";
            this.Click += new System.EventHandler(this.Task3_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Task3_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem someShitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRectToolStripMenuItem;
    }
}