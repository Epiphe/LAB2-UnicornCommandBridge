﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2___UnicornCommandBridge
{
    public partial class FormUppgift : Form
    {
        public FormUppgift()
        {
            InitializeComponent();
            textBoxUppgiftsID.MaxLength = 4;



            foreach (Kurs kurs in Form1.kurser)
            {
                comboBox1.Items.Add(kurs);
            }
        }

        private void FormUppgift_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSparaUppgift_Click(object sender, EventArgs e)
        {
            //Spara ny uppgift.

            string uppgiftsID = textBoxUppgiftsID.Text;
            string uppgiftsNamn = textBoxUppgiftsnamn.Text;
            string kursID = comboBox1.SelectedItem.ToString();
            string beskrivning = richTextBoxUppgiftsBeskrivning.Text;
            bool OK = true;

            foreach (Uppgift upp in Form1.uppgifter)
            {
                //Går igenom alla studenter och letar upp den som ska ändras via användarID som den hittar i substring(0,4) Hmm funkar bara sålänge man inte får fler än 999 studenter men i det här programmet får det vara.
                if (upp.uppgiftsID == textBoxUppgiftsID.Text.ToString().Substring(0, 4))
                {
                    
                    OK = false;

                    Close();
                }
            }

            if (uppgiftsID.Equals(""))
            {
                MessageBox.Show("Skriv ett uppgifts ID");
            }
            else if (kursID.Length < 4)
            {
                MessageBox.Show("Uppgifts ID måste vara 4 tecken");
            }
            
            else if (OK == false)
            {
                MessageBox.Show("Det ID:et finns redan");
            }
            
            else if (beskrivning.Equals(""))
            {
                MessageBox.Show("Skriv en beskrivning");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("Uppgifts ID: " + uppgiftsID + "\nNamn: " + uppgiftsNamn + "\nKurs: " + kursID + "\nBeskrivning: \n" + beskrivning, "Stämmer detta?", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {
                    Close();
                }
                else if (Svar == DialogResult.Yes)
                {
                    //Lägger till den nya uppgiften i listan i FORM1.
                    Form1.uppgifter.Add(new Uppgift(uppgiftsID, uppgiftsNamn, beskrivning, kursID));
                    Close();

                }

            }
            

        }


        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Tar dig tillbaka till huvudmenyn.
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxUppgiftsID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
