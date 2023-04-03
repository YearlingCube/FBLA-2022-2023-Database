// Matthew - Thomas - Aaron
// Login Form
// This Is The Student Form. Allows Students To Add The Event They Have Been Too
using System.ComponentModel;
using System.Text.Json;

namespace Database_Comp._Tester
{
    public partial class StudentEventTracker : Form
    {
        // Creating Variables
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

        void OpenDatabase()
        {
            // Open Event File
            StreamReader reader = new StreamReader(EventsPath);

            string[] Event = new string[2];
            Events = File.ReadAllText(EventsPath).Split(" ");
            
            // Splits Events Into Events Array
            if (File.Exists(EventsPath))
            {
                foreach (string events in reader.ReadLine().Split(" "))
                {
                    Event = events.Split("|");
                    comboBox1.Items.Add(Event[0]);
                }
                // Closes Event File
                reader.Close();

            }
        }
        void CheckJson()
        {
            string test;

            // Checks If Student Number Exists
            for (int i = 0; i < Students.Length; i++)
            {
                test = Path.GetFileName(Students[i]);

                if (m_password + ".json" == test)
                {
                    ReadJson(Students[i], m_password);
                    return;
                }

            }

            // Password Doesnt Exist
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
            // Finds Event In .json 
            int index = Array.FindIndex(Events, row => row.Contains(comboBox1.Text));
            Event = Events[index].Split("|");
            if (FileContents[4].Contains(Event[0]))
            {
                // Student Has Aleady Been To Event
                selectEventLabel.Text = "Student Has Already Been To Event!";
                selectEventLabel.ForeColor = Color.Red;
                selectEventLabel.Visible = true;
                selectEventTimer.Start();
                return;
            }
            if (Event[0] == comboBox1.SelectedItem.ToString())
            {
                // Adds Event And Points To File
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
            selectEventLabel.Text = "Points Redeemed!";
            selectEventLabel.ForeColor = Color.Green;
            selectEventLabel.Visible = true;
            selectEventTimer.Start();
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

                // Sets Student Info to File Info
                StudentInfo[i, 0] = FileContents[0];
                StudentInfo[i, 2] = FileContents[1];
                StudentInfo[i, 1] = FileContents[3];
            }
        }

        public void Leaderboard()
        {
            // Creates Leaderboard
            leaderboardDataGridView.Rows.Clear();
            leaderboardDataGridView.ColumnCount = 3;
            leaderboardDataGridView.Columns[0].Name = "Name";
            leaderboardDataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            leaderboardDataGridView.Columns[1].Name = "Points";
            leaderboardDataGridView.Columns[2].Name = "Grade";

            int studentPoints = 0;
            // Updates Information In leaderboard
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
            // Sorts & Clears Leaderboard Selection
            leaderboardDataGridView.Sort(leaderboardDataGridView.Columns["Points"], ListSortDirection.Descending);
            leaderboardDataGridView.ClearSelection();
        }
        private void StudentEventTracker_Load(object sender, EventArgs e)
        {
            // Form Load
            Students = Directory.GetFiles(StudentFolderPath);
            StudentInfo = new string[Students.Length, 3];
            GetStudentInfo();
            OpenDatabase();
            Leaderboard();
        }

        private void returnButton_Click_1(object sender, EventArgs e)
        {
            // Opens New Form And Closes The Old One
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void MinimizeBox_Click_1(object sender, EventArgs e)
        {
            // Minimize Button
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            // Exit Button
            Close();
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            // Checks If Event Dropdown is Empty
            if (comboBox1.Text != "")
            {
                CheckJson();
            }
            else
            {
                // Gives User Error
                selectEventLabel.Text = "Please Select an Event";
                selectEventLabel.ForeColor = Color.Red;
                selectEventLabel.Visible = true;
                selectEventTimer.Start();
            }
        }

        private void selectEventTimer_Tick(object sender, EventArgs e)
        {
            selectEventLabel.Visible = false;
        }
    }
}