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
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonOnlyTN = new System.Windows.Forms.Button();
            this.buttonTnAndNotTn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonNS_Count = new System.Windows.Forms.Button();
            this.buttonTNDistrib = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
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
            this.buttonScienceDistribution.Location = new System.Drawing.Point(963, 12);
            this.buttonScienceDistribution.Name = "buttonScienceDistribution";
            this.buttonScienceDistribution.Size = new System.Drawing.Size(118, 23);
            this.buttonScienceDistribution.TabIndex = 2;
            this.buttonScienceDistribution.Text = "отрасли науки";
            this.buttonScienceDistribution.UseVisualStyleBackColor = true;
            this.buttonScienceDistribution.Click += new System.EventHandler(this.buttonScienceDistribution_Click);
            // 
            // buttonOneDirection
            // 
            this.buttonOneDirection.Location = new System.Drawing.Point(954, 41);
            this.buttonOneDirection.Name = "buttonOneDirection";
            this.buttonOneDirection.Size = new System.Drawing.Size(158, 23);
            this.buttonOneDirection.TabIndex = 3;
            this.buttonOneDirection.Text = "одна отрасль наук";
            this.buttonOneDirection.UseVisualStyleBackColor = true;
            this.buttonOneDirection.Click += new System.EventHandler(this.buttonOneDirection_Click);
            // 
            // buttonDirectionCount
            // 
            this.buttonDirectionCount.Location = new System.Drawing.Point(954, 158);
            this.buttonDirectionCount.Name = "buttonDirectionCount";
            this.buttonDirectionCount.Size = new System.Drawing.Size(176, 23);
            this.buttonDirectionCount.TabIndex = 4;
            this.buttonDirectionCount.Text = "количество отраслей";
            this.buttonDirectionCount.UseVisualStyleBackColor = true;
            this.buttonDirectionCount.Click += new System.EventHandler(this.buttonDirectionCount_Click);
            // 
            // buttonDirectionPairCount
            // 
            this.buttonDirectionPairCount.Location = new System.Drawing.Point(954, 72);
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
            this.button4.Location = new System.Drawing.Point(954, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 51);
            this.button4.TabIndex = 17;
            this.button4.Text = "распределение по плотности отношений нс/гнс";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonGNS_NJ_ALL
            // 
            this.buttonGNS_NJ_ALL.Location = new System.Drawing.Point(954, 191);
            this.buttonGNS_NJ_ALL.Name = "buttonGNS_NJ_ALL";
            this.buttonGNS_NJ_ALL.Size = new System.Drawing.Size(126, 51);
            this.buttonGNS_NJ_ALL.TabIndex = 18;
            this.buttonGNS_NJ_ALL.Text = "тольго гнс/только нж/1+2";
            this.buttonGNS_NJ_ALL.UseVisualStyleBackColor = true;
            this.buttonGNS_NJ_ALL.Click += new System.EventHandler(this.buttonGNS_NJ_ALL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "2019";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 484);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "нету НС тех наук";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonOnlyTN
            // 
            this.buttonOnlyTN.Location = new System.Drawing.Point(15, 513);
            this.buttonOnlyTN.Name = "buttonOnlyTN";
            this.buttonOnlyTN.Size = new System.Drawing.Size(221, 23);
            this.buttonOnlyTN.TabIndex = 21;
            this.buttonOnlyTN.Text = "только ТН";
            this.buttonOnlyTN.UseVisualStyleBackColor = true;
            this.buttonOnlyTN.Click += new System.EventHandler(this.buttonOnlyTN_Click);
            // 
            // buttonTnAndNotTn
            // 
            this.buttonTnAndNotTn.Location = new System.Drawing.Point(15, 542);
            this.buttonTnAndNotTn.Name = "buttonTnAndNotTn";
            this.buttonTnAndNotTn.Size = new System.Drawing.Size(221, 23);
            this.buttonTnAndNotTn.TabIndex = 22;
            this.buttonTnAndNotTn.Text = "ТН и не ТН";
            this.buttonTnAndNotTn.UseVisualStyleBackColor = true;
            this.buttonTnAndNotTn.Click += new System.EventHandler(this.buttonTnAndNotTn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(300, 484);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 25);
            this.button6.TabIndex = 23;
            this.button6.Text = "ТН без ФИЗ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(300, 513);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "ТН С ФИЗ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(300, 557);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 23);
            this.button8.TabIndex = 25;
            this.button8.Text = "Доля НС";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonNS_Count
            // 
            this.buttonNS_Count.Location = new System.Drawing.Point(512, 484);
            this.buttonNS_Count.Name = "buttonNS_Count";
            this.buttonNS_Count.Size = new System.Drawing.Size(172, 23);
            this.buttonNS_Count.TabIndex = 26;
            this.buttonNS_Count.Text = "Количество НС";
            this.buttonNS_Count.UseVisualStyleBackColor = true;
            this.buttonNS_Count.Click += new System.EventHandler(this.buttonNS_Count_Click);
            // 
            // buttonTNDistrib
            // 
            this.buttonTNDistrib.Location = new System.Drawing.Point(512, 524);
            this.buttonTNDistrib.Name = "buttonTNDistrib";
            this.buttonTNDistrib.Size = new System.Drawing.Size(172, 23);
            this.buttonTNDistrib.TabIndex = 27;
            this.buttonTNDistrib.Text = "распределение в % доли ТН";
            this.buttonTNDistrib.UseVisualStyleBackColor = true;
            this.buttonTNDistrib.Click += new System.EventHandler(this.buttonTNDistrib_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(512, 569);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 39);
            this.button9.TabIndex = 28;
            this.button9.Text = "распределение по каждой тех специальности";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(37, 619);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 29;
            this.button10.Text = "05.02";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(146, 619);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 30;
            this.button11.Text = "05.11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(264, 619);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 31;
            this.button12.Text = "05.13";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(363, 619);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 32;
            this.button13.Text = "05.22";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(465, 619);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 33;
            this.button14.Text = "05.23";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 692);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonTNDistrib);
            this.Controls.Add(this.buttonNS_Count);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonTnAndNotTn);
            this.Controls.Add(this.buttonOnlyTN);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonOnlyTN;
        private System.Windows.Forms.Button buttonTnAndNotTn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonNS_Count;
        private System.Windows.Forms.Button buttonTNDistrib;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

