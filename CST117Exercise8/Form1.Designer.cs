namespace CST117Exercise8
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
            this.buttonFat = new System.Windows.Forms.Button();
            this.OutputLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OutputLabel2 = new System.Windows.Forms.Label();
            this.buttonCarbs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat Grams:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calories From Fat:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(333, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 39);
            this.textBox1.TabIndex = 2;
            // 
            // buttonFat
            // 
            this.buttonFat.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFat.Location = new System.Drawing.Point(567, 36);
            this.buttonFat.Name = "buttonFat";
            this.buttonFat.Size = new System.Drawing.Size(113, 39);
            this.buttonFat.TabIndex = 3;
            this.buttonFat.Text = "Calculate";
            this.buttonFat.UseVisualStyleBackColor = false;
            // 
            // OutputLabel1
            // 
            this.OutputLabel1.AutoSize = true;
            this.OutputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.OutputLabel1.Location = new System.Drawing.Point(327, 104);
            this.OutputLabel1.Name = "OutputLabel1";
            this.OutputLabel1.Size = new System.Drawing.Size(188, 32);
            this.OutputLabel1.TabIndex = 4;
            this.OutputLabel1.Text = "OutputLabel1";
            this.OutputLabel1.Click += new System.EventHandler(this.OutputLabel1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Carbohydrate Grams:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Calories From Carbs:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(333, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 39);
            this.textBox2.TabIndex = 7;
            // 
            // OutputLabel2
            // 
            this.OutputLabel2.AutoSize = true;
            this.OutputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.OutputLabel2.Location = new System.Drawing.Point(327, 270);
            this.OutputLabel2.Name = "OutputLabel2";
            this.OutputLabel2.Size = new System.Drawing.Size(188, 32);
            this.OutputLabel2.TabIndex = 8;
            this.OutputLabel2.Text = "OutputLabel2";
            // 
            // buttonCarbs
            // 
            this.buttonCarbs.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarbs.Location = new System.Drawing.Point(567, 202);
            this.buttonCarbs.Name = "buttonCarbs";
            this.buttonCarbs.Size = new System.Drawing.Size(113, 39);
            this.buttonCarbs.TabIndex = 9;
            this.buttonCarbs.Text = "Calculate";
            this.buttonCarbs.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(740, 382);
            this.Controls.Add(this.buttonCarbs);
            this.Controls.Add(this.OutputLabel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutputLabel1);
            this.Controls.Add(this.buttonFat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFat;
        private System.Windows.Forms.Label OutputLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label OutputLabel2;
        private System.Windows.Forms.Button buttonCarbs;
    }
}

