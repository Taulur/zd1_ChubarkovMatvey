namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            продатьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            label4 = new Label();
            textBox5 = new TextBox();
            button8 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            numericUpDown3 = new NumericUpDown();
            button4 = new Button();
            button3 = new Button();
            label5 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(342, 328);
            button1.Name = "button1";
            button1.Size = new Size(200, 51);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateProduct;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 13F);
            numericUpDown2.Location = new Point(304, 285);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(295, 36);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 13F);
            numericUpDown1.Location = new Point(304, 244);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(295, 36);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            textBox1.Location = new Point(304, 201);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Название";
            textBox1.Size = new Size(295, 36);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(783, 392);
            label1.Name = "label1";
            label1.Size = new Size(236, 35);
            label1.TabIndex = 1;
            label1.Text = "Общая прибыль : 0";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductName, Price, Count });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(644, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(514, 188);
            dataGridView1.TabIndex = 0;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Название";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // Count
            // 
            Count.HeaderText = "Количество";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.ReadOnly = true;
            Count.Width = 125;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { продатьToolStripMenuItem, удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(138, 52);
            // 
            // продатьToolStripMenuItem
            // 
            продатьToolStripMenuItem.Name = "продатьToolStripMenuItem";
            продатьToolStripMenuItem.Size = new Size(137, 24);
            продатьToolStripMenuItem.Text = "Продать";
            продатьToolStripMenuItem.Click += SellProducts;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(137, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += DeleteProduct;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1458, 638);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(button1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1450, 605);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Магазин";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(145, 286);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 5;
            label3.Text = "Количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(223, 245);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 4;
            label2.Text = "Цена";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(numericUpDown3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1450, 605);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Плейлист";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1165, 515);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 15;
            label4.Text = "Номер трека";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBox5.Location = new Point(1191, 96);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Путь";
            textBox5.Size = new Size(253, 39);
            textBox5.TabIndex = 14;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button8.Location = new Point(1229, 141);
            button8.Name = "button8";
            button8.Size = new Size(175, 50);
            button8.TabIndex = 13;
            button8.Text = "Удалить";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DeleteSongObject;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBox6.Location = new Point(1191, 51);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Название";
            textBox6.Size = new Size(253, 39);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBox7.Location = new Point(1191, 6);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Автор";
            textBox7.Size = new Size(253, 39);
            textBox7.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBox4.Location = new Point(6, 96);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Путь";
            textBox4.Size = new Size(253, 39);
            textBox4.TabIndex = 10;
            // 
            // button7
            // 
            button7.ForeColor = Color.Red;
            button7.Location = new Point(6, 549);
            button7.Name = "button7";
            button7.Size = new Size(125, 50);
            button7.TabIndex = 9;
            button7.Text = "УДАЛИТЬ ВСЁ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ClearSongs;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.Location = new Point(644, 370);
            button6.Name = "button6";
            button6.Size = new Size(150, 50);
            button6.TabIndex = 8;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += DeleteSong;
            // 
            // button5
            // 
            button5.Location = new Point(1293, 547);
            button5.Name = "button5";
            button5.Size = new Size(125, 50);
            button5.TabIndex = 7;
            button5.Text = "Выбрать трек";
            button5.UseVisualStyleBackColor = true;
            button5.Click += SelectSong;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            numericUpDown3.Location = new Point(1273, 506);
            numericUpDown3.Margin = new Padding(3, 4, 3, 4);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(171, 34);
            numericUpDown3.TabIndex = 6;
            numericUpDown3.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.Location = new Point(905, 274);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 5;
            button4.Text = "->";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NextSong;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.Location = new Point(475, 274);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 4;
            button3.Text = "<-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PreviousSong;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(658, 274);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 3;
            label5.Text = "Текущий трек";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(44, 141);
            button2.Name = "button2";
            button2.Size = new Size(175, 50);
            button2.TabIndex = 2;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddSong;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBox3.Location = new Point(6, 51);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Название";
            textBox3.Size = new Size(253, 39);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBox2.Location = new Point(6, 6);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Автор";
            textBox2.Size = new Size(253, 39);
            textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 703);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Count;
        private Button button1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem продатьToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button7;
        private Button button6;
        private Button button5;
        private NumericUpDown numericUpDown3;
        private Button button4;
        private Button button3;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button8;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label4;
    }
}
