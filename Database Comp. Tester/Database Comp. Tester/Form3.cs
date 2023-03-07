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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Database_Comp._Tester
{
    public partial class Admin : Form
    {
        string StudentFolderPath = Directory.GetCurrentDirectory() + "\\IDS\\";
        string EventsPath = Directory.GetCurrentDirectory() + "\\Events.json";
        string[] Students = Array.Empty<string>();
        string[] Events = Array.Empty<string>();
        string m_password;
        string[,] StudentInfo;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Students = Directory.GetFiles(StudentFolderPath);
            StudentInfo = new string[Students.Length, 3];
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
                    //comboBox1.Items.Add(Event[0]);
                }
                reader.Close();

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

        private void DrawRandomBtn_Click(object sender, EventArgs e)
        {
            int points = 0;
            // Random Student in School
            Random r = new Random();
            int RandomNumber = 0;
            bool randStudentPicked = false;
            while (!randStudentPicked)
            {
                RandomNumber = r.Next(0, StudentInfo.Length / 3);
                if (int.Parse(StudentInfo[RandomNumber, 1]) > 0)
                {
                    randStudentPicked = true;
                }

            }

            // Random Student From Each Grade
            bool Freshmen = false;
            bool Sophmore = false;
            bool Junior = false;
            bool Senior = false;
            int[] RandomStudents = new int[4];
            int number = 0;
            int grade = 0;

            int studentsPicked = 0;
            while (studentsPicked < 4)
            {
                number = r.Next(0, StudentInfo.Length / 3);
                grade = int.Parse(StudentInfo[number, 2]);
                points = int.Parse(StudentInfo[number, 1]);
                if (points == 0)
                {
                    continue;
                }
                if (grade == 9 && !Freshmen)
                {
                    if (!RandomStudents.Contains<int>(number))
                    {
                        RandomStudents[0] = number;
                        Freshmen = true;
                        studentsPicked++;
                    }

                }
                else if (grade == 10 && !Sophmore)
                {
                    if (!RandomStudents.Contains<int>(number))
                    {
                        RandomStudents[1] = number;
                        Sophmore = true;
                        studentsPicked++;
                    }
                }
                else if (grade == 11 && !Junior)
                {
                    if (!RandomStudents.Contains<int>(number))
                    {
                        RandomStudents[2] = number;
                        Junior = true;
                        studentsPicked++;
                    }
                }
                else if (grade == 12 && !Senior)
                {
                    if (!RandomStudents.Contains<int>(number))
                    {
                        RandomStudents[3] = number;
                        Senior = true;
                        studentsPicked++;
                    }
                }


            }


            // Display MessageBox of Students
            MessageBox.Show("Random Student From Entire School :\nStudent's Name : " + StudentInfo[RandomNumber, 0] + "\nStudent's Grade : " + StudentInfo[RandomNumber, 2] + " ($10 Cafeteria Gift Card)"
                + "\n\nRandom Student From Each Grade :"
                + "\nFreshmen Student : " + StudentInfo[RandomStudents[0], 0] + " (Free Boulder Creek Shirt)"
                + "\nSophmore Student : " + StudentInfo[RandomStudents[1], 0] + " (Free Boulder Creek Shirt)"
                + "\nJunior Student : " + StudentInfo[RandomStudents[2], 0] + " (Free Boulder Creek Shirt)"
                + "\nSenior Student : " + StudentInfo[RandomStudents[3], 0] + " (Free Boulder Creek Shirt)"
                + "\n\nHighest Point Winner : " + leaderboardDataGridView[0, 0].Value + " ($50 Chipotle Gift Card)");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void MinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
