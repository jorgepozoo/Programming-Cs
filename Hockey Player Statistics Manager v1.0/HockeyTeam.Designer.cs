namespace Assign6
{
    partial class Assigment6
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jerseyNumberBox = new System.Windows.Forms.TextBox();
            this.goalsScoredBox = new System.Windows.Forms.TextBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jersey Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player\'s Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(16, 39);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Goals Scored";
            // 
            // jerseyNumberBox
            // 
            this.jerseyNumberBox.Location = new System.Drawing.Point(229, 39);
            this.jerseyNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.jerseyNumberBox.Name = "jerseyNumberBox";
            this.jerseyNumberBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jerseyNumberBox.Size = new System.Drawing.Size(115, 22);
            this.jerseyNumberBox.TabIndex = 8;
            this.jerseyNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goalsScoredBox
            // 
            this.goalsScoredBox.Location = new System.Drawing.Point(412, 39);
            this.goalsScoredBox.Margin = new System.Windows.Forms.Padding(4);
            this.goalsScoredBox.Name = "goalsScoredBox";
            this.goalsScoredBox.Size = new System.Drawing.Size(115, 22);
            this.goalsScoredBox.TabIndex = 11;
            this.goalsScoredBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(175, 92);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(221, 46);
            this.addPlayerButton.TabIndex = 12;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(12, 261);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(506, 183);
            this.displayBox.TabIndex = 13;
            this.displayBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show Players Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Assigment6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.goalsScoredBox);
            this.Controls.Add(this.jerseyNumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Assigment6";
            this.Text = "Hockey Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jerseyNumberBox;
        private System.Windows.Forms.TextBox goalsScoredBox;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Button button1;
    }
}

