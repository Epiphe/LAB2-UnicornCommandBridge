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

    public partial class FormSattaBetyg : Form
    {
        
        public FormSattaBetyg()
        {
            InitializeComponent();
            foreach (Student stud in Form1.students)
            {
                comboBox1.Items.Add(stud.användarId + "," + stud.namn); 
            }
                      

            foreach (Uppgift upp in Form1.uppgifter)
            {
                comboBox2.Items.Add(upp.uppgiftsID + ", " + upp.uppgiftsNamn);
            }

            textBox1.MaxLength = 1;

          
        }
       

        private void FormSattaBetyg_Load(object sender, EventArgs e)
        {

        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            //Knapp för att spara betyg.

            string kurs = comboBox2.SelectedItem.ToString().Substring(0, 4);
            string bet = textBox1.Text.ToString(); 
            foreach (Student stud in Form1.students)
            {
                       
                if (stud.användarId == comboBox1.SelectedItem.ToString().Substring(0, 4))
                {

                    stud.betyg.Add(kurs + " " + bet);
                    Close();
                }
            }
            
            //Inte färdig, behöver utökas. 
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Döljer förntret och går tillbaka till huvudmenyn. 
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combobox för att välja student. Här ska en lista med studenter finnas. 
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combobox för att välja uppgift. Här ska en lista med tillgängliga uppgifter finnas. 

        }
    }
}
