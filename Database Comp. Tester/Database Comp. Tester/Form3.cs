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
            leaderboardDataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            leaderboardDataGridView.Columns[2].Name = "Grade";
            leaderboardDataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;

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
        }

        private void DrawRandomBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int RandomNumber;
            RandomNumber = r.Next(0, StudentInfo.Length / 3);
            MessageBox.Show("Student's Name : " + StudentInfo[RandomNumber, 0] + "\nStudent's Grade : " + StudentInfo[RandomNumber, 2]);
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }
    }
}
