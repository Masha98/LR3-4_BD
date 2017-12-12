namespace Lab3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.діїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказЗаказанийТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постачальникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказПостачальникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.діїToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // діїToolStripMenuItem
            // 
            this.діїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формиToolStripMenuItem,
            this.запитиToolStripMenuItem,
            this.звітиToolStripMenuItem});
            this.діїToolStripMenuItem.Name = "діїToolStripMenuItem";
            this.діїToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.діїToolStripMenuItem.Text = "Дії";
            // 
            // формиToolStripMenuItem
            // 
            this.формиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарToolStripMenuItem,
            this.постачальникToolStripMenuItem,
            this.заказПостачальникToolStripMenuItem,
            this.заказToolStripMenuItem,
            this.заказЗаказанийТоварToolStripMenuItem});
            this.формиToolStripMenuItem.Name = "формиToolStripMenuItem";
            this.формиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.формиToolStripMenuItem.Text = "Форми";
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.товарToolStripMenuItem.Text = "Товар";
            this.товарToolStripMenuItem.Click += new System.EventHandler(this.GoodsToolStripMenuItem_Click);
            // 
            // заказЗаказанийТоварToolStripMenuItem
            // 
            this.заказЗаказанийТоварToolStripMenuItem.Name = "заказЗаказанийТоварToolStripMenuItem";
            this.заказЗаказанийТоварToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.заказЗаказанийТоварToolStripMenuItem.Text = "Заказ-Товар";
            this.заказЗаказанийТоварToolStripMenuItem.Click += new System.EventHandler(this.orderGoodsToolStripMenuItem_Click);
            // 
            // постачальникToolStripMenuItem
            // 
            this.постачальникToolStripMenuItem.Name = "постачальникToolStripMenuItem";
            this.постачальникToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.постачальникToolStripMenuItem.Text = "Постачальник";
            this.постачальникToolStripMenuItem.Click += new System.EventHandler(this.providerToolStripMenuItem_Click);
            // 
            // заказToolStripMenuItem
            // 
            this.заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            this.заказToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.заказToolStripMenuItem.Text = "Заказ";
            this.заказToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // заказПостачальникToolStripMenuItem
            // 
            this.заказПостачальникToolStripMenuItem.Name = "заказПостачальникToolStripMenuItem";
            this.заказПостачальникToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.заказПостачальникToolStripMenuItem.Text = "Заказ-Постачальник";
            this.заказПостачальникToolStripMenuItem.Click += new System.EventHandler(this.orderProviderToolStripMenuItem_Click);
            // 
            // запитиToolStripMenuItem
            // 
            this.запитиToolStripMenuItem.Name = "запитиToolStripMenuItem";
            this.запитиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.запитиToolStripMenuItem.Text = "Запити";
            // 
            // звітиToolStripMenuItem
            // 
            this.звітиToolStripMenuItem.Name = "звітиToolStripMenuItem";
            this.звітиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.звітиToolStripMenuItem.Text = "Звіти";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem діїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказЗаказанийТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постачальникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказПостачальникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звітиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

