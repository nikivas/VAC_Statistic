namespace VAC_Statistic
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonScienceDistribution = new System.Windows.Forms.Button();
            this.buttonOneDirection = new System.Windows.Forms.Button();
            this.buttonDirectionCount = new System.Windows.Forms.Button();
            this.buttonDirectionPairCount = new System.Windows.Forms.Button();
            this.buttonPairs = new System.Windows.Forms.Button();
            this.buttonDirectionThird = new System.Windows.Forms.Button();
            this.buttonGNSDistribution = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGNSWithoutDirections = new System.Windows.Forms.Button();
            this.buttonGNSWithDirection = new System.Windows.Forms.Button();
            this.buttonGNSPairsWithDirections = new System.Windows.Forms.Button();
            this.buttonGNSDirectionFour = new System.Windows.Forms.Button();
            this.buttonGNSDirectionFifth = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonGNS_NJ_ALL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 397);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonScienceDistribution
            // 
            this.buttonScienceDistribution.Location = new System.Drawing.Point(285, 12);
            this.buttonScienceDistribution.Name = "buttonScienceDistribution";
            this.buttonScienceDistribution.Size = new System.Drawing.Size(118, 23);
            this.buttonScienceDistribution.TabIndex = 2;
            this.buttonScienceDistribution.Text = "отрасли науки";
            this.buttonScienceDistribution.UseVisualStyleBackColor = true;
            this.buttonScienceDistribution.Click += new System.EventHandler(this.buttonScienceDistribution_Click);
            // 
            // buttonOneDirection
            // 
            this.buttonOneDirection.Location = new System.Drawing.Point(418, 12);
            this.buttonOneDirection.Name = "buttonOneDirection";
            this.buttonOneDirection.Size = new System.Drawing.Size(158, 23);
            this.buttonOneDirection.TabIndex = 3;
            this.buttonOneDirection.Text = "одна отрасль наук";
            this.buttonOneDirection.UseVisualStyleBackColor = true;
            this.buttonOneDirection.Click += new System.EventHandler(this.buttonOneDirection_Click);
            // 
            // buttonDirectionCount
            // 
            this.buttonDirectionCount.Location = new System.Drawing.Point(93, 12);
            this.buttonDirectionCount.Name = "buttonDirectionCount";
            this.buttonDirectionCount.Size = new System.Drawing.Size(176, 23);
            this.buttonDirectionCount.TabIndex = 4;
            this.buttonDirectionCount.Text = "количество отраслей";
            this.buttonDirectionCount.UseVisualStyleBackColor = true;
            this.buttonDirectionCount.Click += new System.EventHandler(this.buttonDirectionCount_Click);
            // 
            // buttonDirectionPairCount
            // 
            this.buttonDirectionPairCount.Location = new System.Drawing.Point(595, 12);
            this.buttonDirectionPairCount.Name = "buttonDirectionPairCount";
            this.buttonDirectionPairCount.Size = new System.Drawing.Size(164, 23);
            this.buttonDirectionPairCount.TabIndex = 5;
            this.buttonDirectionPairCount.Text = "количество пар";
            this.buttonDirectionPairCount.UseVisualStyleBackColor = true;
            this.buttonDirectionPairCount.Click += new System.EventHandler(this.buttonDirectionPairCount_Click);
            // 
            // buttonPairs
            // 
            this.buttonPairs.Location = new System.Drawing.Point(810, 12);
            this.buttonPairs.Name = "buttonPairs";
            this.buttonPairs.Size = new System.Drawing.Size(138, 23);
            this.buttonPairs.TabIndex = 6;
            this.buttonPairs.Text = "пары нж";
            this.buttonPairs.UseVisualStyleBackColor = true;
            this.buttonPairs.Click += new System.EventHandler(this.buttonPairs_Click);
            // 
            // buttonDirectionThird
            // 
            this.buttonDirectionThird.Location = new System.Drawing.Point(810, 41);
            this.buttonDirectionThird.Name = "buttonDirectionThird";
            this.buttonDirectionThird.Size = new System.Drawing.Size(138, 23);
            this.buttonDirectionThird.TabIndex = 7;
            this.buttonDirectionThird.Text = "Тройки нж";
            this.buttonDirectionThird.UseVisualStyleBackColor = true;
            this.buttonDirectionThird.Click += new System.EventHandler(this.buttonDirectionThird_Click);
            // 
            // buttonGNSDistribution
            // 
            this.buttonGNSDistribution.Location = new System.Drawing.Point(810, 72);
            this.buttonGNSDistribution.Name = "buttonGNSDistribution";
            this.buttonGNSDistribution.Size = new System.Drawing.Size(138, 23);
            this.buttonGNSDistribution.TabIndex = 8;
            this.buttonGNSDistribution.Text = "распределение по гнс";
            this.buttonGNSDistribution.UseVisualStyleBackColor = true;
            this.buttonGNSDistribution.Click += new System.EventHandler(this.buttonGNSDistribution_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "распределение по количесву гнс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGNSWithoutDirections
            // 
            this.buttonGNSWithoutDirections.Location = new System.Drawing.Point(810, 145);
            this.buttonGNSWithoutDirections.Name = "buttonGNSWithoutDirections";
            this.buttonGNSWithoutDirections.Size = new System.Drawing.Size(138, 40);
            this.buttonGNSWithoutDirections.TabIndex = 10;
            this.buttonGNSWithoutDirections.Text = "распределение гнс без отраслей";
            this.buttonGNSWithoutDirections.UseVisualStyleBackColor = true;
            this.buttonGNSWithoutDirections.Click += new System.EventHandler(this.buttonGNSWithoutDirections_Click);
            // 
            // buttonGNSWithDirection
            // 
            this.buttonGNSWithDirection.Location = new System.Drawing.Point(810, 191);
            this.buttonGNSWithDirection.Name = "buttonGNSWithDirection";
            this.buttonGNSWithDirection.Size = new System.Drawing.Size(135, 40);
            this.buttonGNSWithDirection.TabIndex = 11;
            this.buttonGNSWithDirection.Text = "тройки гнс с нж";
            this.buttonGNSWithDirection.UseVisualStyleBackColor = true;
            this.buttonGNSWithDirection.Click += new System.EventHandler(this.buttonGNSWithDirection_Click);
            // 
            // buttonGNSPairsWithDirections
            // 
            this.buttonGNSPairsWithDirections.Location = new System.Drawing.Point(807, 237);
            this.buttonGNSPairsWithDirections.Name = "buttonGNSPairsWithDirections";
            this.buttonGNSPairsWithDirections.Size = new System.Drawing.Size(138, 51);
            this.buttonGNSPairsWithDirections.TabIndex = 12;
            this.buttonGNSPairsWithDirections.Text = "пары гнс с нж";
            this.buttonGNSPairsWithDirections.UseVisualStyleBackColor = true;
            this.buttonGNSPairsWithDirections.Click += new System.EventHandler(this.buttonGNSPairsWithDirections_Click);
            // 
            // buttonGNSDirectionFour
            // 
            this.buttonGNSDirectionFour.Location = new System.Drawing.Point(810, 294);
            this.buttonGNSDirectionFour.Name = "buttonGNSDirectionFour";
            this.buttonGNSDirectionFour.Size = new System.Drawing.Size(135, 48);
            this.buttonGNSDirectionFour.TabIndex = 13;
            this.buttonGNSDirectionFour.Text = "гнс на 4";
            this.buttonGNSDirectionFour.UseVisualStyleBackColor = true;
            this.buttonGNSDirectionFour.Click += new System.EventHandler(this.buttonGNSDirectionFour_Click);
            // 
            // buttonGNSDirectionFifth
            // 
            this.buttonGNSDirectionFifth.Location = new System.Drawing.Point(810, 348);
            this.buttonGNSDirectionFifth.Name = "buttonGNSDirectionFifth";
            this.buttonGNSDirectionFifth.Size = new System.Drawing.Size(135, 46);
            this.buttonGNSDirectionFifth.TabIndex = 14;
            this.buttonGNSDirectionFifth.Text = "гнс на 5";
            this.buttonGNSDirectionFifth.UseVisualStyleBackColor = true;
            this.buttonGNSDirectionFifth.Click += new System.EventHandler(this.buttonGNSDirectionFifth_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(810, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "распределение по отношеню нж к гнс";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(810, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 42);
            this.button3.TabIndex = 16;
            this.button3.Text = "Распределение по каоличеству обьектов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(434, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 51);
            this.button4.TabIndex = 17;
            this.button4.Text = "распределение по плотности отношений нс/гнс";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonGNS_NJ_ALL
            // 
            this.buttonGNS_NJ_ALL.Location = new System.Drawing.Point(73, 444);
            this.buttonGNS_NJ_ALL.Name = "buttonGNS_NJ_ALL";
            this.buttonGNS_NJ_ALL.Size = new System.Drawing.Size(126, 51);
            this.buttonGNS_NJ_ALL.TabIndex = 18;
            this.buttonGNS_NJ_ALL.Text = "тольго гнс/только нж/1+2";
            this.buttonGNS_NJ_ALL.UseVisualStyleBackColor = true;
            this.buttonGNS_NJ_ALL.Click += new System.EventHandler(this.buttonGNS_NJ_ALL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 498);
            this.Controls.Add(this.buttonGNS_NJ_ALL);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonGNSDirectionFifth);
            this.Controls.Add(this.buttonGNSDirectionFour);
            this.Controls.Add(this.buttonGNSPairsWithDirections);
            this.Controls.Add(this.buttonGNSWithDirection);
            this.Controls.Add(this.buttonGNSWithoutDirections);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGNSDistribution);
            this.Controls.Add(this.buttonDirectionThird);
            this.Controls.Add(this.buttonPairs);
            this.Controls.Add(this.buttonDirectionPairCount);
            this.Controls.Add(this.buttonDirectionCount);
            this.Controls.Add(this.buttonOneDirection);
            this.Controls.Add(this.buttonScienceDistribution);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonScienceDistribution;
        private System.Windows.Forms.Button buttonOneDirection;
        private System.Windows.Forms.Button buttonDirectionCount;
        private System.Windows.Forms.Button buttonDirectionPairCount;
        private System.Windows.Forms.Button buttonPairs;
        private System.Windows.Forms.Button buttonDirectionThird;
        private System.Windows.Forms.Button buttonGNSDistribution;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGNSWithoutDirections;
        private System.Windows.Forms.Button buttonGNSWithDirection;
        private System.Windows.Forms.Button buttonGNSPairsWithDirections;
        private System.Windows.Forms.Button buttonGNSDirectionFour;
        private System.Windows.Forms.Button buttonGNSDirectionFifth;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonGNS_NJ_ALL;
    }
}

