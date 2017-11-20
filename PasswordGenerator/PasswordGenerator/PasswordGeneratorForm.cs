using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }
        public int length = Properties.Settings.Default.length;

        private void Form1_Load(object sender, EventArgs e)
        {
			// Hide select dummy
            shouldntShow.Hide();
            shouldntShow.Select();
			// Hide settings box
            groupBox1.Hide();
			// Set up length
            lengthSlider.Value = Properties.Settings.Default.length;
            lengthLabel.Text = "Length: " + length;
			// Load checkbox settings.
            digitsCheckbox.Checked = Properties.Settings.Default.digitsChecked;
            lettersCheckbox.Checked = Properties.Settings.Default.lettersChecked;
            specialCheckbox.Checked = Properties.Settings.Default.specialChecked;
			// Set height to not show settings
            this.Height = 106;

            if (lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// If all are checked, standard generate.
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without digits
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigits(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without digits and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigitsSpecial(length, 0);
                    }
                }
            }
            if (!lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLetters(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without letters and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLettersSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters and digits
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Check all boxes and generate standard
                        digitsCheckbox.Checked = true;
                        lettersCheckbox.Checked = true;
                        specialCheckbox.Checked = true;
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                }
            }
        }

        private void digitsCheck_CheckedChanged(object sender, EventArgs e)
        {
			// Set and save settings for digits checkbox 
            Properties.Settings.Default.digitsChecked = digitsCheckbox.Checked;
            Properties.Settings.Default.Save();
            if (lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// If all are checked, standard generate.
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without digits
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigits(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without digits and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigitsSpecial(length, 0);
                    }
                }
            }
            if (!lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLetters(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without letters and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLettersSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters and digits
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Check all boxes and generate standard
                        digitsCheckbox.Checked = true;
                        lettersCheckbox.Checked = true;
                        specialCheckbox.Checked = true;
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                }
            }
        }

        private void specialCheckbox_CheckChanged(object sender, EventArgs e)
        {
			// Set and save settings for special checkbox 
            Properties.Settings.Default.specialChecked = specialCheckbox.Checked;
            Properties.Settings.Default.Save();
            if (lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// If all are checked, standard generate.
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without digits
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigits(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without digits and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigitsSpecial(length, 0);
                    }
                }
            }
            if (!lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLetters(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without letters and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLettersSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters and digits
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Check all boxes and generate standard
                        digitsCheckbox.Checked = true;
                        lettersCheckbox.Checked = true;
                        specialCheckbox.Checked = true;
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                }
            }
        }

        private void lettersCheckbox_CheckChanged(object sender, EventArgs e)
        {
			// Set and save settings for letters checkbox 
            Properties.Settings.Default.lettersChecked = lettersCheckbox.Checked;
            Properties.Settings.Default.Save();
           if (lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// If all are checked, standard generate.
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without digits
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigits(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without digits and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigitsSpecial(length, 0);
                    }
                }
            }
            if (!lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLetters(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without letters and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLettersSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters and digits
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Check all boxes and generate standard
                        digitsCheckbox.Checked = true;
                        lettersCheckbox.Checked = true;
                        specialCheckbox.Checked = true;
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                }
            }
        }

        private void copyPassword_Click(object sender, EventArgs e)
        {
			// Send output to clipboard.
            Clipboard.SetText(passwordTextbox.Text);
        }

        private void backgroundOne_Click(object sender, EventArgs e)
        {
			// If the user tries clicking on the header, it will select the dummy instead of the header.
            shouldntShow.Select();
        }

        private void backgroundOne_MouseDown(object sender, MouseEventArgs e)
        {
			// If the user tries clicking on the header, it will select the dummy instead of the header.
            shouldntShow.Select();
        }

        private void lengthSlider_Scroll(object sender, EventArgs e)
        {
			// Set and save length settings.
            Properties.Settings.Default.length = lengthSlider.Value;
            Properties.Settings.Default.Save();
            length = Properties.Settings.Default.length;
            lengthLabel.Text = "Length: " + lengthSlider.Value.ToString();
            if (lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// If all are checked, standard generate.
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without digits
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigits(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without digits and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigitsSpecial(length, 0);
                    }
                }
            }
            if (!lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLetters(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Generate without letters and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLettersSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
						// Generate without letters and digits
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length);
                    }
                    if (!specialCheckbox.Checked)
                    {
						// Check all boxes and generate standard
                        digitsCheckbox.Checked = true;
                        lettersCheckbox.Checked = true;
                        specialCheckbox.Checked = true;
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                }
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible)
            {
                // If settings menu is visible, hide it.
                settingsButton.Text = "Show Settings";
                groupBox1.Hide();
                this.Height = 106;
            }
            else
            {
                // If settings menu is not visible, display it.
                settingsButton.Text = "Hide Settings";
                groupBox1.Show();
                this.Height = 281;
            }
        }

        private void newPassword_Click(object sender, EventArgs e)
        {
            if (lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
                        // If all are checked, standard generate.
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
                        // Generate without special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
                        // Generate without digits
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigits(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
                        // Generate without digits and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoDigitsSpecial(length, 0);
                    }
                }
            }
            if (!lettersCheckbox.Checked)
            {
                if (digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
                        // Generate without letters
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLetters(length, length / 4);
                    }
                    if (!specialCheckbox.Checked)
                    {
                        // Generate without letters and special
                        passwordTextbox.Text = Radker.PasswordGenerate_NoLettersSpecial(length, 0);
                    }
                }
                if (!digitsCheckbox.Checked)
                {
                    if (specialCheckbox.Checked)
                    {
                        // Generate without letters and digits
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length);
                    }
                    if (!specialCheckbox.Checked)
                    {
                        // Check all boxes and generate standard
                        digitsCheckbox.Checked = true;
                        lettersCheckbox.Checked = true;
                        specialCheckbox.Checked = true;
                        passwordTextbox.Text = Radker.PasswordGenerate(length, length / 4);
                    }
                }
            }
        }
    }
}
