using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWordProgram
{
    public partial class PasswordDataForm : Form
    {
        public PasswordDataForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close(); 
        }

        //The NumberUpperCase method accepts a stirng argument and returns the number of uppercase
        //letters it contains. 

        private int NumberUpperCase(string str)
        {
            int upperCase = 0;  //The number of uppercase letters... 

            //Count the uppercase characters in str. 
            foreach(char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++; 
                }  
            }
            //return the number of uppercase characters.
            return upperCase;
        }

        //isSpecialChar method accepts a string argument & return the special character it contains. 
        private int isSpecialChar(string str)
        {
            int isSpecialChar=0; //char special 
            
            //find the special character in str
            foreach(char ch in str)
            {
                if(!char.IsLetterOrDigit(ch))
                {
                    isSpecialChar++; 
                }
            }
            //returns special character..
            return isSpecialChar; 
        }

        //The NumberDigits method accepts a string argument and returns the number of digits
        // it contains. 
        private int NumberDigits(string str)
        {
            int digits = 0; //the number of digits 

            //Count the digits in string
            foreach(char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++; 
                }
                
            }

            //Return the number of digits.
            return digits; 
        }


        //The denySpaces method denys spaces that entered as part of the password 

        private int denySpaces(string str)
        {
            int spaces = 0;

            foreach (char ch in str)
            {
                if (char.IsWhiteSpace(ch))
                {
                    spaces++;
                } 
            }

            return spaces;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8; //Password's minium length 

            //get password from the TextBox 

            string password = txtPasswordTextBox.Text;

            //Validate the password 
            // create var with fullName then equal to split txtFullNameTextBox.Text by space
            var fullName = txtFullNameTextBox.Text.Split(null);
            //then put grab the first memory array spot of full name into  the string first name 
            string firstName = fullName[0];
            //do the same for last name 
            string lastName = fullName[1]; 

            //Password Validation Logic 

            if(password.Length >= MIN_LENGTH && NumberUpperCase(password) >=1 && isSpecialChar(password) >= 1 && NumberDigits(password) >= 1 && denySpaces(password)==0 && (!password.Contains(txtUserNameTextBox.Text)) && (!password.Contains(firstName)) && (!password.Contains(lastName)))
            {
                MessageBox.Show("The password is valid");
            }
            else
            {
                MessageBox.Show("The password does not meet " + "the requirements"); 
            }
        }

        private void PasswordDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
