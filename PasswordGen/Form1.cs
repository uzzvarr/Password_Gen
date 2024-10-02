using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGen {
    public partial class Form1 : Form {

        int currentPasswordLenght = 0;
        Random character = new Random();

        private void PasswordGen(int passwordLengh) 
        {
            String allChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789();'~`:<>?,.{}[]!@#$%^&*";
            String RandPassword = "";

            for (int i = 0; i < passwordLengh; i++)
            {
                int randNum = character.Next(0, allChars.Length);
                RandPassword += allChars[randNum];
            }
            passwordLabel.Text = RandPassword;
        }

        public Form1() 
        {
            InitializeComponent();
            PasswordLenghtSlider.Minimum = 8;
            PasswordLenghtSlider.Maximum = 16;
            PasswordGen(8);
        }

        private void CopyPasswordBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordLabel.Text);
        }

        private void PasswordLenghtSlider_Scroll(object sender, EventArgs e)
        {
            PasswordLenghtLabel.Text = "Password Lenght: " + PasswordLenghtSlider.Value.ToString();
            currentPasswordLenght = PasswordLenghtSlider.Value;
            PasswordGen(currentPasswordLenght);
        }
    }
}
