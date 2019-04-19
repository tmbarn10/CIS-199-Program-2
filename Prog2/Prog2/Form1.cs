// Program 2
// CIS 199-02
// Due: 3/9/2017
// Grading ID: B3049

// This program uses four radio buttons and a text box for input in order to calculate when a student at the University of Louisville
// is supposed to sign up for summer and fall classes. The four radio buttons are for each class standing: freshman, sophomore, junior,
// and senior. The text box is used for typing in your last name. When you press the Find Registration Date button, the program will
// calculate your registration date based on the first letter of your last name and what you have selected as your class standing.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Prog2 : Form
    {
        public Prog2()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e) // click button that finds your registration date based on radio button clicked and input within the last name text box
        {
            const string TIME_ONE = "8:30 AM"; // String constants for all of the possible registration times
            const string TIME_TWO = "10:00 AM";
            const string TIME_THREE = "11:30 AM";
            const string TIME_FOUR = "2:00 PM";
            const string TIME_FIVE = "4:00 PM";

            string lastName; // Variable for last name, which is what is in the last name text box
            char lastNameFirstLetter; // Character variable for first letter of your last name
            string dateOutput = "Error"; // Registration date
            string timeOutput = "Error"; // Registration time

            lastName = lastNameTxt.Text; // Identifying lastName variable as what is in the lasNameTxt textbox
            
                lastName = lastName.ToUpper(); // Last name upper case
                lastNameFirstLetter = lastName[0]; // Identifies lastNameLetter as the first character in lastName

                
                    if (seniorRadioBtn.Checked) // If the senior radio button is checked
                    {
                        dateOutput = "March 29"; // Seniors register on March 29

                        if (lastNameFirstLetter <= 'D') // A-D
                            timeOutput = TIME_THREE;
                        else if (lastNameFirstLetter <= 'I') // E-I
                            timeOutput = TIME_FOUR;
                        else if (lastNameFirstLetter <= 'O') // J-O
                            timeOutput = TIME_FIVE;
                        else if (lastNameFirstLetter <= 'S') // P-S
                            timeOutput = TIME_ONE;
                        else
                            timeOutput = TIME_TWO; // T-Z
                    }
                    else if (juniorRadioBtn.Checked) // If junior radio button is checked
                    {
                        dateOutput = "March 30"; // Juniors register on March 30

                        if (lastNameFirstLetter <= 'D') // A-D
                            timeOutput = TIME_THREE;
                        else if (lastNameFirstLetter <= 'I') // E-I
                            timeOutput = TIME_FOUR;
                        else if (lastNameFirstLetter <= 'O') // J-O
                            timeOutput = TIME_FIVE;
                        else if (lastNameFirstLetter <= 'S') // P-S
                            timeOutput = TIME_ONE; 
                        else
                            timeOutput = TIME_TWO; // T-Z
                    }
                    else if (sophomoreRadioBtn.Checked) // Sophomore radio button is checked
                    {
                        if ((lastNameFirstLetter >= 'C') && (lastNameFirstLetter <= 'O')) // C-D, E-F, G-I, J-L, M-O
                            dateOutput = "April 3";
                        else
                            dateOutput = "March 31"; // P-Q, R-S, T-V, W-Z, A-B

                        if (lastNameFirstLetter <= 'B') // A-B
                            timeOutput = TIME_FIVE;
                        else if (lastNameFirstLetter <= 'D') // C-D
                            timeOutput = TIME_ONE;
                        else if (lastNameFirstLetter <= 'F') // E-F
                            timeOutput = TIME_TWO;
                        else if (lastNameFirstLetter <= 'I') // G-I
                            timeOutput = TIME_THREE;
                        else if (lastNameFirstLetter <= 'L') // J-L
                            timeOutput = TIME_FOUR;
                        else if (lastNameFirstLetter <= 'O') // M-O
                            timeOutput = TIME_FIVE;
                        else if (lastNameFirstLetter <= 'Q') // P-Q
                            timeOutput = TIME_ONE;
                        else if (lastNameFirstLetter <= 'S') // R-S
                            timeOutput = TIME_TWO;
                        else if (lastNameFirstLetter <= 'V') // T-V
                            timeOutput = TIME_THREE;
                        else
                            timeOutput = TIME_FOUR; // W-Z
                    }
                    else if (freshmanRadioBtn.Checked) // Freshman radio button is checked
                    {
                        if ((lastNameFirstLetter >= 'C') && (lastNameFirstLetter <= 'O')) // C-D, E-F, G-I, J-L, M-O
                            dateOutput = "April 5";
                        else
                            dateOutput = "April 4"; // P-Q, R-S, T-V, W-Z, A-B

                        if (lastNameFirstLetter <= 'B') // A-B
                            timeOutput = TIME_FIVE; 
                        else if (lastNameFirstLetter <= 'D') // C-D
                            timeOutput = TIME_ONE;
                        else if (lastNameFirstLetter <= 'F') // E-F
                            timeOutput = TIME_TWO;
                        else if (lastNameFirstLetter <= 'I') // G-I
                            timeOutput = TIME_THREE;
                        else if (lastNameFirstLetter <= 'L') // J-L
                            timeOutput = TIME_FOUR;
                        else if (lastNameFirstLetter <= 'O') // M-O
                            timeOutput = TIME_FIVE;
                        else if (lastNameFirstLetter <= 'Q') // P-Q
                            timeOutput = TIME_ONE;
                        else if (lastNameFirstLetter <= 'S') // R-S
                            timeOutput = TIME_TWO;
                        else if (lastNameFirstLetter <= 'V') // T-V
                            timeOutput = TIME_THREE;
                        else
                            timeOutput = TIME_FOUR; // W-Z
                    }

                    dateTimeLabel.Text = dateOutput + ", " + timeOutput; // Concatenates date ", " and time and puts it in the dateTimeLabel label.

            }
            
    }
}
