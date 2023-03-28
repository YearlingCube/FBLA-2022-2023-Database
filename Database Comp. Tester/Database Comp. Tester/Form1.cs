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

        string StudentFolderPath = Directory.GetCurrentDirectory() + "\\IDS\\";
        string EventsPath = Directory.GetCurrentDirectory() + "\\Events.json";
        string[] Students = Array.Empty<string>();
        string[] Events = Array.Empty<string>();
        string m_password;
        string[,] StudentInfo;

        int DatabasePos = 0;
        public StudentEventTracker(string password)
        {
            InitializeComponent();
            m_password = password;
        }
        //public void CheckInput()
        //{
        //    if (InputTextBox1.TextLength > 0 && InputTextBox2.TextLength > 0 && InputTextBox3.TextLength > 0 && InputTextBox4.TextLength > 0 && InputTextBox5.TextLength > 0 && InputTextBox6.TextLength > 0)
        //    {
        //        AddButton.Enabled = true;
        //        AddButton.BackColor = Color.Cyan;
        //    }
        //    else
        //    {
        //        AddButton.Enabled = false;
        //        AddButton.BackColor = Color.Black;
        //    }
        //}

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

            int index = Array.FindIndex(Events, row => row.Contains(comboBox1.Text));
            Event = Events[index].Split("|");
            if (FileContents[4].Contains(Event[0]))
            {
                MessageBox.Show("Student Has Already Been To Event!");
                return;
            }
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
            MessageBox.Show("Points Redeemed!");
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
                if (m_password == FileContents[2])
                {
                    this.Text = FileContents[0];
                }
                StudentInfo[i, 0] = FileContents[0];
                StudentInfo[i, 2] = FileContents[1];
                StudentInfo[i, 1] = FileContents[3];
            }
        }

        public void Leaderboard()
        {
            //string[,] studentData = new string[3, 3] { {"Thomas", "50", "11" },{"Aaron", "37", "11" },{"Chris","1","12" } };
            leaderboardDataGridView.Rows.Clear();
            leaderboardDataGridView.ColumnCount = 3;
            leaderboardDataGridView.Columns[0].Name = "Name";
            leaderboardDataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            leaderboardDataGridView.Columns[1].Name = "Points";
            leaderboardDataGridView.Columns[2].Name = "Grade";

            int studentPoints = 0;
            for (int i = 0; i < StudentInfo.GetLength(0); i++)
            {
                leaderboardDataGridView.Rows.Add();
                for (int j = 0; j < StudentInfo.GetLength(1); j++)
                {
                    if (int.TryParse(StudentInfo[i, j], out studentPoints))
                    {
                        leaderboardDataGridView[j, i].Value = int.Parse(StudentInfo[i, j]);

                    }
                    else
                    {
                        leaderboardDataGridView[j, i].Value = StudentInfo[i, j];
                    }

                }
            }
            leaderboardDataGridView.Sort(leaderboardDataGridView.Columns["Points"], ListSortDirection.Descending);
            leaderboardDataGridView.ClearSelection();
        }
        private void StudentEventTracker_Load(object sender, EventArgs e)
        {
            Students = Directory.GetFiles(StudentFolderPath);
            StudentInfo = new string[Students.Length, 3];
            GetStudentInfo();
            OpenDatabase();
            Leaderboard();
        }

        private void returnButton_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void MinimizeBox_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                CheckJson();
            }
            else
            {
                MessageBox.Show("Please Select an Event");
            }
        }
    }
}