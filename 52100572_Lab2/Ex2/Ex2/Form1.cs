namespace Ex2
{
    public partial class Form1 : Form
    {
        private DatatypeChecker _datatypeChecker = new DatatypeChecker();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            bool flag = true;

            _datatypeChecker.input = txt_int.Text;
            _datatypeChecker.datatype = new IsValidInteger();
            if (!_datatypeChecker.IsValidDatatype())
            {
                flag = false;
                MessageBox.Show("Invalid integer");
            }

            _datatypeChecker.input = txt_double.Text;
            _datatypeChecker.datatype = new IsValidDouble();
            if (!_datatypeChecker.IsValidDatatype())
            {
                flag = false;
                MessageBox.Show("Invalid double");
            }

            _datatypeChecker.input = txt_string.Text;
            _datatypeChecker.datatype = new IsValidString();
            if (!_datatypeChecker.IsValidDatatype())
            {
                flag = false;
                MessageBox.Show("Invalid string");
            }

            _datatypeChecker.input = txt_email.Text;
            _datatypeChecker.datatype = new IsValidEmail();
            if (!_datatypeChecker.IsValidDatatype())
            {
                flag = false;
                MessageBox.Show("Invalid email");
            }

            _datatypeChecker.input = txt_datetime.Text;
            _datatypeChecker.datatype = new IsValidDateTime();
            if (!_datatypeChecker.IsValidDatatype())
            {
                flag = false;
                MessageBox.Show("Invalid datetime");
            }

            if (flag)
            {
                MessageBox.Show("Saved");
            }
        }
    }
}