namespace CoVid2023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            видеоToolStripMenuItem = new ToolStripMenuItem();
            пускToolStripMenuItem = new ToolStripMenuItem();
            воспроизвестиToolStripMenuItem = new ToolStripMenuItem();
            кадрToolStripMenuItem = new ToolStripMenuItem();
            инверсияToolStripMenuItem = new ToolStripMenuItem();
            матрицаToolStripMenuItem = new ToolStripMenuItem();
            паузаToolStripMenuItem = new ToolStripMenuItem();
            пускToolStripMenuItem1 = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Consolas", 1F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(788, 411);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, видеоToolStripMenuItem, кадрToolStripMenuItem, паузаToolStripMenuItem, пускToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(939, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(95, 20);
            файлToolStripMenuItem.Text = "Изображение";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // видеоToolStripMenuItem
            // 
            видеоToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пускToolStripMenuItem, воспроизвестиToolStripMenuItem });
            видеоToolStripMenuItem.Name = "видеоToolStripMenuItem";
            видеоToolStripMenuItem.Size = new Size(52, 20);
            видеоToolStripMenuItem.Text = "Видео";
            // 
            // пускToolStripMenuItem
            // 
            пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            пускToolStripMenuItem.Size = new Size(180, 22);
            пускToolStripMenuItem.Text = "Спарсить";
            пускToolStripMenuItem.Click += пускToolStripMenuItem_Click;
            // 
            // воспроизвестиToolStripMenuItem
            // 
            воспроизвестиToolStripMenuItem.Name = "воспроизвестиToolStripMenuItem";
            воспроизвестиToolStripMenuItem.Size = new Size(180, 22);
            воспроизвестиToolStripMenuItem.Text = "Воспроизвести";
            воспроизвестиToolStripMenuItem.Click += воспроизвестиToolStripMenuItem_Click;
            // 
            // кадрToolStripMenuItem
            // 
            кадрToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { инверсияToolStripMenuItem, матрицаToolStripMenuItem });
            кадрToolStripMenuItem.Name = "кадрToolStripMenuItem";
            кадрToolStripMenuItem.Size = new Size(78, 20);
            кадрToolStripMenuItem.Text = "Фильтры...";
            // 
            // инверсияToolStripMenuItem
            // 
            инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            инверсияToolStripMenuItem.Size = new Size(128, 22);
            инверсияToolStripMenuItem.Text = "Инверсия";
            инверсияToolStripMenuItem.Click += инверсияToolStripMenuItem_Click;
            // 
            // матрицаToolStripMenuItem
            // 
            матрицаToolStripMenuItem.Name = "матрицаToolStripMenuItem";
            матрицаToolStripMenuItem.Size = new Size(128, 22);
            матрицаToolStripMenuItem.Text = "Матрица";
            матрицаToolStripMenuItem.Click += матрицаToolStripMenuItem_Click;
            // 
            // паузаToolStripMenuItem
            // 
            паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            паузаToolStripMenuItem.Size = new Size(51, 20);
            паузаToolStripMenuItem.Text = "Пауза";
            паузаToolStripMenuItem.Click += паузаToolStripMenuItem_Click;
            // 
            // пускToolStripMenuItem1
            // 
            пускToolStripMenuItem1.Name = "пускToolStripMenuItem1";
            пускToolStripMenuItem1.Size = new Size(46, 20);
            пускToolStripMenuItem1.Text = "Пуск";
            пускToolStripMenuItem1.Click += пускToolStripMenuItem1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Consolas";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Courier", "Andale Mono", "Monaco", "Profont", "Monofur", "Proggy", "Droid Sans Mono", "Deja Vu Sans Mono", "Consolas", "Inconsolata" });
            comboBox1.Location = new Point(806, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(845, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Шрифт";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(818, 391);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "16";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(855, 363);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 5;
            label2.Text = "FPS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem видеоToolStripMenuItem;
        private ToolStripMenuItem пускToolStripMenuItem;
        private ToolStripMenuItem воспроизвестиToolStripMenuItem;
        private ToolStripMenuItem кадрToolStripMenuItem;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private ToolStripMenuItem матрицаToolStripMenuItem;
        private ComboBox comboBox1;
        private Label label1;
        private ToolStripMenuItem паузаToolStripMenuItem;
        private ToolStripMenuItem пускToolStripMenuItem1;
        private TextBox textBox1;
        private Label label2;
    }
}