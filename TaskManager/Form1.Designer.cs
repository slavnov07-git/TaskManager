
namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader nameProcess;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.endProcessButton = new System.Windows.Forms.ToolStripButton();
            this.endProcessTreeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.filterToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.usingMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usingDisk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.endProcessStripMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.endProcessTreeStripMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            nameProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameProcess
            // 
            nameProcess.Text = "Название процесса";
            nameProcess.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTaskToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // startTaskToolStripMenuItem
            // 
            this.startTaskToolStripMenuItem.Name = "startTaskToolStripMenuItem";
            this.startTaskToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.startTaskToolStripMenuItem.Text = "Запустить задачу";
            this.startTaskToolStripMenuItem.Click += new System.EventHandler(this.startTaskToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshButton,
            this.endProcessButton,
            this.endProcessTreeButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(65, 22);
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // endProcessButton
            // 
            this.endProcessButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.endProcessButton.Image = ((System.Drawing.Image)(resources.GetObject("endProcessButton.Image")));
            this.endProcessButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.endProcessButton.Name = "endProcessButton";
            this.endProcessButton.Size = new System.Drawing.Size(72, 22);
            this.endProcessButton.Text = "Завершить";
            this.endProcessButton.Click += new System.EventHandler(this.endProcessButton_Click);
            // 
            // endProcessTreeButton
            // 
            this.endProcessTreeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.endProcessTreeButton.Image = ((System.Drawing.Image)(resources.GetObject("endProcessTreeButton.Image")));
            this.endProcessTreeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.endProcessTreeButton.Name = "endProcessTreeButton";
            this.endProcessTreeButton.Size = new System.Drawing.Size(175, 22);
            this.endProcessTreeButton.Text = "Завершить дерево процессов";
            this.endProcessTreeButton.Click += new System.EventHandler(this.endProcessTreeButton_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripLabel1,
            this.toolStripTextBox1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // filterToolStripLabel1
            // 
            this.filterToolStripLabel1.Name = "filterToolStripLabel1";
            this.filterToolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.filterToolStripLabel1.Text = "Фильтр";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            nameProcess,
            this.usingMemory,
            this.usingDisk});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 74);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 376);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // usingMemory
            // 
            this.usingMemory.Text = "Используемая память";
            this.usingMemory.Width = 200;
            // 
            // usingDisk
            // 
            this.usingDisk.Text = "Использование диска";
            this.usingDisk.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endProcessStripMenuButton,
            this.endProcessTreeStripMenuButton});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 48);
            // 
            // endProcessStripMenuButton
            // 
            this.endProcessStripMenuButton.Name = "endProcessStripMenuButton";
            this.endProcessStripMenuButton.Size = new System.Drawing.Size(238, 22);
            this.endProcessStripMenuButton.Text = "Завершить";
            this.endProcessStripMenuButton.Click += new System.EventHandler(this.endProcessStripMenuButton_Click);
            // 
            // endProcessTreeStripMenuButton
            // 
            this.endProcessTreeStripMenuButton.Name = "endProcessTreeStripMenuButton";
            this.endProcessTreeStripMenuButton.Size = new System.Drawing.Size(238, 22);
            this.endProcessTreeStripMenuButton.Text = "Завершить дерево процессов";
            this.endProcessTreeStripMenuButton.Click += new System.EventHandler(this.endProcessTreeStripMenuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton endProcessButton;
        private System.Windows.Forms.ToolStripButton endProcessTreeButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel filterToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader usingMemory;
        private System.Windows.Forms.ColumnHeader usingDisk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem endProcessStripMenuButton;
        private System.Windows.Forms.ToolStripMenuItem endProcessTreeStripMenuButton;
        private System.Windows.Forms.ToolStripMenuItem startTaskToolStripMenuItem;
    }
}

