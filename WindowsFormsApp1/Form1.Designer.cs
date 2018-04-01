namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.score_label = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.problem_to_solve = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.ready = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.score_label);
            this.tabPage1.Controls.Add(this.confirm);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.check);
            this.tabPage1.Controls.Add(this.next);
            this.tabPage1.Controls.Add(this.answer);
            this.tabPage1.Controls.Add(this.problem_to_solve);
            this.tabPage1.Controls.Add(this.start);
            this.tabPage1.Controls.Add(this.ready);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "multiplication table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_label.Location = new System.Drawing.Point(391, 178);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(80, 25);
            this.score_label.TabIndex = 18;
            this.score_label.Text = "баллы";
            this.score_label.Visible = false;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm.Location = new System.Drawing.Point(489, 131);
            this.confirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(124, 26);
            this.confirm.TabIndex = 17;
            this.confirm.Text = "результат";
            this.confirm.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(377, 216);
            this.check.Margin = new System.Windows.Forms.Padding(2);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(82, 49);
            this.check.TabIndex = 15;
            this.check.Text = "отправить ответ";
            this.check.UseVisualStyleBackColor = true;
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(485, 216);
            this.next.Margin = new System.Windows.Forms.Padding(2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(82, 49);
            this.next.TabIndex = 14;
            this.next.Text = "следующий пример";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(427, 135);
            this.answer.Margin = new System.Windows.Forms.Padding(2);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(44, 28);
            this.answer.TabIndex = 13;
            this.answer.Visible = false;
            // 
            // problem_to_solve
            // 
            this.problem_to_solve.AutoSize = true;
            this.problem_to_solve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.problem_to_solve.Location = new System.Drawing.Point(313, 129);
            this.problem_to_solve.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.problem_to_solve.Name = "problem_to_solve";
            this.problem_to_solve.Padding = new System.Windows.Forms.Padding(4);
            this.problem_to_solve.Size = new System.Drawing.Size(111, 34);
            this.problem_to_solve.TabIndex = 12;
            this.problem_to_solve.Text = "задание";
            this.problem_to_solve.Visible = false;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(185, 163);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(123, 49);
            this.start.TabIndex = 11;
            this.start.Text = "начать тест";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // ready
            // 
            this.ready.Location = new System.Drawing.Point(185, 88);
            this.ready.Name = "ready";
            this.ready.Size = new System.Drawing.Size(123, 46);
            this.ready.TabIndex = 10;
            this.ready.Text = "повторить таблицу умножения";
            this.ready.UseVisualStyleBackColor = true;
            this.ready.Click += new System.EventHandler(this.ready_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb9);
            this.groupBox1.Controls.Add(this.rb8);
            this.groupBox1.Controls.Add(this.rb7);
            this.groupBox1.Controls.Add(this.rb6);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 261);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите число";
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Location = new System.Drawing.Point(23, 206);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(39, 17);
            this.rb9.TabIndex = 8;
            this.rb9.TabStop = true;
            this.rb9.Tag = "9";
            this.rb9.Text = "x 9";
            this.rb9.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(23, 183);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(39, 17);
            this.rb8.TabIndex = 7;
            this.rb8.TabStop = true;
            this.rb8.Tag = "8";
            this.rb8.Text = "x 8";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(23, 160);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(39, 17);
            this.rb7.TabIndex = 6;
            this.rb7.TabStop = true;
            this.rb7.Tag = "7";
            this.rb7.Text = "x 7";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(23, 137);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(39, 17);
            this.rb6.TabIndex = 5;
            this.rb6.TabStop = true;
            this.rb6.Tag = "6";
            this.rb6.Text = "x 6";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(23, 114);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(39, 17);
            this.rb5.TabIndex = 4;
            this.rb5.TabStop = true;
            this.rb5.Tag = "5";
            this.rb5.Text = "x 5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(23, 91);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(39, 17);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Tag = "4";
            this.rb4.Text = "x 4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(23, 68);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(39, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Tag = "3";
            this.rb3.Text = "x 3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(23, 45);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(39, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Tag = "2";
            this.rb2.Text = "x 2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(23, 22);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(39, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Tag = "1";
            this.rb1.Text = "x 1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button ready;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label problem_to_solve;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.Label score_label;
    }
}

