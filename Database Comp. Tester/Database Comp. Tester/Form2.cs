using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Database_Comp._Tester
{
    public partial class Login : Form
    {
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
            Students = Directory.GetFiles(StudentFolderPath);
            StudentInfo = new string[Students.Length, 3];
            GetStudentInfo();
            OpenDatabase();
        }
        void OpenDatabase()
        {
            StreamReader reader = new StreamReader(EventsPath);

            string[] Event = new string[2];
            Events = File.ReadAllText(EventsPath).Split(" ");
            if (File.Exists(EventsPath))
            {
                foreach (string events in reader.ReadLine().Split(" "))
                {
                    Event = events.Split("|");
                    //comboBox1.Items.Add(Event[0]);
                }
                reader.Close();

            }
        }
        Boolean CheckJson()
        {
            string test;

            for (int i = 0; i < Students.Length; i++)
            {
                test = Path.GetFileName(Students[i]);

                if (m_password + ".json" == test)
                {
                    return true;
                }

            }
            return false;
            //MessageBox.Show("User Does Not Exist! " + m_password, "Input Error"); ;

        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (CheckJson())
            {
                StudentEventTracker s = new StudentEventTracker(m_password);
                this.Hide();
                s.ShowDialog();
                this.Close();
            }
            else if(m_password == "123456")
            {
                Admin a = new Admin();
                this.Hide();
                a.ShowDialog();
                this.Close();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            CheckJson();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void InputTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void InputTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            TextBox textBox = (TextBox)sender;
            textBox.Focus();
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
                            passwordCheck();
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
                            passwordCheck();
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
                            passwordCheck();
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
                            passwordCheck();
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
                            passwordCheck();
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
                            passwordCheck();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        public String password()
        {
            m_password = InputTextBox1.Text + InputTextBox2.Text + InputTextBox3.Text + InputTextBox4.Text + InputTextBox5.Text + InputTextBox6.Text;
            return m_password;
        }
        public void passwordCheck()
        {
            if (m_password.Length >= 6) { CheckJson(); }
        }

        private void InputTextBox1_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InputTextBox6_TextChanged(object sender, EventArgs e)
        {
            password();
            passwordCheck();
        }

    }
}
