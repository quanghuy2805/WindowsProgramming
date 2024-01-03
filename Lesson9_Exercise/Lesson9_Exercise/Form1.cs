using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson9_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.studentdatabase' table. You can move, or remove it, as needed.
            this.studentdatabaseTableAdapter.Fill(this.studentDBDataSet.studentdatabase);
            {
                var db = new StudentDBEntities1();
                var select = from s in db.studentdatabases select s;
                String st = "";
                foreach (var item in select)
                {
                    st = st + "ID: " + item.StudentID.ToString() + System.Environment.NewLine;
                    st = st + "Name: " + item.StudentName.ToString() +
                    System.Environment.NewLine;
                    st = st + "Gender: " + item.StudentGender.ToString() +
                    System.Environment.NewLine;
                    st = st + "Address: " + item.StudentAddress.ToString() + System.Environment.NewLine;
                }
                this.textBox1.Text = st;
                
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            {
                var db = new StudentDBEntities1();
                studentdatabase aStudent;
                aStudent = db.studentdatabases.Where(d => d.StudentID == 5).First() as studentdatabase;
                aStudent.StudentName = "Nguyen Van Linh";
                db.SaveChanges();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var db = new StudentDBEntities1();
            studentdatabase aStudent;
            if (db.studentdatabases.Find(5) == null)
            {
                aStudent = new studentdatabase();
                aStudent.StudentID = 5;
                aStudent.StudentName = "Nguyen Tri Dung";
                aStudent.StudentGender = "Male";
                aStudent.StudentAddress = " 11 Le Lai";
                db.studentdatabases.Add(aStudent);
                db.SaveChanges();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var db = new StudentDBEntities1();
            studentdatabase aStudent;
            aStudent = db.studentdatabases.Where(d => d.StudentID == 5).First() as studentdatabase;
            db.studentdatabases.Remove(aStudent);
            db.SaveChanges();
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            using (StudentDBEntities1 db = new StudentDBEntities1())
            {
                studentdatabase aStudent;
                // add
                aStudent = new studentdatabase();
                aStudent.StudentID = 5;
                aStudent.StudentName = "Nguyen Tri Dung";
                aStudent.StudentGender = "Male";
                aStudent.StudentAddress = " 11 Le Lai";
                db.studentdatabases.Add(aStudent);
                // update
                aStudent = db.studentdatabases.Where(d => d.StudentID == 3).First() as studentdatabase;
                aStudent.StudentName = "Nguyen Van Linh";
                //delete
                aStudent = db.studentdatabases.Where(d => d.StudentID == 3).First() as studentdatabase;
                db.studentdatabases.Remove(aStudent);
                db.SaveChanges();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
