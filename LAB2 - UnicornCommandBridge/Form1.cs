﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LAB2___UnicornCommandBridge
{

    public partial class Form1 : Form
    {


        public static List<Student> students = new List<Student>();

        public static List<Teacher> teachers = new List<Teacher>();

        public static List<Kurs> kurser = new List<Kurs>();

        public static List<Uppgift> uppgifter = new List<Uppgift>();

        public Form1()
        {
            InitializeComponent();

            List<string> teachA = new List<string>();
            foreach (Teacher t in teachers)
            {
                teachA.Add(t.ToString());
            }

            List<string> teachB = new List<string>();
            foreach (Teacher t in teachers)
            {
                teachB.Add(t.ToString());
            }

            List<string> studA = new List<string>();
            foreach (Student s in students)
            {
                studA.Add(s.ToString());
            }

            List<string> studB = new List<string>();
            foreach (Student s in students)
            {
                studB.Add(s.ToString());
            }

            // Lägger in studenter i listan
            students.Add(new Student("S100", "Anders"));
            students.Add(new Student("S101", "Börje"));
            students.Add(new Student("S102", "Uffe"));
            students.Add(new Student("S103", "Koffe"));
            students.Add(new Student("S104", "Fredrik"));
            students.Add(new Student("S105", "Johanes"));
            students.Add(new Student("S106", "Louise"));

            // Lägger in lärare i listan
            Teacher Roger = new Teacher("T100", "Roger");
            teachers.Add(Roger);
            Teacher Lisa = new Teacher("T101", "Lisa");
            teachers.Add(Lisa);
            teachers.Add(new Teacher("T102", "Erik"));
            teachers.Add(new Teacher("T103", "Pelle"));
            teachers.Add(new Teacher("T104", "Johan"));
            teachers.Add(new Teacher("T105", "Magnus"));
            teachers.Add(new Teacher("T106", "Moa"));
            teachers.Add(new Teacher("T107", "Lena"));

            // Lägger in kurser i listan
            Kurs Sys = new Kurs("SysAdm", "System administation", Roger.ToString(), teachA, studA);
            kurser.Add(Sys);

            Kurs Web = new Kurs("WebDes", "WebbDesign", Lisa.ToString(), teachB, studB);
            kurser.Add(Web);

            // Lägger till Uppgifter i listan
            uppgifter.Add(new Uppgift("U100", "HTML - Lab1", "Lång uppgiftsbeskrivning om HTML - Lab1 med sammor av text", "WebDes"));
            uppgifter.Add(new Uppgift("U101", "Vattenfallsmetoden Lab1", "Lång uppgiftsbeskrivning om uppgiften med vattenvallsmetoden Lab1", "SysAd"));


        }

        private void btnSkapaStudent_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan mata in en ny student.
            Form2_Create skapaStudentLarare = new Form2_Create();
            skapaStudentLarare.ShowDialog();
        }

        private void btnSkapaLarare_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan mata in en ny stedent.  
            Form2_Create skapaStudentLarare = new Form2_Create();
            skapaStudentLarare.ShowDialog();
        }

        private void btnSkapaKurs_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan lägga in en ny kurs.
            KursForm laggTillKurs = new KursForm();
            laggTillKurs.ShowDialog();
        }

        private void btnSkapaUppgift_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan skapa en uppgift. 
            FormUppgift laggTillUppgift = new FormUppgift();
            laggTillUppgift.ShowDialog();
        }

        private void btnRedigeraStudent_Click(object sender, EventArgs e)
        {
            //Knappen öppnar menyn för att redigera lärare och studenter. 
            FormRedStudentLarare redStudentEllerLarare = new FormRedStudentLarare();
            redStudentEllerLarare.ShowDialog();
        }

        private void btnRedigeraLarare_Click(object sender, EventArgs e)
        {

        }

        private void btnRedigeraKurs_Click(object sender, EventArgs e)
        {
            //Knappen öppnar menyn för att redigera en kurs. 
            FormRedigeraKurs redigeraKurs = new FormRedigeraKurs();
            redigeraKurs.ShowDialog();
        }

        private void btnRedigeraUppgift_Click(object sender, EventArgs e)
        {
            FormRedigeraUppgift redigeraUppgift = new FormRedigeraUppgift();
            redigeraUppgift.ShowDialog();
        }

        private void btnSattaBetyg_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan sätta betyg på en uppgift. 
            FormSattaBetyg sattaBetyg = new FormSattaBetyg();
            sattaBetyg.ShowDialog();
        }

        private void btnRedigeraBetyg_Click(object sender, EventArgs e)
        {
            //Knapp för att komma till redigera betyg formuläret.
            FormRedigeraBetyg redigeraBetyg = new FormRedigeraBetyg();
            redigeraBetyg.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Easter egg.
            MessageBox.Show("Unicorns unite!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
