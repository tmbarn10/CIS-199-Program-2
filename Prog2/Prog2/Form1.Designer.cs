namespace Prog2
{
    partial class Prog2
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
            this.classStandingGroupBox = new System.Windows.Forms.GroupBox();
            this.seniorRadioBtn = new System.Windows.Forms.RadioButton();
            this.juniorRadioBtn = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioBtn = new System.Windows.Forms.RadioButton();
            this.freshmanRadioBtn = new System.Windows.Forms.RadioButton();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.classStandingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classStandingGroupBox
            // 
            this.classStandingGroupBox.Controls.Add(this.seniorRadioBtn);
            this.classStandingGroupBox.Controls.Add(this.juniorRadioBtn);
            this.classStandingGroupBox.Controls.Add(this.sophomoreRadioBtn);
            this.classStandingGroupBox.Controls.Add(this.freshmanRadioBtn);
            this.classStandingGroupBox.Location = new System.Drawing.Point(12, 24);
            this.classStandingGroupBox.Name = "classStandingGroupBox";
            this.classStandingGroupBox.Size = new System.Drawing.Size(104, 114);
            this.classStandingGroupBox.TabIndex = 0;
            this.classStandingGroupBox.TabStop = false;
            this.classStandingGroupBox.Text = "Class Standing:";
            // 
            // seniorRadioBtn
            // 
            this.seniorRadioBtn.AutoSize = true;
            this.seniorRadioBtn.Location = new System.Drawing.Point(6, 88);
            this.seniorRadioBtn.Name = "seniorRadioBtn";
            this.seniorRadioBtn.Size = new System.Drawing.Size(55, 17);
            this.seniorRadioBtn.TabIndex = 4;
            this.seniorRadioBtn.TabStop = true;
            this.seniorRadioBtn.Text = "Senior";
            this.seniorRadioBtn.UseVisualStyleBackColor = true;
            // 
            // juniorRadioBtn
            // 
            this.juniorRadioBtn.AutoSize = true;
            this.juniorRadioBtn.Location = new System.Drawing.Point(6, 65);
            this.juniorRadioBtn.Name = "juniorRadioBtn";
            this.juniorRadioBtn.Size = new System.Drawing.Size(53, 17);
            this.juniorRadioBtn.TabIndex = 3;
            this.juniorRadioBtn.TabStop = true;
            this.juniorRadioBtn.Text = "Junior";
            this.juniorRadioBtn.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioBtn
            // 
            this.sophomoreRadioBtn.AutoSize = true;
            this.sophomoreRadioBtn.Location = new System.Drawing.Point(6, 42);
            this.sophomoreRadioBtn.Name = "sophomoreRadioBtn";
            this.sophomoreRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.sophomoreRadioBtn.TabIndex = 2;
            this.sophomoreRadioBtn.TabStop = true;
            this.sophomoreRadioBtn.Text = "Sophomore";
            this.sophomoreRadioBtn.UseVisualStyleBackColor = true;
            // 
            // freshmanRadioBtn
            // 
            this.freshmanRadioBtn.AutoSize = true;
            this.freshmanRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.freshmanRadioBtn.Name = "freshmanRadioBtn";
            this.freshmanRadioBtn.Size = new System.Drawing.Size(71, 17);
            this.freshmanRadioBtn.TabIndex = 1;
            this.freshmanRadioBtn.TabStop = true;
            this.freshmanRadioBtn.Text = "Freshman";
            this.freshmanRadioBtn.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(122, 68);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(189, 65);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(83, 20);
            this.lastNameTxt.TabIndex = 2;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(73, 153);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(138, 23);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find Registration Time";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTimeLabel.Location = new System.Drawing.Point(55, 195);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(174, 23);
            this.dateTimeLabel.TabIndex = 4;
            this.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Prog2
            // 
            this.AcceptButton = this.findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.classStandingGroupBox);
            this.Name = "Prog2";
            this.Text = "Prog2";
            this.classStandingGroupBox.ResumeLayout(false);
            this.classStandingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox classStandingGroupBox;
        private System.Windows.Forms.RadioButton seniorRadioBtn;
        private System.Windows.Forms.RadioButton juniorRadioBtn;
        private System.Windows.Forms.RadioButton sophomoreRadioBtn;
        private System.Windows.Forms.RadioButton freshmanRadioBtn;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label dateTimeLabel;
    }
}

