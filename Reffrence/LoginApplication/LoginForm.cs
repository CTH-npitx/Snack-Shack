using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        string cmbPlaceholdText = "Select the desired question from this list"; //the placeholder combo box text

        //debug mode (one for active, anything else for inactive)
        const bool debugSystem = false;

       // private void frmMain_Load(object sender, EventArgs e)
        {
            cmbSecQuest.Items.Insert(0, cmbPlaceholdText);
            cmbSecQuest.SelectedIndex = 0;

            //prepare debug box
            //setup debug box
            txt_debugInfo.Text = string.Empty;
            if (debugSystem)
            {
                txt_debugInfo.Show();
                lblCountSecQuest.Show();
            };
       }

        /*close program
        private void btnClose_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        } */

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (debugSystem)
            {
                txtConfirmPass.Text = txtPass.Text;
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_UserID_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            //create debug system (use an empty string for a new line)
            string addText(string inputText)
            {
                if (inputText == "")
                {
                    txt_debugInfo.AppendText(Environment.NewLine);
                } //add ina new line if empty string
                else
                {
                    if (txt_debugInfo.Text == string.Empty)
                    {
                        txt_debugInfo.Text = inputText;
                    } //if empty no extra line
                    else
                    {
                        txt_debugInfo.AppendText(Environment.NewLine);
                        txt_debugInfo.Text += inputText;
                    } //normally new line
                } //add in text with lines in with input
                return txt_debugInfo.Text;
            };

            // vars
            var correct = 0;
            var uID = txtUserID.Text.ToString(); //storeID
            var pass = txtPass.Text.ToString(); //pass
            var confirmPass = txtConfirmPass.Text.ToString(); //passConfirm
            var secQuest = cmbSecQuest.SelectedItem.ToString(); //Security Question
            var secAns = txtSecAnswer.Text; //Security Answer
            var correctCol = Color.LimeGreen; //what color to use for correct inputs
            var incorrectCol = Color.OrangeRed; //what color to use for incorrect inputs
            var pickedSecQuest = int.Parse(lblCountSecQuest.Text);
            var baseColor = txt_debugInfo.BackColor;

            //user ID full?
            if (uID == string.Empty)
            {
                txtUserID.BackColor = Color.OrangeRed;
                txtUserError.Text = "No User ID";
            }
            else
            {
                txtUserID.BackColor = correctCol;
                txtUserID.Enabled = false;
                txtUserError.Text = string.Empty;
                correct++;
            }

            //passcodes full
            if (pass == string.Empty)
            {
                txtPass.BackColor = incorrectCol;
                txtPasswordError.Text = "No Password";
            }
            else
            {
                correct++;
                txtPass.BackColor = correctCol;
                txtPasswordError.Text = string.Empty;
            };

            //passcodes same?
            if (txtPass.BackColor == incorrectCol)
            {
                txtConfirmPass.BackColor = incorrectCol;
                txtConfirmError.Text = "No Password in main input";
            }
            else
            {
                if (pass == confirmPass)
                {
                    txtConfirmPass.BackColor = correctCol;
                    txtPass.Enabled = false;
                    txtConfirmPass.Enabled = false;
                    txtConfirmError.Text = string.Empty;
                    correct++;
                }
                else
                {
                    txtConfirmPass.BackColor = incorrectCol;
                    txtConfirmError.Text = "Passcodes inequal";
                };
            };

            correct = correct + pickedSecQuest;
            if (secQuest == cmbPlaceholdText) //no question
            {
                txtQuestionWarn.Text = "Pick Desired Question";
            }//chose question
            else //picked question
            {
                txtQuestionWarn.Text = string.Empty;
            };

            if (secAns == string.Empty)
            {
                txtAnswerWarn.Text = "No Provided Answer";
                txtSecAnswer.BackColor = incorrectCol;
            }//question missing value
            else
            {
                txtAnswerWarn.Text = string.Empty; //reset question warn
                txtSecAnswer.BackColor = correctCol;
                if (secQuest == cmbPlaceholdText)
                {
                    txtAnswerWarn.Text = "provided answer but no selected question";
                    txtSecAnswer.BackColor = incorrectCol;
                } //no question
                else //add
                {
                    txtSecAnswer.Enabled = false;
                    cmbSecQuest.Enabled = false;
                }//both correct;
                correct++;
            } //question has vales;

            if (debugSystem) //the debug system
            {
                txt_debugInfo.Text = string.Empty; //reset box

                addText(correct.ToString()); //total correct
                addText("");
                addText(uID); //userID
                addText(pass); //confirm pass
                addText(confirmPass); //confirm quest
                addText("");
                addText(secQuest); //secuirty quest
                addText(secAns); //security answer
                correct = 5; //set correct to five to allow rapid testing
            }

            if (correct == 5)
            {

                user u = new user();
                u.username = uID;
                u.password = pass;
                u.secQuest = secQuest;
                u.secAnswer = secAns;
                
                if (lst_userID.Visible == false) //no entry yet, this is the first one. Show box
                {
                    lst_userID.Show();
                }
                if (lst_userID.SelectedIndex == -1) //nothing selected, so add
                {
                    Program.users.Add(u);
                    lst_userID.Items.Add(uID.PadRight(15) + DateTime.Now.ToString("g"));
                } else //somethings selected, so edit
                {
                    Program.users[lst_userID.SelectedIndex] = u;
                    lst_userID.Items[lst_userID.SelectedIndex] = (uID.PadRight(15) + DateTime.Now.ToString("g"));
                }


                txtUserID.Text = string.Empty; //remove text in userID
                txtPass.Text = string.Empty; //remove text in passcode
                txtConfirmPass.Text = string.Empty;
                cmbSecQuest.Items.Insert(0, cmbPlaceholdText); //reset security question
                cmbSecQuest.SelectedIndex = 0;
                txtSecAnswer.Text = string.Empty; //remove text from security answer

                txtUserID.BackColor = baseColor; //set user ID to base color
                txtPass.BackColor = baseColor; //set passcode to base color
                txtConfirmPass.BackColor = baseColor; //set confirm pass to base color
                txtSecAnswer.BackColor = baseColor; //set back color of sec answer to base

                txtUserID.Enabled = true; //enable
                txtSecAnswer.Enabled = true; // enable
                txtPass.Enabled = true; //enable
                txtConfirmPass.Enabled = true; //enable
                cmbSecQuest.Enabled = true; //enable
                txtSecAnswer.Enabled = true; //enable

                lblCountSecQuest.Text = Convert.ToString(0); //reset label value
            }
        }

        private void prgStage_Click(object sender, EventArgs e)
        {

        }

        private void txtSecAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmError_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordError_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserError_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswerWarn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestionWarn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_debugInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCountSecQuest_Click(object sender, EventArgs e)
        {

        }

        private void cmbSecQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //current index

            int indexNum = int.Parse(cmbSecQuest.SelectedIndex.ToString());

            //has run
            int run = int.Parse(lblCountSecQuest.Text.ToString());
            if (run == 0)
            {
                if (indexNum == 0)
                {

                }
                else
                {
                    // remove first entry
                    cmbSecQuest.Items.RemoveAt(0);
                    lblCountSecQuest.Text = Convert.ToString(run + 1);

                };
            };
        }

        private void lst_userID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lst_userID.SelectedIndex != -1)
            {
                user u = Program.users[lst_userID.SelectedIndex];
                txtUserID.Text = u.username;
                txtPass.Text = u.password;
                txtConfirmPass.Text = u.password;
                txtSecAnswer.Text = u.secAnswer;
                cmbSecQuest.Text = u.secQuest;
            }

        }
    }
}
