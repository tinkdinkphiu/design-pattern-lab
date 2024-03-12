using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abstract_factory
{
    public partial class Edit : Form
    {
        private Student _student;
        private StudentRepository _studentRepo;

        public Edit(Student student, StudentRepository studentRepo)
        {
            InitializeComponent();

            _student = student;
            _studentRepo = studentRepo;

            txt_EditMSSV.Text = student.MSSV;
            txt_EditFullname.Text = student.FullName;
            txt_EditBirthDate.Text = student.BirthDate?.ToString("dd-MM-yyyy");
            txt_EditStudentClass.Text = student.StudentClass;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            _student.MSSV = txt_EditMSSV.Text;
            _student.FullName = txt_EditFullname.Text;
            _student.BirthDate = DateTime.ParseExact(txt_EditBirthDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            _student.StudentClass = txt_EditStudentClass.Text;

            _studentRepo.UpdateStudent(_student);

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
