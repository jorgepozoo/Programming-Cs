namespace Assign7
{
    partial class Assigment7
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
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goalsRadioButton = new System.Windows.Forms.RadioButton();
            this.numberRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.reverseCheckBox = new System.Windows.Forms.CheckBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jersey Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player\'s Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(550, 155);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(192, 22);
            this.nameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Goals Scored";
            // 
            // jerseyNumberBox
            // 
            this.jerseyNumberBox.Location = new System.Drawing.Point(550, 216);
            this.jerseyNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.jerseyNumberBox.Name = "jerseyNumberBox";
            this.jerseyNumberBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jerseyNumberBox.Size = new System.Drawing.Size(61, 22);
            this.jerseyNumberBox.TabIndex = 8;
            this.jerseyNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goalsScoredBox
            // 
            this.goalsScoredBox.Location = new System.Drawing.Point(550, 268);
            this.goalsScoredBox.Margin = new System.Windows.Forms.Padding(4);
            this.goalsScoredBox.Name = "goalsScoredBox";
            this.goalsScoredBox.Size = new System.Drawing.Size(61, 22);
            this.goalsScoredBox.TabIndex = 11;
            this.goalsScoredBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(469, 331);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(106, 40);
            this.addPlayerButton.TabIndex = 12;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(606, 331);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(106, 40);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update Player";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.goalsRadioButton);
            this.groupBox1.Controls.Add(this.numberRadioButton);
            this.groupBox1.Controls.Add(this.nameRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 60);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By";
            // 
            // goalsRadioButton
            // 
            this.goalsRadioButton.AutoSize = true;
            this.goalsRadioButton.Location = new System.Drawing.Point(178, 19);
            this.goalsRadioButton.Name = "goalsRadioButton";
            this.goalsRadioButton.Size = new System.Drawing.Size(64, 20);
            this.goalsRadioButton.TabIndex = 2;
            this.goalsRadioButton.Text = "Goals";
            this.goalsRadioButton.UseVisualStyleBackColor = true;
            // 
            // numberRadioButton
            // 
            this.numberRadioButton.AutoSize = true;
            this.numberRadioButton.Location = new System.Drawing.Point(95, 20);
            this.numberRadioButton.Name = "numberRadioButton";
            this.numberRadioButton.Size = new System.Drawing.Size(76, 20);
            this.numberRadioButton.TabIndex = 1;
            this.numberRadioButton.Text = "Number";
            this.numberRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(23, 21);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(65, 20);
            this.nameRadioButton.TabIndex = 0;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // reverseCheckBox
            // 
            this.reverseCheckBox.AutoSize = true;
            this.reverseCheckBox.Location = new System.Drawing.Point(291, 62);
            this.reverseCheckBox.Name = "reverseCheckBox";
            this.reverseCheckBox.Size = new System.Drawing.Size(118, 20);
            this.reverseCheckBox.TabIndex = 17;
            this.reverseCheckBox.Text = "Reverse Order";
            this.reverseCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(441, 52);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(91, 38);
            this.sortButton.TabIndex = 18;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Goals";
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 16;
            this.displayListBox.Location = new System.Drawing.Point(12, 132);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(393, 420);
            this.displayListBox.TabIndex = 23;
            this.displayListBox.DoubleClick += new System.EventHandler(this.displayListBox_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.cLoseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.loadToolStripMenuItem.Text = "Load File";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.saveToolStripMenuItem.Text = "Save File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cLoseToolStripMenuItem
            // 
            this.cLoseToolStripMenuItem.Name = "cLoseToolStripMenuItem";
            this.cLoseToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.cLoseToolStripMenuItem.Text = "CLose";
            this.cLoseToolStripMenuItem.Click += new System.EventHandler(this.cLoseToolStripMenuItem_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(550, 411);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Clearbutton.Size = new System.Drawing.Size(75, 37);
            this.Clearbutton.TabIndex = 25;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Double-click any team member to edit their information";
            // 
            // Assigment7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 600);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.reverseCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.goalsScoredBox);
            this.Controls.Add(this.jerseyNumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Assigment7";
            this.Text = "Hockey Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox reverseCheckBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton nameRadioButton;
        public System.Windows.Forms.RadioButton goalsRadioButton;
        public System.Windows.Forms.RadioButton numberRadioButton;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLoseToolStripMenuItem;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Label label7;
    }
}

