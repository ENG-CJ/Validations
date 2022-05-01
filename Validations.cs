using System.Windows.Forms;


namespace Contacts
{
    internal class Validations
    {
        /*
         * This Validation Class Is Used To Validate Your
         * Project Data, This Class Contains More Different Validators
         * You Can Use All By Specfic Task
         * The Class Contains Dependencies 
         * --Download Krypton Toolkit (from github)
         * You Can Validate 
         * -Textbox, DateTime,CheckBox,RadioButtons,And So On;
         * 
         * Author: Abdulrahman Haaji (ENG-CJ)
         * Language: C# (Csharp)
         * Compatible For Projects
         * */


        // code Goes Here!


        // textBox Validator Class using this class to check only textbox 
        // and this class there is overload methods only they can accept string arguments

        public static class Textbox
        {
            // Blank Checkers using 2 input 
            public static bool IsBlank(string input1, string inpu2)
            {
                return input1 == "" || inpu2 == "";
            }

            // using 3 input
            public static bool IsBlank(string input1, string inpu2, string inpu3)
            {
                return input1 == "" || inpu2 == "" || inpu3 == "";
            }
            // using 4 input
            public static bool IsBlank(string input1, string inpu2, string inpu3, string input4)
            {
                return input1 == "" || inpu2 == "" || inpu3 == "" || input4 == "";
            }

            // using 6 input
            public static bool IsBlank(string input1, string inpu2, string inpu3, string input4,
               string input5, string input6)
            {
                return input1 == "" || inpu2 == "" || inpu3 == "" || input4 == "" || input5 == "" || input6 == "";
            }
        }


        // Password validator class
        // this class there is a methods that can only accept string arguments
        // these methods checking password input 

        public static class Passwords
        {
            // confirmation checker
            public static bool IsEqual(string password, string confirmPassword, bool Equals = false)
            {
                if (confirmPassword == password)
                    Equals = true;
                return Equals;
            }

            // password length checker (use max and min ) to validate your password length
            public static bool IsValidLength(string password, int max, int min)
            {
                bool isValid = false;
                if (password.Length > min && password.Length < max)
                    isValid = true;
                return isValid;
            }
        }


        // checkBox Validator class
        // methods inside this class they can only accept RadioButtons Of Winforms c#
        // dont use another datatype! 

        public static class Check_CheckBox
        {
            // method that checks if the user checked the checkbox  (using 1 checbox)

            public static bool IsChecked(CheckBox checkBox)
            {
                bool isChecked = false;
                if (checkBox.Checked)
                    isChecked = true;
                return isChecked;
            }

            // Overload method that checks if the user checked the checkbox  (using 2 checbox)

            public static bool IsChecked(CheckBox checkBox1, CheckBox checkBo2)
            {
                bool isChecked = false;
                if (checkBox1.Checked && checkBo2.Checked)
                    isChecked = true;

                return isChecked;
            }

            // Overload method that checks if the user checked the checkbox  (using 4 checbox)

            public static bool IsChecked(CheckBox checkBox1, CheckBox checkBo2, CheckBox checkBox3, CheckBox checkBo4)
            {
                bool isChecked = false;
                if (checkBox1.Checked && checkBo2.Checked && checkBox3.Checked && checkBo4.Checked)
                    isChecked = true;

                return isChecked;
            }

        }


        // RadioButton Validator class
        // methods inside this class they can only accept RadioButtons Of Winforms c#
        // dont use another datatype! 

        public static class Check_RadioButton
        {
            // a method that checks if the usr selected the radiobutton (using 2 radioButton)

            public static bool IsSelected(RadioButton radioButton1, RadioButton radioButton2)
            {
                bool isSelected = false;
                if (radioButton1.Checked && radioButton2.Checked)
                    isSelected = true;
                return isSelected;
            }

            // overvload a method that checks if the usr selected the radiobutton (using 3 radioButton)

            public static bool IsSelected(RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3)
            {
                bool isSelected = false;
                if (radioButton1.Checked && radioButton2.Checked && radioButton3.Checked)
                    isSelected = true;
                return isSelected;
            }

            // overvload a method that checks if the usr selected the radiobutton (using 4 radioButton)

            public static bool IsSelected(RadioButton radioButton1, RadioButton radioButton2,
                RadioButton radioButton3, RadioButton radioButton4)
            {
                bool isSelected = false;
                if (radioButton1.Checked && radioButton2.Checked && radioButton3.Checked && radioButton4.Checked)
                    isSelected = true;
                return isSelected;
            }
        }


        // Email Validator class
        // this class there is a method that checks the email format this method 
        // takes one argument string as a parameter

        public static class Emails
        {
            // method that checks email format
            public static bool IsValidEmail(string email)
            {
                bool isValid = false;
                if (email.EndsWith("@gmail.com") && !email.StartsWith("@gmail.com"))
                    isValid = true;
                return isValid;
            }

            // method that compares two emails  and takes two argument string as params

            public static bool IsEquals(string emailOne, string emailTwo)
            {

                bool isEqual = false;
                if (Validations.Textbox.IsBlank(emailOne, emailTwo))
                    MessageBox.Show("First Enter Emails", "Validator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if ((IsValidEmail(emailOne) && IsValidEmail(emailTwo)) && emailOne == emailTwo)
                        isEqual = true;
                    else
                        MessageBox.Show("One Of The Emails is Not Valid Email", "Validator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return isEqual;


            }
        }


    }
}
