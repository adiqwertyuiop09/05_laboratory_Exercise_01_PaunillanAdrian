using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stream
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

            string[] ListOfProgram = new string[]
            {
                "BS Computer Science",
                "BS Information Technology",
                "BS Information Systems",
                "BS Software Engineering",
                "BS Data Science",
                "BS Cybersecurity",
                "BS Multimedia Arts",
                "BS Game Development",
                "BS Electronics Engineering",
                "BS Computer Engineering",
                "BS Civil Engineering",
                "BS Mechanical Engineering",
                "BS Architecture",
                "BS Nursing",
                "BS Accountancy"
            };

            for (int i = 0; i < 15; i++)
            {
                programcombo.Items.Add(ListOfProgram[i]);
            }

            string[] ListOfGender = new string[] {
                "Male",
                "Female"
                
            };

            for (int i = 0; i < 2; i++) { 
                gendercombo.Items.Add(ListOfGender[i]);
            }
        }

        private void nxtbtn_Click(object sender, EventArgs e)
        {
            String studentNumber = studtxt.Text;
            String program = programcombo.Text;
            String firstName = fntxt.Text;
            String lastName = lntxt.Text;
            String middleName = mntxt.Text;
            String birthday = dtpicker.Value.ToString("yyyy-MM-dd");
            String age = agetxt.Text;
            String contactNo = cntxt.Text;
            String gender = gendercombo.Text;

            String relativePath = @"..\..\Paunillan, Adrian R.";
            String docPath = Path.GetFullPath(relativePath);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, studentNumber + ".txt")))
            {
                outputFile.WriteLine("Student Number: " + studentNumber);               
                outputFile.WriteLine("Full Name: " + lastName + ", " + firstName + ", " + middleName);
                outputFile.WriteLine("Program: " + program);
                outputFile.WriteLine("Gender: " + gender);
                outputFile.WriteLine("Age: " + age);
                outputFile.WriteLine("Birthday: " + birthday);
                outputFile.WriteLine("Contact No. " + contactNo);
            }
            MessageBox.Show("Registered Successfully!");
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
