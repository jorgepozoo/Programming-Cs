namespace Assign5
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
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select calling area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length of Call";
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(16, 39);
            this.lengthBox.Margin = new System.Windows.Forms.Padding(4);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(132, 22);
            this.lengthBox.TabIndex = 2;
            this.lengthBox.TextChanged += new System.EventHandler(this.lengthBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(92, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rate/min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Minimum minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Charge";
            // 
            // rateBox
            // 
            this.rateBox.Enabled = false;
            this.rateBox.Location = new System.Drawing.Point(28, 127);
            this.rateBox.Margin = new System.Windows.Forms.Padding(4);
            this.rateBox.Name = "rateBox";
            this.rateBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rateBox.Size = new System.Drawing.Size(99, 22);
            this.rateBox.TabIndex = 8;
            this.rateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minBox
            // 
            this.minBox.Enabled = false;
            this.minBox.Location = new System.Drawing.Point(189, 127);
            this.minBox.Margin = new System.Windows.Forms.Padding(4);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(99, 22);
            this.minBox.TabIndex = 9;
            this.minBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalBox
            // 
            this.totalBox.Enabled = false;
            this.totalBox.Location = new System.Drawing.Point(356, 126);
            this.totalBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(141, 22);
            this.totalBox.TabIndex = 10;
            this.totalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 344);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox totalBox;
    }
}

