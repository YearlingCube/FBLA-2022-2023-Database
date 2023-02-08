using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Json;
using System.Net.Http.Json;
using System.Text.Json;

namespace Database_Comp._Tester
{
    public partial class StudentEventTracker : Form
    {

        string StudentFolderPath = Directory.GetCurrentDirectory() + "\\Students\\";
        string EventsPath = Directory.GetCurrentDirectory() + "\\Events.json";
        string[] Students = Array.Empty<string>();
        string[] Events = Array.Empty<string>();
        string m_password;
        string[,] StudentInfo;

        int DatabasePos = 0;
        public StudentEventTracker()
        {
            InitializeComponent();
        }
        public void CheckInput()
        {
            if (InputTextBox1.TextLength > 0 && InputTextBox2.TextLength > 0 && InputTextBox3.TextLength > 0 && InputTextBox4.TextLength > 0 && InputTextBox5.TextLength > 0 && InputTextBox6.TextLength > 0)
            {
                AddButton.Enabled = true;
                AddButton.BackColor = Color.Cyan;
            }
            else
            {
                AddButton.Enabled = false;
                AddButton.BackColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Students = Directory.GetFiles(StudentFolderPath);
            StudentInfo = new string[3, Students.Length];
            GetStudentInfo();
            OpenDatabase();
            Leaderboard();

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
                    comboBox1.Items.Add(Event[0]);
                }
                reader.Close();
                
            }
        }
        void CheckJson()
        {
            string test;

            for (int i = 0; i < Students.Length; i++)
            {
                test = Path.GetFileName(Students[i]);
                if (m_password + ".json" == test)
                {
                    ReadJson(Students[i], m_password);
                    MessageBox.Show("Points Redeemed!");
                    return;
                }

            }
            MessageBox.Show("User Does Not Exist! " + m_password, "Input Error"); ;

        }
        void ReadJson(string path, string studentID)
        {
            string[] FileContents = new string[5];
            string[] jsonContents = new string[4];
            string[] Event = new string[2];
            int counter = 0;

            // Read File
            // Convert Json Lines Into Readable lines   
            jsonContents = File.ReadAllLines(path);
            for (int i = 0; i < 5; i++)
            {
                FileContents[i] = JsonSerializer.Deserialize<String>(jsonContents[i]);
            }
            //FileContents = File.ReadAllLines(path);
            for (int i = 0; i < Events.Length; i++)
            {
                Event = Events[i].Split("|");
                if (Event[0] == comboBox1.SelectedItem.ToString())
                {
                    FileContents[3] = (int.Parse(FileContents[3]) + int.Parse(Event[1])).ToString();
                    FileContents[4] += " " + Event[0];
                }
                // Convert Normal Text Into Json Then Push To File
                //string jsonString
                for (int j = 0; j < 5; j++)
                {
                    jsonContents[j] = JsonSerializer.Serialize(FileContents[j]);
                }
                File.WriteAllLines(path, jsonContents);
                GetStudentInfo();
                Leaderboard();
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

        private void InputTextBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        public void Leaderboard()
        {
            //string[,] studentData = new string[3, 3] { {"Thomas", "50", "11" },{"Aaron", "37", "11" },{"Chris","1","12" } };

            leaderboardDataGridView.ColumnCount = 3;
            leaderboardDataGridView.Columns[0].Name = "Name";
            leaderboardDataGridView.Columns[1].Name = "Points";
            leaderboardDataGridView.Columns[2].Name = "Grade";
            for (int i = 0; i < StudentInfo.GetLength(0); i++)
            {
                leaderboardDataGridView.Rows.Add();
                for (int j = 0; j < StudentInfo.GetLength(1); j++)
                {
                    leaderboardDataGridView[j,i].Value = StudentInfo[i, j];
                }
            }
                    leaderboardDataGridView.Sort(leaderboardDataGridView.Columns["Points"], ListSortDirection.Descending);
        }
    }
}