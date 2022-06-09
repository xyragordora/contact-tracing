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

        private void button4_Click(object sender, EventArgs e)
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
            if (checkBoxY1.Checked)
            {
                checkBoxN1.Enabled = false;
                X.WriteLine(labelOutside.Text + "" + checkBoxY1.Text);
                X.WriteLine(labelifY1.Text + " " + textBoxifY1.Text);

                string M1 = comboBoxMo1.SelectedItem.ToString();
                string D1 = comboBoxDa1.SelectedItem.ToString();
                X.WriteLine(labeldt1.Text + " " + M1 + " " + D1 + "," + textBoxYear1.Text);

            }
            else if (checkBoxN1.Checked)
            {
                X.WriteLine(labelOutside1.Text + "" + checkBoxN1.Text);
                checkBoxY1.Enabled = false;
                comboBoxDa1.Enabled = false;
                comboBoxMo1.Enabled = false;
                textBoxYear1.Enabled = false;
                textBoxifY1.Enabled = false;


            }
            else
            {

            }

            //WITHIN COUNTRY
            X.WriteLine();
            if (checkBoxY2.Checked)
            {
                checkBoxN2.Enabled = false;
                X.WriteLine(labelWithin1.Text + "" + checkBoxY2.Text);
                X.WriteLine(labelifY2.Text + " " + textBoxifY2.Text);

                string M2 = comboBoxMo2.SelectedItem.ToString();
                string D2 = comboBoxDa2.SelectedItem.ToString();
                X.WriteLine(labeldt2.Text + " " + M2 + " " + D2 + "," + textBoxYear2.Text);
            }
            else if (checkBoxN2.Checked)
            {
                checkBoxY2.Enabled = false;
                comboBoxDa2.Enabled = false;
                comboBoxMo2.Enabled = false;
                textBoxYear2.Enabled = false;
                textBoxifY2.Enabled = false;
                X.WriteLine(labelWithin1.Text + "" + checkBoxN2.Text);
            }
            else
            {

            }


            //SOCIAL EVENTS
            X.WriteLine();
            if (checkBoxY3.Checked)
            {
                checkBoxN3.Enabled = false;
                X.WriteLine(labelSocial1.Text + "" + checkBoxY3.Text);

                X.WriteLine(labelifY3.Text + " " + textBoxifY3.Text);
                string M3 = comboBoxMo3.SelectedItem.ToString();
                string D3 = comboBoxDa3.SelectedItem.ToString();
                X.WriteLine(labeldt3.Text + " " + M3 + " " + D3 + "," + textBoxYear3.Text);
            }
            else if (checkBoxN3.Checked)
            {
                checkBoxY3.Enabled = false;
                comboBoxDa3.Enabled = false;
                comboBoxMo3.Enabled = false;
                textBoxYear3.Enabled = false;
                textBoxifY3.Enabled = false;
                X.WriteLine(labelSocial1.Text + "" + checkBoxN3.Text);
            }
            else
            {

            }




            X.WriteLine();
            X.WriteLine("Exposure History:");

            //CONTACT COVID PATIENT
            if (checkBoxY4.Checked)
            {
                checkBoxN4.Enabled = false;
                X.WriteLine(labelCon1.Text + "" + checkBoxY4.Text);
            }
            else if (checkBoxN4.Checked)
            {
                checkBoxY4.Enabled = false;
                X.WriteLine(labelCon1.Text + "" + checkBoxN4.Text);
            }
            else
            {

            }

            //EXPOSED COVID VARIANT 
            if (checkBoxYes5.Checked)
            {
                checkBoxNo5.Enabled = false;
                checkBoxUnknown.Enabled = false;
                X.WriteLine(labelExp1.Text + "" + checkBoxY5.Text);
            }
            else if (checkBoxN5.Checked)
            {
                checkBoxY5.Enabled = false;
                checkBoxUnknown.Enabled = false;
                X.WriteLine(labelExp1.Text + "" + checkBoxN5.Text);
            }
            else if (checkBoxUnknown.Checked)
            {
                checkBoxY5.Enabled = false;
                checkBoxN5.Enabled = false;
                X.WriteLine(labelExp1.Text + "" + checkBoxUnknown.Text);
            }
            else
            {

            }

            //SYMPTOMATIC
            X.WriteLine();
            if (checkBoxY6.Checked)
            {
                checkBoxN6.Enabled = false;
                X.WriteLine(labelSymp1.Text + "" + checkBoxY6.Text);

                string M4 = comboBoxMo4.SelectedItem.ToString();
                string D4 = comboBoxDa4.SelectedItem.ToString();
                X.WriteLine(labeldt4.Text + " " + M4 + " " + D4 + "," + textBoxYear4.Text);
            }
            else if (checkBoxN6.Checked)
            {
                checkBoxY6.Enabled = false;
                comboBoxDa4.Enabled = false;
                comboBoxMo4.Enabled = false;
                textBoxYear4.Enabled = false;
                X.WriteLine(labelSymp1.Text + "" + checkBoxN6.Text);
            }
            else
            {

            }







            X.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Demographic prof
            textBoxName.Clear();
            textBoxAge.Clear();
            comboBoxMbday.ResetText();
            comboBoxDbday.ResetText();
            textBoxYbday.Clear();
            comboBoxSex.ResetText();
            textBoxCivil.Clear();
            textBoxNation.Clear();
            textBoxRel.Clear();
            textBoxHomeadd.Clear();
            textBoxBplace.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();

            //Nature of exposure
            checkBoxY1.Checked = false;
            checkBoxN1.Checked = false;
            textBoxifY1.Clear();
            comboBoxDa1.ResetText();
            comboBoxMo1.ResetText();
            textBoxYear1.Clear();

            checkBoxY2.Checked = false;
            checkBoxN2.Checked = false;
            checkBoxUnknown.Checked = false;
            textBoxifY2.Clear();
            comboBoxDa2.ResetText();
            comboBoxMo2.ResetText();
            textBoxYear2.Clear();

            checkBoxY3.Checked = false;
            checkBoxN3.Checked = false;
            textBoxifY3.Clear();
            comboBoxDa3.ResetText();
            comboBoxMo3.ResetText();
            textBoxYear3.Clear();

            checkBoxY4.Checked = false;
            checkBoxN4.Checked = false;

            checkBoxY5.Checked = false;
            checkBoxN5.Checked = false;

            checkBoxY6.Checked = false;
            checkBoxN6.Checked = false;

            comboBoxDa4.ResetText();
            comboBoxMo4.ResetText();
            textBoxYear4.Clear();

            checkBoxN1.Enabled = true;
            checkBoxY4.Enabled = true;
            checkBoxY1.Enabled = true;
            comboBoxDa1.Enabled = true;
            comboBoxMo1.Enabled = true;
            textBoxYear1.Enabled = true;
            textBoxifY1.Enabled = true;

            checkBoxN2.Enabled = true;
            checkBoxY4.Enabled = true;
            checkBoxY2.Enabled = true;
            comboBoxDa2.Enabled = true;
            comboBoxMo2.Enabled = true;
            textBoxYear2.Enabled = true;
            textBoxifY2.Enabled = true;

            checkBoxN3.Enabled = true;
            checkBoxY4.Enabled = true;
            checkBoxY3.Enabled = true;
            comboBoxDa3.Enabled = true;
            comboBoxMo3.Enabled = true;
            textBoxYear3.Enabled = true;
            textBoxifY3.Enabled = true;

            checkBoxN4.Enabled = true;
            checkBoxY4.Enabled = true;

            checkBoxN5.Enabled = true;
            checkBoxY5.Enabled = true;

            checkBoxN6.Enabled = true;
            checkBoxY6.Enabled = true;

            checkBoxY6.Enabled = true;
            comboBoxDa4.Enabled = true;
            comboBoxMo4.Enabled = true;
            textBoxYear4.Enabled = true;
        }

       
        }
    }
