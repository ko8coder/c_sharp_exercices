using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class frmPwGenerator : Form
    {
        public frmPwGenerator()
        {
            InitializeComponent();
        }
        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            int len_Password = (int)nud.Value; //nud = NumericUpDown
            string Password = GeneratePassword(len_Password);
            lblPassword.Text = Password;
        }
        private string GeneratePassword(int len_Password)
        {
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()_+-=[]{}?";

            string validChars ="";

            if (cbSymbols.Checked) validChars += symbols;
            if (cbNumbers.Checked) validChars += numbers;
            if (cbUppercase.Checked) validChars += uppercase;
            if (cbLowercase.Checked) validChars += lowercase;

            if (string.IsNullOrEmpty(validChars))
            {
                MessageBox.Show
                    ("Please select at least one character set " +
                    "(lowercase, uppercase, numbers, or symbols)." +
                    " No password was generated..","Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning );

                return "";
            }

            StringBuilder stringBuilder = new StringBuilder();
            byte[] tempo = new byte[4];

            using(RandomNumberGenerator randomGen = RandomNumberGenerator.Create())
            { 
                for (int i = 0; i < len_Password; i++)
                {
                    randomGen.GetBytes(tempo);
                    int randInt = BitConverter.ToInt32(tempo,0) & int.MaxValue;
                   int index = randInt % validChars.Length;
                    stringBuilder.Append(validChars[index]);
                }
            }
            return stringBuilder.ToString();
                            
        }
    }
}