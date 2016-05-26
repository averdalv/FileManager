namespace FileManager1
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роботаЗТекстомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиРегістрВиділеногоТекстуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(26, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(620, 331);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.роботаЗТекстомToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.ClearToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.SaveToolStripMenuItem.Text = "Зберегти";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ClearToolStripMenuItem.Text = "Очистити";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // роботаЗТекстомToolStripMenuItem
            // 
            this.роботаЗТекстомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.змінитиРегістрВиділеногоТекстуToolStripMenuItem});
            this.роботаЗТекстомToolStripMenuItem.Name = "роботаЗТекстомToolStripMenuItem";
            this.роботаЗТекстомToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.роботаЗТекстомToolStripMenuItem.Text = "Робота з текстом";
            // 
            // змінитиРегістрВиділеногоТекстуToolStripMenuItem
            // 
            this.змінитиРегістрВиділеногоТекстуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToUpToolStripMenuItem,
            this.ToDownToolStripMenuItem});
            this.змінитиРегістрВиділеногоТекстуToolStripMenuItem.Name = "змінитиРегістрВиділеногоТекстуToolStripMenuItem";
            this.змінитиРегістрВиділеногоТекстуToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.змінитиРегістрВиділеногоТекстуToolStripMenuItem.Text = "Змінити регістр виділеного тексту ";
            // 
            // ToUpToolStripMenuItem
            // 
            this.ToUpToolStripMenuItem.Name = "ToUpToolStripMenuItem";
            this.ToUpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ToUpToolStripMenuItem.Text = "На верхній";
            this.ToUpToolStripMenuItem.Click += new System.EventHandler(this.ToUpToolStripMenuItem_Click);
            // 
            // ToDownToolStripMenuItem
            // 
            this.ToDownToolStripMenuItem.Name = "ToDownToolStripMenuItem";
            this.ToDownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ToDownToolStripMenuItem.Text = "На нижній";
            this.ToDownToolStripMenuItem.Click += new System.EventHandler(this.ToDownToolStripMenuItem_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 410);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роботаЗТекстомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиРегістрВиділеногоТекстуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToDownToolStripMenuItem;
    }
}