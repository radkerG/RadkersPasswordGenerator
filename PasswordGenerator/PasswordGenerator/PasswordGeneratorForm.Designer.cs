namespace PasswordGenerator
{
    partial class PasswordGeneratorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthSlider = new System.Windows.Forms.TrackBar();
            this.digitsCheckbox = new System.Windows.Forms.CheckBox();
            this.specialCheckbox = new System.Windows.Forms.CheckBox();
            this.lettersCheckbox = new System.Windows.Forms.CheckBox();
            this.backgroundOne = new System.Windows.Forms.TextBox();
            this.copyPassword = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.shouldntShow = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lengthLabel);
            this.groupBox1.Controls.Add(this.lengthSlider);
            this.groupBox1.Controls.Add(this.digitsCheckbox);
            this.groupBox1.Controls.Add(this.specialCheckbox);
            this.groupBox1.Controls.Add(this.lettersCheckbox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(141, 21);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(59, 19);
            this.lengthLabel.TabIndex = 7;
            this.lengthLabel.Text = "Length: ";
            // 
            // lengthSlider
            // 
            this.lengthSlider.Location = new System.Drawing.Point(120, 43);
            this.lengthSlider.Maximum = 20;
            this.lengthSlider.Minimum = 4;
            this.lengthSlider.Name = "lengthSlider";
            this.lengthSlider.Size = new System.Drawing.Size(104, 45);
            this.lengthSlider.TabIndex = 6;
            this.lengthSlider.Value = 12;
            this.lengthSlider.Scroll += new System.EventHandler(this.lengthSlider_Scroll);
            // 
            // digitsCheckbox
            // 
            this.digitsCheckbox.AutoSize = true;
            this.digitsCheckbox.Checked = true;
            this.digitsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digitsCheckbox.Location = new System.Drawing.Point(6, 53);
            this.digitsCheckbox.Name = "digitsCheckbox";
            this.digitsCheckbox.Size = new System.Drawing.Size(63, 23);
            this.digitsCheckbox.TabIndex = 4;
            this.digitsCheckbox.Text = "Digits";
            this.digitsCheckbox.UseVisualStyleBackColor = true;
            this.digitsCheckbox.CheckedChanged += new System.EventHandler(this.digitsCheck_CheckedChanged);
            // 
            // specialCheckbox
            // 
            this.specialCheckbox.AutoSize = true;
            this.specialCheckbox.Checked = true;
            this.specialCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.specialCheckbox.Location = new System.Drawing.Point(6, 82);
            this.specialCheckbox.Name = "specialCheckbox";
            this.specialCheckbox.Size = new System.Drawing.Size(69, 23);
            this.specialCheckbox.TabIndex = 5;
            this.specialCheckbox.Text = "Special";
            this.specialCheckbox.UseVisualStyleBackColor = true;
            this.specialCheckbox.CheckedChanged += new System.EventHandler(this.specialCheckbox_CheckChanged);
            // 
            // lettersCheckbox
            // 
            this.lettersCheckbox.AutoSize = true;
            this.lettersCheckbox.Checked = true;
            this.lettersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lettersCheckbox.Location = new System.Drawing.Point(6, 24);
            this.lettersCheckbox.Name = "lettersCheckbox";
            this.lettersCheckbox.Size = new System.Drawing.Size(70, 23);
            this.lettersCheckbox.TabIndex = 3;
            this.lettersCheckbox.Text = "Letters";
            this.lettersCheckbox.UseVisualStyleBackColor = true;
            this.lettersCheckbox.CheckedChanged += new System.EventHandler(this.lettersCheckbox_CheckChanged);
            // 
            // backgroundOne
            // 
            this.backgroundOne.BackColor = System.Drawing.Color.DodgerBlue;
            this.backgroundOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backgroundOne.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.backgroundOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.backgroundOne.Location = new System.Drawing.Point(0, 0);
            this.backgroundOne.Name = "backgroundOne";
            this.backgroundOne.ReadOnly = true;
            this.backgroundOne.Size = new System.Drawing.Size(284, 68);
            this.backgroundOne.TabIndex = 3;
            this.backgroundOne.Click += new System.EventHandler(this.backgroundOne_Click);
            this.backgroundOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundOne_MouseDown);
            // 
            // copyPassword
            // 
            this.copyPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.copyPassword.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.copyPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(125)))), ((int)(((byte)(235)))));
            this.copyPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.copyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.copyPassword.ForeColor = System.Drawing.Color.White;
            this.copyPassword.Location = new System.Drawing.Point(12, 9);
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(30, 30);
            this.copyPassword.TabIndex = 6;
            this.copyPassword.Text = "📋";
            this.copyPassword.UseVisualStyleBackColor = false;
            this.copyPassword.Click += new System.EventHandler(this.copyPassword_Click);
            // 
            // newPassword
            // 
            this.newPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.newPassword.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.newPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(125)))), ((int)(((byte)(235)))));
            this.newPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.newPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.newPassword.ForeColor = System.Drawing.Color.White;
            this.newPassword.Location = new System.Drawing.Point(242, 9);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(30, 30);
            this.newPassword.TabIndex = 5;
            this.newPassword.Text = "🔃";
            this.newPassword.UseVisualStyleBackColor = false;
            this.newPassword.Click += new System.EventHandler(this.newPassword_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.DodgerBlue;
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.White;
            this.passwordTextbox.Location = new System.Drawing.Point(0, 12);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.ReadOnly = true;
            this.passwordTextbox.Size = new System.Drawing.Size(284, 22);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.Text = "Fatal Error";
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shouldntShow
            // 
            this.shouldntShow.AutoSize = true;
            this.shouldntShow.Location = new System.Drawing.Point(-3, 45);
            this.shouldntShow.Name = "shouldntShow";
            this.shouldntShow.Size = new System.Drawing.Size(74, 13);
            this.shouldntShow.TabIndex = 6;
            this.shouldntShow.Text = "shouldntShow";
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(125)))), ((int)(((byte)(235)))));
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(77, 40);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(121, 23);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Show Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(26, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Made by Radker, please don\'t re-distribute.";
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.shouldntShow);
            this.Controls.Add(this.copyPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.backgroundOne);
            this.Controls.Add(this.groupBox1);
            this.Name = "PasswordGeneratorForm";
            this.Text = "PasswordGeneratorForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox digitsCheckbox;
        private System.Windows.Forms.CheckBox specialCheckbox;
        private System.Windows.Forms.CheckBox lettersCheckbox;
        private System.Windows.Forms.TextBox backgroundOne;
        private System.Windows.Forms.Button copyPassword;
        private System.Windows.Forms.Button newPassword;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label shouldntShow;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TrackBar lengthSlider;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label1;
    }
}

