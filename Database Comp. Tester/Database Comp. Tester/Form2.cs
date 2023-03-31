// Matthew - Thomas - Aaron
// Login Form
// This Form is a Login Form to Allow Students & Admin To Login
using System.Text.Json;

namespace Database_Comp._Tester
{
    public partial class Login : Form
    {   
        // Declares Variables
        string StudentFolderPath = Directory.GetCurrentDirectory() + "\\IDS\\";
        string EventsPath = Directory.GetCurrentDirectory() + "\\Events.json";
        string[] Students = Array.Empty<string>();
        string[] Events = Array.Empty<string>();
        string m_password;
        string[,] StudentInfo;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Declaring Student Info
            Students = Directory.GetFiles(StudentFolderPath);
            StudentInfo = new string[Students.Length, 3];

            // Starts Basic Methods
            GetStudentInfo();
            OpenDatabase();
        }
        void OpenDatabase()
        {
            // Opens Event File
            StreamReader reader = new StreamReader(EventsPath);

            string[] Event = new string[2];
            
            Events = File.ReadAllText(EventsPath).Split(" ");
            
            // Checks If File Exist & If It Does It Reads and Splits The Lines Into The Event Array
            if (File.Exists(EventsPath))
            {
                foreach (string events in reader.ReadLine().Split(" "))
                {
                    Event = events.Split("|");
                }
                // Closes File
                reader.Close();

            }
        }
        Boolean CheckJson()
        {
            string test;

            // Checks Students For The Password
            for (int i = 0; i < Students.Length; i++)
            {
                test = Path.GetFileName(Students[i]);

                if (m_password + ".json" == test)
                {
                    return true;
                }

            }
            return false;

        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            // Admin Login
            if (m_password == "123456")
            {
                Admin a = new Admin();
                this.Hide();
                a.ShowDialog();
                this.Close();
            }
            // Student Login
            else if (CheckJson())
            {
                StudentEventTracker s = new StudentEventTracker(m_password);
                this.Hide();
                s.ShowDialog();
                this.Close();
            }
            // Nothing Found
            else if (!CheckJson())
            {
                incorrectLoginLabel.Visible = true;
                incorrectLoginTimer.Start();
            }
        }
        void GetStudentInfo()
        {
            string[] FileContents = new string[5];
            string[] jsonContents = new string[4];
            // Read File
            // Convert Json Lines Into Readable lines   
            for (int i = 0; i < Students.Length; i++)
            {
                jsonContents = File.ReadAllLines(Students[i]);
                for (int j = 0; j < 4; j++)
                {
                    FileContents[j] = JsonSerializer.Deserialize<String>(jsonContents[j]);
                }
                StudentInfo[i, 0] = FileContents[0];
                StudentInfo[i, 2] = FileContents[1];
                StudentInfo[i, 1] = FileContents[3];
            }
        }

        #region KeyPress
        private void InputTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            TextBox textBox = (TextBox)sender;
            textBox.Focus();
            
            // Each Time You Type It Switches And Combines Them Into The Password
            switch (textBox.Name)
            {

                case "InputTextBox1":
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        password();
                    }
                    else
                    {
                        if (char.IsDigit(e.KeyChar))
                        {
                            InputTextBox2.Focus();
                            password();
                        }
                    }
                    break;
                case "InputTextBox2":
                    if (e.KeyChar == (char)Keys.Back && InputTextBox2.TextLength == 0)
                    {
                        InputTextBox1.Focus();
                        password();
                    }
                    else
                    {
                        if (char.IsDigit(e.KeyChar))
                        {
                            InputTextBox3.Focus();
                            password();
                        }
                    }
                    break;
                case "InputTextBox3":
                    if (e.KeyChar == (char)Keys.Back && InputTextBox3.TextLength == 0)
                    {
                        InputTextBox2.Focus();
                        password();
                    }
                    {
                        if (char.IsDigit(e.KeyChar))
                        {
                            InputTextBox4.Focus();
                            password();
                        }
                    }
                    break;
                case "InputTextBox4":
                    if (e.KeyChar == (char)Keys.Back && InputTextBox4.TextLength == 0)
                    {
                        InputTextBox3.Focus();
                        password();
                    }
                    {
                        if (char.IsDigit(e.KeyChar))
                        {
                            InputTextBox5.Focus();
                            password();
                        }
                    }
                    break;
                case "InputTextBox5":
                    if (e.KeyChar == (char)Keys.Back && InputTextBox5.TextLength == 0)
                    {
                        InputTextBox4.Focus();
                        password();
                    }
                    else
                    {
                        if (char.IsDigit(e.KeyChar))
                        {
                            InputTextBox6.Focus();
                            password();
                        }
                    }
                    break;
                case "InputTextBox6":
                    if (e.KeyChar == (char)Keys.Back && InputTextBox6.TextLength == 0)
                    {
                        InputTextBox5.Focus();
                        password();
                    }
                    else
                    {
                        if (char.IsDigit(e.KeyChar))
                        {
                            enterButton.Focus();
                            password();
                        }
                    }
                    break;
                default:
                    break;
            }

            // Login
            if (e.KeyChar == (char)Keys.Return)
            {
                enterButton_Click(sender, e);
            }
            // Closes Form
            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }
        #endregion
        public String password()
        {
            // Combines Password Digits
            m_password = InputTextBox1.Text + InputTextBox2.Text + InputTextBox3.Text + InputTextBox4.Text + InputTextBox5.Text + InputTextBox6.Text;
            return m_password;
        }

        private void InputTextBox6_TextChanged(object sender, EventArgs e)
        {
            password();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeBox_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            incorrectLoginLabel.Visible = false;
            incorrectLoginTimer.Stop();
        }
    }
}
