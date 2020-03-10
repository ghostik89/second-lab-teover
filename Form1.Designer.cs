namespace TeorVer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelAi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelB = new System.Windows.Forms.Label();
            this.PicSys = new System.Windows.Forms.PictureBox();
            this.PicFormule = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RadioExFirst = new System.Windows.Forms.RadioButton();
            this.RadioExSecond = new System.Windows.Forms.RadioButton();
            this.BtnSolution = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicSys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFormule)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAi
            // 
            this.LabelAi.AutoSize = true;
            this.LabelAi.Location = new System.Drawing.Point(12, 13);
            this.LabelAi.Name = "LabelAi";
            this.LabelAi.Size = new System.Drawing.Size(510, 17);
            this.LabelAi.TabIndex = 0;
            this.LabelAi.Text = "Задана схема. Пусть Ai - событие при котором за время T выйдет из строя.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"При известных вероятностях P(Ai) найти вероятность следующих событий:";
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.Location = new System.Drawing.Point(49, 47);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(424, 17);
            this.LabelB.TabIndex = 2;
            this.LabelB.Text = "B - событие при котором схема не выйдет из строя за время T";
            // 
            // PicSys
            // 
            this.PicSys.Image = ((System.Drawing.Image)(resources.GetObject("PicSys.Image")));
            this.PicSys.Location = new System.Drawing.Point(255, 68);
            this.PicSys.Name = "PicSys";
            this.PicSys.Size = new System.Drawing.Size(458, 183);
            this.PicSys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSys.TabIndex = 3;
            this.PicSys.TabStop = false;
            // 
            // PicFormule
            // 
            this.PicFormule.Image = ((System.Drawing.Image)(resources.GetObject("PicFormule.Image")));
            this.PicFormule.Location = new System.Drawing.Point(255, 266);
            this.PicFormule.Name = "PicFormule";
            this.PicFormule.Size = new System.Drawing.Size(458, 101);
            this.PicFormule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicFormule.TabIndex = 4;
            this.PicFormule.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "P(A1) = q1 =";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "P(A2) = q2 =";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "P(A3) = q3 =";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(109, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(109, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(109, 208);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "P(A4) = q4 =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "P(A5) = q5 =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "P(A6) = q6 =";
            // 
            // RadioExFirst
            // 
            this.RadioExFirst.AutoSize = true;
            this.RadioExFirst.Location = new System.Drawing.Point(19, 244);
            this.RadioExFirst.Name = "RadioExFirst";
            this.RadioExFirst.Size = new System.Drawing.Size(150, 21);
            this.RadioExFirst.TabIndex = 17;
            this.RadioExFirst.TabStop = true;
            this.RadioExFirst.Text = "Решать задание 1";
            this.RadioExFirst.UseVisualStyleBackColor = true;
            this.RadioExFirst.CheckedChanged += new System.EventHandler(this.RadioExFirst_CheckedChanged);
            // 
            // RadioExSecond
            // 
            this.RadioExSecond.AutoSize = true;
            this.RadioExSecond.Checked = true;
            this.RadioExSecond.Location = new System.Drawing.Point(19, 271);
            this.RadioExSecond.Name = "RadioExSecond";
            this.RadioExSecond.Size = new System.Drawing.Size(150, 21);
            this.RadioExSecond.TabIndex = 18;
            this.RadioExSecond.TabStop = true;
            this.RadioExSecond.Text = "Решать задание 2";
            this.RadioExSecond.UseVisualStyleBackColor = true;
            this.RadioExSecond.CheckedChanged += new System.EventHandler(this.RadioExSecond_CheckedChanged);
            // 
            // BtnSolution
            // 
            this.BtnSolution.Location = new System.Drawing.Point(18, 326);
            this.BtnSolution.Name = "BtnSolution";
            this.BtnSolution.Size = new System.Drawing.Size(191, 23);
            this.BtnSolution.TabIndex = 19;
            this.BtnSolution.Text = "Вычислить";
            this.BtnSolution.UseVisualStyleBackColor = true;
            this.BtnSolution.Click += new System.EventHandler(this.BtnSolution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 389);
            this.Controls.Add(this.BtnSolution);
            this.Controls.Add(this.RadioExSecond);
            this.Controls.Add(this.RadioExFirst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PicFormule);
            this.Controls.Add(this.PicSys);
            this.Controls.Add(this.LabelB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelAi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Задание 1 и Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.PicSys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFormule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelB;
        private System.Windows.Forms.PictureBox PicSys;
        private System.Windows.Forms.PictureBox PicFormule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton RadioExFirst;
        private System.Windows.Forms.RadioButton RadioExSecond;
        private System.Windows.Forms.Button BtnSolution;
    }
}

