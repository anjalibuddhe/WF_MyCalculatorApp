namespace MyCalculatorApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cal_add = new System.Windows.Forms.Button();
            this.cal_sub = new System.Windows.Forms.Button();
            this.cal_mul = new System.Windows.Forms.Button();
            this.Cal_div = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Calculator App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter First Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 45);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 124);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 45);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Second String";
            // 
            // cal_add
            // 
            this.cal_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_add.Location = new System.Drawing.Point(93, 186);
            this.cal_add.Name = "cal_add";
            this.cal_add.Size = new System.Drawing.Size(75, 23);
            this.cal_add.TabIndex = 5;
            this.cal_add.Text = "ADD";
            this.cal_add.UseVisualStyleBackColor = true;
            this.cal_add.Click += new System.EventHandler(this.cal_add_Click);
            // 
            // cal_sub
            // 
            this.cal_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_sub.Location = new System.Drawing.Point(196, 186);
            this.cal_sub.Name = "cal_sub";
            this.cal_sub.Size = new System.Drawing.Size(99, 23);
            this.cal_sub.TabIndex = 6;
            this.cal_sub.Text = "SUBTRACTION";
            this.cal_sub.UseVisualStyleBackColor = true;
            this.cal_sub.Click += new System.EventHandler(this.cal_sub_Click);
            // 
            // cal_mul
            // 
            this.cal_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_mul.Location = new System.Drawing.Point(301, 186);
            this.cal_mul.Name = "cal_mul";
            this.cal_mul.Size = new System.Drawing.Size(101, 23);
            this.cal_mul.TabIndex = 7;
            this.cal_mul.Text = "MUL";
            this.cal_mul.UseVisualStyleBackColor = true;
            this.cal_mul.Click += new System.EventHandler(this.cal_mul_Click);
            // 
            // Cal_div
            // 
            this.Cal_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cal_div.Location = new System.Drawing.Point(408, 186);
            this.Cal_div.Name = "Cal_div";
            this.Cal_div.Size = new System.Drawing.Size(95, 23);
            this.Cal_div.TabIndex = 8;
            this.Cal_div.Text = "DIV";
            this.Cal_div.UseVisualStyleBackColor = true;
            this.Cal_div.Click += new System.EventHandler(this.Cal_div_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cal_div);
            this.Controls.Add(this.cal_mul);
            this.Controls.Add(this.cal_sub);
            this.Controls.Add(this.cal_add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cal_add;
        private System.Windows.Forms.Button cal_sub;
        private System.Windows.Forms.Button cal_mul;
        private System.Windows.Forms.Button Cal_div;
        private System.Windows.Forms.Label label4;
    }
}

