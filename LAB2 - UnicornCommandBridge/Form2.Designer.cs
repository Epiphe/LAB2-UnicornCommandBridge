﻿namespace LAB2___UnicornCommandBridge
{
    partial class Form2_Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ElevNamn = new System.Windows.Forms.TextBox();
            this.labelNamn = new System.Windows.Forms.Label();
            this.label_uniktId = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TeacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ElevNamn
            // 
            this.ElevNamn.Location = new System.Drawing.Point(67, 35);
            this.ElevNamn.Name = "ElevNamn";
            this.ElevNamn.Size = new System.Drawing.Size(227, 20);
            this.ElevNamn.TabIndex = 0;
            this.ElevNamn.TextChanged += new System.EventHandler(this.textBoxLaggTillNamn_TextChanged);
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(14, 38);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(38, 13);
            this.labelNamn.TabIndex = 1;
            this.labelNamn.Text = "Namn:";
            // 
            // label_uniktId
            // 
            this.label_uniktId.AutoSize = true;
            this.label_uniktId.Location = new System.Drawing.Point(14, 64);
            this.label_uniktId.Name = "label_uniktId";
            this.label_uniktId.Size = new System.Drawing.Size(49, 13);
            this.label_uniktId.TabIndex = 3;
            this.label_uniktId.Text = "Unikt ID:";
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(67, 61);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(227, 20);
            this.StudentID.TabIndex = 2;
            this.StudentID.TextChanged += new System.EventHandler(this.textBoxLaggTillId_TextChanged);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 230);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 4;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(219, 87);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 5;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Spara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unikt ID:";
            // 
            // TeacherID
            // 
            this.TeacherID.Location = new System.Drawing.Point(67, 180);
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.Size = new System.Drawing.Size(227, 20);
            this.TeacherID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Namn:";
            // 
            // TeacherName
            // 
            this.TeacherName.Location = new System.Drawing.Point(67, 154);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(227, 20);
            this.TeacherName.TabIndex = 6;
            this.TeacherName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ny student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ny lärare";
            // 
            // Form2_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeacherID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.label_uniktId);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.labelNamn);
            this.Controls.Add(this.ElevNamn);
            this.Name = "Form2_Create";
            this.Text = "Lägga till";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ElevNamn;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label label_uniktId;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeacherID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TeacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}