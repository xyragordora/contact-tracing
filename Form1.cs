using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace con_trac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter X = new StreamWriter(Application.StartupPath + "\\Info\\" + "contact tracing information.txt");

            X.WriteLine("DEMOGRAPHIC PROFILE:");
            X.WriteLine();
            X.WriteLine(labelName.Text + " " + textBoxName.Text); //NAME
            X.WriteLine(labelAge.Text + " " + textBoxAge.Text); //AGE

            //ComboBox Birthday
            string MonthB = comboBoxMbday.SelectedItem.ToString();
            string DateB = comboBoxDbday.SelectedItem.ToString();
            X.WriteLine(labelBday.Text + " " + MonthB + " " + DateB + "," + textBoxYbday.Text);

            //ComboBox Sex
            string Sex = comboBoxSex.SelectedItem.ToString();
            X.WriteLine(labelSex.Text + " " + Sex);

            X.WriteLine(labelCivil.Text + " " + textBoxCivil.Text); //CIVIL STAT
            X.WriteLine(labelNation.Text + " " + textBoxNation.Text); //NATIONALITY
            X.WriteLine(labelRel.Text + " " + textBoxRel.Text); //RELIGION
            X.WriteLine(labelBplace.Text + " " + textBoxBplace.Text); //BIRTH PLACE
            X.WriteLine(labelHomeadd.Text + " " + textBoxHomeadd.Text); //HOME ADDRESS
            X.WriteLine(labelPhone.Text + " " + textBoxPhone.Text); //PHONE NO.
            X.WriteLine(labelEmail.Text + " " + textBoxEmail.Text); //EMAIL

            X.WriteLine();
            X.WriteLine("NATURE OF EXPOSURE: ");
            X.WriteLine();
            X.WriteLine("Travel History:");

            //OUTSIDE COUNTRY
            if (checkBoxYes1.Checked)
            {
                checkBoxNo1.Enabled = false;
                X.WriteLine(labelOutside.Text + "" + checkBoxYes1.Text);
                X.WriteLine(labelIf1.Text + " " + textBoxIf1.Text);

                string M1 = comboBoxM1.SelectedItem.ToString();
                string D1 = comboBoxD1.SelectedItem.ToString();
                X.WriteLine(labelDate1.Text + " " + M1 + " " + D1 + " " + textBoxY1.Text);

            }
            else if (checkBoxNo1.Checked)
            {
                X.WriteLine(labelOutside.Text + "" + checkBoxNo1.Text);
                checkBoxYes1.Enabled = false;
                comboBoxD1.Enabled = false;
                comboBoxM1.Enabled = false;
                textBoxY1.Enabled = false;


            }
            else
            {

            }
            
            //WITHIN COUNTRY
            X.WriteLine();
            if (checkBoxYes2.Checked)
            {
                checkBoxNo2.Enabled = false;
                X.WriteLine(labelWithin.Text + "" + checkBoxYes2.Text);
                X.WriteLine(labelIf2.Text + " " + textBoxIf2.Text);

                string M2 = comboBoxM2.SelectedItem.ToString();
                string D2 = comboBoxD2.SelectedItem.ToString();
                X.WriteLine(labelDate2.Text + " " + M2 + " " + D2 + " " + textBoxY2.Text);
            }
            else if (checkBoxNo2.Checked)
            {
                checkBoxYes2.Enabled = false;
                comboBoxD2.Enabled = false;
                comboBoxM2.Enabled = false;
                textBoxY2.Enabled = false;
                X.WriteLine(labelWithin.Text + "" + checkBoxNo2.Text);
            }
            else
            {

            }
            

            //SOCIAL EVENTS
            X.WriteLine();
            if (checkBoxYes3.Checked)
            {
                checkBoxNo3.Enabled = false;
                X.WriteLine(labelSocial.Text + "" + checkBoxYes3.Text);

                X.WriteLine(labelIf3.Text + " " + textBoxIf3.Text);
                string M3 = comboBoxM3.SelectedItem.ToString();
                string D3 = comboBoxD3.SelectedItem.ToString();
                X.WriteLine(labelDate3.Text + " " + M3 + " " + D3 + " " + textBoxY3.Text);
            }
            else if (checkBoxNo3.Checked)
            {
                checkBoxYes3.Enabled = false;
                comboBoxD3.Enabled = false;
                comboBoxM3.Enabled = false;
                textBoxY3.Enabled = false;
                X.WriteLine(labelSocial.Text + "" + checkBoxNo3.Text);
            }
            else
            {

            }
           

           

            X.WriteLine();
            X.WriteLine("Exposure History");

            //CONTACT COVID PATIENT
            if (checkBoxYes4.Checked)
            {
                checkBoxNo4.Enabled = false;
                X.WriteLine(labelContact.Text + "" + checkBoxYes4.Text);
            }
            else if (checkBoxNo4.Checked)
            {
                checkBoxYes4.Enabled = false;
                X.WriteLine(labelContact.Text + "" + checkBoxNo4.Text);
            }
            else
            {

            }

            //EXPOSED COVID VARIANT 
            if (checkBoxYes5.Checked)
            {
                checkBoxNo5.Enabled = false;
                X.WriteLine(labelExposed.Text + "" + checkBoxYes5.Text);
            }
            else if (checkBoxNo5.Checked)
            {
                checkBoxYes5.Enabled = false;
                X.WriteLine(labelExposed.Text + "" + checkBoxNo5.Text);
            }
            else
            {

            }

            //SYMPTOMATIC
            X.WriteLine();
            if (checkBoxYes6.Checked)
            {
                checkBoxNo6.Enabled = false;
                X.WriteLine(labelSymptom.Text + "" + checkBoxYes6.Text);

                string M4 = comboBoxM4.SelectedItem.ToString();
                string D4 = comboBoxD4.SelectedItem.ToString();
                X.WriteLine(labelIf4.Text + " " + M4 + " " + D4 + " " + textBoxY4.Text);
            }
            else if (checkBoxNo6.Checked)
            {
                checkBoxYes6.Enabled = false;
                comboBoxD4.Enabled = false;
                comboBoxM4.Enabled = false;
                textBoxY4.Enabled = false;
                X.WriteLine(labelSymptom.Text + "" + checkBoxNo6.Text);
            }
            else
            {

            }

           





            X.Close();
        }
    }
}
