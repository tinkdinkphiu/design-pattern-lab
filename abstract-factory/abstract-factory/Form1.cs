using System.Globalization;

namespace abstract_factory
{
    public partial class Form1 : Form
    {
        private StudentRepository _studentRepo;

        public Form1()
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService();

            _studentRepo = new StudentRepository(dbService.Factory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            List<Student> students = _studentRepo.GetStudents();

            foreach (Student student in students)
            {
                dataGridView1.Rows.Add(student.MSSV, student.FullName, student.BirthDate?.ToString("dd/MM/yyyy"), student.StudentClass);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MSSV.Text) || string.IsNullOrEmpty(txt_Fullname.Text) || string.IsNullOrEmpty(txt_BirthDate.Text) || string.IsNullOrEmpty(txt_StudentClass.Text))
            {
                MessageBox.Show("All fields must be filled in");
                return;
            }

            DateTime birthDate;
            if (!DateTime.TryParseExact(txt_BirthDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                MessageBox.Show("Birth date invalid. Format dd/MM/yyyy");
                return;
            }

            Student newStudent = new Student
            {
                MSSV = txt_MSSV.Text,
                FullName = txt_Fullname.Text,
                BirthDate = birthDate,
                StudentClass = txt_StudentClass.Text
            };

            try
            {
                _studentRepo.AddStudent(newStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
                return;
            }

            txt_MSSV.Text = "";
            txt_Fullname.Text = "";
            txt_BirthDate.Text = "";
            txt_StudentClass.Text = "";

            Form1_Load(sender, e);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string mssv = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    _studentRepo.DeleteStudent(mssv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student:" + ex.Message);
                    return;
                }

                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a student to delete");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string mssv = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string fullname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string birthDate = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string studentClass = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                Student student = new Student
                {
                    MSSV = mssv,
                    FullName = fullname,
                    BirthDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    StudentClass = studentClass
                };

                Edit editForm = new Edit(student, _studentRepo);
                editForm.ShowDialog();

                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a student to edit");
            }
        }
    }
}
