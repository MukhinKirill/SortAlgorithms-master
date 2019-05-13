namespace SortAlgorithms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.SwopLbl = new System.Windows.Forms.Label();
            this.CoctailSortButton = new System.Windows.Forms.Button();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.HeapSortBtn = new System.Windows.Forms.Button();
            this.GnomeSortBtn = new System.Windows.Forms.Button();
            this.TreeSortBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить число";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(246, 24);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(15, 25);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(228, 20);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 61);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заполнить массив случайными числами";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(246, 24);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(15, 25);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(228, 20);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Location = new System.Drawing.Point(339, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 128);
            this.panel3.TabIndex = 4;
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(12, 134);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(75, 23);
            this.BubbleSortButton.TabIndex = 5;
            this.BubbleSortButton.Text = "BubbleSort";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(12, 164);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(46, 13);
            this.TimeLbl.TabIndex = 6;
            this.TimeLbl.Text = "Время: ";
            // 
            // CompareLbl
            // 
            this.CompareLbl.AutoSize = true;
            this.CompareLbl.Location = new System.Drawing.Point(12, 193);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(129, 13);
            this.CompareLbl.TabIndex = 7;
            this.CompareLbl.Text = "Количество сравнений: ";
            // 
            // SwopLbl
            // 
            this.SwopLbl.AutoSize = true;
            this.SwopLbl.Location = new System.Drawing.Point(12, 220);
            this.SwopLbl.Name = "SwopLbl";
            this.SwopLbl.Size = new System.Drawing.Size(119, 13);
            this.SwopLbl.TabIndex = 8;
            this.SwopLbl.Text = "Количество обменов: ";
            // 
            // CoctailSortButton
            // 
            this.CoctailSortButton.Location = new System.Drawing.Point(93, 134);
            this.CoctailSortButton.Name = "CoctailSortButton";
            this.CoctailSortButton.Size = new System.Drawing.Size(75, 23);
            this.CoctailSortButton.TabIndex = 9;
            this.CoctailSortButton.Text = "CoctailSort";
            this.CoctailSortButton.UseVisualStyleBackColor = true;
            this.CoctailSortButton.Click += new System.EventHandler(this.CoctailSortButton_Click);
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Location = new System.Drawing.Point(175, 133);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(75, 23);
            this.InsertSortButton.TabIndex = 10;
            this.InsertSortButton.Text = "InsertSort";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.Location = new System.Drawing.Point(257, 133);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(75, 23);
            this.ShellSortButton.TabIndex = 11;
            this.ShellSortButton.Text = "ShellSort";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // SelectionSortBtn
            // 
            this.SelectionSortBtn.Location = new System.Drawing.Point(339, 133);
            this.SelectionSortBtn.Name = "SelectionSortBtn";
            this.SelectionSortBtn.Size = new System.Drawing.Size(79, 23);
            this.SelectionSortBtn.TabIndex = 12;
            this.SelectionSortBtn.Text = "SelectionSort";
            this.SelectionSortBtn.UseVisualStyleBackColor = true;
            this.SelectionSortBtn.Click += new System.EventHandler(this.SelectionSortBtn_Click);
            // 
            // HeapSortBtn
            // 
            this.HeapSortBtn.Location = new System.Drawing.Point(425, 132);
            this.HeapSortBtn.Name = "HeapSortBtn";
            this.HeapSortBtn.Size = new System.Drawing.Size(75, 23);
            this.HeapSortBtn.TabIndex = 13;
            this.HeapSortBtn.Text = "HeapSort";
            this.HeapSortBtn.UseVisualStyleBackColor = true;
            this.HeapSortBtn.Click += new System.EventHandler(this.HeapSortBtn_Click);
            // 
            // GnomeSortBtn
            // 
            this.GnomeSortBtn.Location = new System.Drawing.Point(507, 134);
            this.GnomeSortBtn.Name = "GnomeSortBtn";
            this.GnomeSortBtn.Size = new System.Drawing.Size(75, 23);
            this.GnomeSortBtn.TabIndex = 14;
            this.GnomeSortBtn.Text = "GnomeSort";
            this.GnomeSortBtn.UseVisualStyleBackColor = true;
            this.GnomeSortBtn.Click += new System.EventHandler(this.GnomeSortBtn_Click);
            // 
            // TreeSortBtn
            // 
            this.TreeSortBtn.Location = new System.Drawing.Point(589, 135);
            this.TreeSortBtn.Name = "TreeSortBtn";
            this.TreeSortBtn.Size = new System.Drawing.Size(75, 23);
            this.TreeSortBtn.TabIndex = 15;
            this.TreeSortBtn.Text = "TreeSort";
            this.TreeSortBtn.UseVisualStyleBackColor = true;
            this.TreeSortBtn.Click += new System.EventHandler(this.TreeSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TreeSortBtn);
            this.Controls.Add(this.GnomeSortBtn);
            this.Controls.Add(this.HeapSortBtn);
            this.Controls.Add(this.SelectionSortBtn);
            this.Controls.Add(this.ShellSortButton);
            this.Controls.Add(this.InsertSortButton);
            this.Controls.Add(this.CoctailSortButton);
            this.Controls.Add(this.SwopLbl);
            this.Controls.Add(this.CompareLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Label SwopLbl;
        private System.Windows.Forms.Button CoctailSortButton;
        private System.Windows.Forms.Button InsertSortButton;
        private System.Windows.Forms.Button ShellSortButton;
        private System.Windows.Forms.Button SelectionSortBtn;
        private System.Windows.Forms.Button HeapSortBtn;
        private System.Windows.Forms.Button GnomeSortBtn;
        private System.Windows.Forms.Button TreeSortBtn;
    }
}

