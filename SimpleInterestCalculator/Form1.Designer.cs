namespace SimpleInterestCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.principal = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.interest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthlyPaid = new System.Windows.Forms.TextBox();
            this.totalPaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.yearRadio = new System.Windows.Forms.RadioButton();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(469, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // principal
            // 
            this.principal.Location = new System.Drawing.Point(28, 53);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(100, 20);
            this.principal.TabIndex = 1;
            this.principal.TextChanged += new System.EventHandler(this.principal_TextChanged);
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(28, 105);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 20);
            this.rate.TabIndex = 2;
            // 
            // interest
            // 
            this.interest.Location = new System.Drawing.Point(322, 158);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(100, 20);
            this.interest.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Principal ($)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rate (%)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interest";
            // 
            // monthlyPaid
            // 
            this.monthlyPaid.Location = new System.Drawing.Point(322, 53);
            this.monthlyPaid.Name = "monthlyPaid";
            this.monthlyPaid.Size = new System.Drawing.Size(100, 20);
            this.monthlyPaid.TabIndex = 7;
            // 
            // totalPaid
            // 
            this.totalPaid.Location = new System.Drawing.Point(322, 105);
            this.totalPaid.Name = "totalPaid";
            this.totalPaid.Size = new System.Drawing.Size(100, 20);
            this.totalPaid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monthly Payment";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Paid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(28, 158);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 12;
            // 
            // yearRadio
            // 
            this.yearRadio.AutoSize = true;
            this.yearRadio.Location = new System.Drawing.Point(28, 184);
            this.yearRadio.Name = "yearRadio";
            this.yearRadio.Size = new System.Drawing.Size(54, 17);
            this.yearRadio.TabIndex = 13;
            this.yearRadio.TabStop = true;
            this.yearRadio.Text = "Yearly";
            this.yearRadio.UseVisualStyleBackColor = true;
            this.yearRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Location = new System.Drawing.Point(28, 204);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(62, 17);
            this.monthRadio.TabIndex = 14;
            this.monthRadio.TabStop = true;
            this.monthRadio.Text = "Monthly";
            this.monthRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 293);
            this.Controls.Add(this.monthRadio);
            this.Controls.Add(this.yearRadio);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPaid);
            this.Controls.Add(this.monthlyPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox principal;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox interest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox monthlyPaid;
        private System.Windows.Forms.TextBox totalPaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.RadioButton yearRadio;
        private System.Windows.Forms.RadioButton monthRadio;
    }
}

