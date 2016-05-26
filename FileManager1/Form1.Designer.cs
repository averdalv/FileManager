namespace FileManager1
{
    partial class FileManager
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
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукФайлівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.buttonRefresh1 = new System.Windows.Forms.Button();
            this.buttonAddFile1 = new System.Windows.Forms.Button();
            this.buttonAddFolder1 = new System.Windows.Forms.Button();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.buttonAddFolder2 = new System.Windows.Forms.Button();
            this.buttonRefresh2 = new System.Windows.Forms.Button();
            this.buttonAddFile2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Дата створення";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView2);
            this.splitContainer1.Size = new System.Drawing.Size(809, 420);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName1,
            this.columnType1,
            this.columnHeader1});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 420);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnName1
            // 
            this.ColumnName1.Text = "Ім\'я";
            this.ColumnName1.Width = 150;
            // 
            // columnType1
            // 
            this.columnType1.Text = "Тип";
            this.columnType1.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата створення";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMenuItem,
            this.MoveMenuItem,
            this.InsertToolStripMenuItem,
            this.DeleteMenuItem,
            this.SelectTextToolStripMenuItem,
            this.MoveDirectoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 158);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(218, 22);
            this.CopyMenuItem.Text = "Копіювати";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // MoveMenuItem
            // 
            this.MoveMenuItem.Name = "MoveMenuItem";
            this.MoveMenuItem.Size = new System.Drawing.Size(218, 22);
            this.MoveMenuItem.Text = "Перемістити";
            this.MoveMenuItem.Click += new System.EventHandler(this.MoveMenuItem_Click);
            // 
            // InsertToolStripMenuItem
            // 
            this.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem";
            this.InsertToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.InsertToolStripMenuItem.Text = "Вставити";
            this.InsertToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(218, 22);
            this.DeleteMenuItem.Text = "Видалити";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // SelectTextToolStripMenuItem
            // 
            this.SelectTextToolStripMenuItem.Name = "SelectTextToolStripMenuItem";
            this.SelectTextToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.SelectTextToolStripMenuItem.Text = "Виділити перші 3 речення";
            this.SelectTextToolStripMenuItem.Click += new System.EventHandler(this.SelectTextToolStripMenuItem_Click);
            // 
            // MoveDirectoryToolStripMenuItem
            // 
            this.MoveDirectoryToolStripMenuItem.Name = "MoveDirectoryToolStripMenuItem";
            this.MoveDirectoryToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.MoveDirectoryToolStripMenuItem.Text = "Рознесення груп файлів";
            this.MoveDirectoryToolStripMenuItem.Click += new System.EventHandler(this.MoveDirectoryToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "file.png");
            this.imageList1.Images.SetKeyName(2, "Drive.png");
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Control;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName2,
            this.columnType2,
            columnHeader2});
            this.listView2.ContextMenuStrip = this.contextMenuStrip1;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.LargeImageList = this.imageList1;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(401, 420);
            this.listView2.SmallImageList = this.imageList1;
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnName2
            // 
            this.columnName2.Text = "Ім\'я";
            this.columnName2.Width = 150;
            // 
            // columnType2
            // 
            this.columnType2.Text = "Тип";
            this.columnType2.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пошукФайлівToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // пошукФайлівToolStripMenuItem
            // 
            this.пошукФайлівToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem,
            this.xmlToolStripMenuItem,
            this.htmlToolStripMenuItem});
            this.пошукФайлівToolStripMenuItem.Name = "пошукФайлівToolStripMenuItem";
            this.пошукФайлівToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.пошукФайлівToolStripMenuItem.Text = "Пошук файлів з особливостями в іменах";
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.txtToolStripMenuItem.Text = "*.txt";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.xmlToolStripMenuItem.Text = "*.xml";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.xmlToolStripMenuItem_Click);
            // 
            // htmlToolStripMenuItem
            // 
            this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
            this.htmlToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.htmlToolStripMenuItem.Text = "*.html";
            this.htmlToolStripMenuItem.Click += new System.EventHandler(this.htmlToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.aboutProgramToolStripMenuItem.Text = "About program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // buttonBack1
            // 
            this.buttonBack1.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack1.Image")));
            this.buttonBack1.Location = new System.Drawing.Point(12, 46);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(31, 26);
            this.buttonBack1.TabIndex = 2;
            this.buttonBack1.UseVisualStyleBackColor = true;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack1_Click);
            // 
            // buttonRefresh1
            // 
            this.buttonRefresh1.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh1.Image")));
            this.buttonRefresh1.Location = new System.Drawing.Point(49, 46);
            this.buttonRefresh1.Name = "buttonRefresh1";
            this.buttonRefresh1.Size = new System.Drawing.Size(31, 26);
            this.buttonRefresh1.TabIndex = 3;
            this.buttonRefresh1.UseVisualStyleBackColor = true;
            this.buttonRefresh1.Click += new System.EventHandler(this.buttonRefresh1_Click);
            // 
            // buttonAddFile1
            // 
            this.buttonAddFile1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFile1.Image")));
            this.buttonAddFile1.Location = new System.Drawing.Point(137, 31);
            this.buttonAddFile1.Name = "buttonAddFile1";
            this.buttonAddFile1.Size = new System.Drawing.Size(34, 42);
            this.buttonAddFile1.TabIndex = 4;
            this.buttonAddFile1.UseVisualStyleBackColor = true;
            this.buttonAddFile1.Click += new System.EventHandler(this.buttonAddFile1_Click);
            // 
            // buttonAddFolder1
            // 
            this.buttonAddFolder1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFolder1.Image")));
            this.buttonAddFolder1.Location = new System.Drawing.Point(97, 31);
            this.buttonAddFolder1.Name = "buttonAddFolder1";
            this.buttonAddFolder1.Size = new System.Drawing.Size(34, 42);
            this.buttonAddFolder1.TabIndex = 5;
            this.buttonAddFolder1.UseVisualStyleBackColor = true;
            this.buttonAddFolder1.Click += new System.EventHandler(this.buttonAddFolder1_Click);
            // 
            // buttonBack2
            // 
            this.buttonBack2.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack2.Image")));
            this.buttonBack2.Location = new System.Drawing.Point(420, 46);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(31, 26);
            this.buttonBack2.TabIndex = 6;
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // buttonAddFolder2
            // 
            this.buttonAddFolder2.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFolder2.Image")));
            this.buttonAddFolder2.Location = new System.Drawing.Point(508, 30);
            this.buttonAddFolder2.Name = "buttonAddFolder2";
            this.buttonAddFolder2.Size = new System.Drawing.Size(34, 42);
            this.buttonAddFolder2.TabIndex = 7;
            this.buttonAddFolder2.UseVisualStyleBackColor = true;
            this.buttonAddFolder2.Click += new System.EventHandler(this.buttonAddFolder2_Click);
            // 
            // buttonRefresh2
            // 
            this.buttonRefresh2.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh2.Image")));
            this.buttonRefresh2.Location = new System.Drawing.Point(457, 46);
            this.buttonRefresh2.Name = "buttonRefresh2";
            this.buttonRefresh2.Size = new System.Drawing.Size(31, 26);
            this.buttonRefresh2.TabIndex = 8;
            this.buttonRefresh2.UseVisualStyleBackColor = true;
            this.buttonRefresh2.Click += new System.EventHandler(this.buttonRefresh2_Click);
            // 
            // buttonAddFile2
            // 
            this.buttonAddFile2.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFile2.Image")));
            this.buttonAddFile2.Location = new System.Drawing.Point(548, 30);
            this.buttonAddFile2.Name = "buttonAddFile2";
            this.buttonAddFile2.Size = new System.Drawing.Size(34, 42);
            this.buttonAddFile2.TabIndex = 9;
            this.buttonAddFile2.UseVisualStyleBackColor = true;
            this.buttonAddFile2.Click += new System.EventHandler(this.buttonAddFile2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(588, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // FileManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(833, 531);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAddFile2);
            this.Controls.Add(this.buttonRefresh2);
            this.Controls.Add(this.buttonAddFolder2);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.buttonAddFolder1);
            this.Controls.Add(this.buttonAddFile1);
            this.Controls.Add(this.buttonRefresh1);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileManager";
            this.Text = "Файловий Менеджер";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnName1;
        private System.Windows.Forms.ColumnHeader columnType1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnName2;
        private System.Windows.Forms.ColumnHeader columnType2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.Button buttonBack1;
        private System.Windows.Forms.Button buttonRefresh1;
        private System.Windows.Forms.Button buttonAddFile1;
        private System.Windows.Forms.Button buttonAddFolder1;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Button buttonAddFolder2;
        private System.Windows.Forms.Button buttonRefresh2;
        private System.Windows.Forms.Button buttonAddFile2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукФайлівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveDirectoryToolStripMenuItem;
    }
}

