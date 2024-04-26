using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterStudentPictureOverloading
{
    public partial class Form1 : Form
    {
        Image i;
        Bitmap b;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                i = Image.FromFile(dialog.FileName);
                b = (Bitmap)i;
                pictureBox1.Image = b;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string firstName = textBox2.Text;
                string middleName = textBox3.Text;
                string lastName = textBox1.Text;
                string dateOfBirth = comboBox3.Text + " / " + comboBox1.Text + " / " + comboBox2.Text;
                string program = comboBox4.Text;
                bool hasMiddleName = !string.IsNullOrEmpty(middleName);

                if (female.Checked)
                {
                    StudentInfo(firstName, lastName, "female", dateOfBirth, program);
                }
                else if (male.Checked)
                {
                    StudentInfo(firstName, lastName, "Male", dateOfBirth, program);
                }
                else if (String.IsNullOrEmpty(dateOfBirth))
                {
                    StudentInfo(firstName, lastName, program);
                }
                else if (String.IsNullOrEmpty(middleName) || (String.IsNullOrEmpty(dateOfBirth)))
                    StudentInfo(firstName, lastName, program, hasMiddleName);
                }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int days = 1; days <= 31; days++)
            {
                comboBox1.Items.Add(days);
            }
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                comboBox2.Items.Add(year);
            }
            string[] months = {"January", "February", "March", "April", "May", "June",
                               "July", "August", "September", "October", "November", "December"};

            ArrayList course = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string month in months)
            {
                comboBox3.Items.Add(month);
            }

            foreach (string programs in course)
            {
                comboBox4.Items.Add(programs);
            }
        }
        private void StudentInfo(string firstName, string lastName, string gender, string dateOfBirth, string program)
        {
            MessageBox.Show("Student Name: " + firstName + " " + lastName + "\nGender: " + gender + "\nDate Of Birth: " + dateOfBirth + "\nProgram: " + program);
        }

        private void StudentInfo(string firstName, string lastName, string program)
        {
            MessageBox.Show("Student Name: " + firstName + " " + lastName + "\nProgram: " + program);
        }

        private void StudentInfo(string firstName, string lastName, string program, bool hasMiddleName)
        {
            if (hasMiddleName)
            {
                MessageBox.Show("Student Name: " + firstName + " " + lastName + "\nProgram: " + program);
            }
            else
            {
                MessageBox.Show("Student Name: " + firstName + " " + lastName + "\nProgram: " + program);
            }
        }
    }

    }
