using System;
using System.Collections;
using System.IO;
using System.Json;
using System.Text.Json;

namespace Database_Comp._Tester
{
    public partial class Form1 : Form
    {
        string StudentFolderPath = Directory.GetCurrentDirectory() + "\\Students\\";
        string EventsPath = Directory.GetCurrentDirectory() + "\\Events.json";
        string[] Students = Array.Empty<string>();
        string[] Events = Array.Empty<string>();

        int DatabasePos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Students = Directory.GetFiles(StudentFolderPath);
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
                if (InputTextBox.Text + ".json" == test)
                {
                    ReadJson(Students[i], InputTextBox.Text);
                    return;
                }

            }
            MessageBox.Show("User Does Not Exist!", "Input Error");

        }
        void ReadJson(string path, string studentID)
        {
            string[] FileContents = Array.Empty<string>();
            string[] Event = new string[2];
            int counter = 0;

            
                FileContents = File.ReadAllLines(path);
            for (int i = 0; i < Events.Length; i++)
            {
                Event = Events[i].Split("|");
                if (Event[0] == comboBox1.SelectedItem.ToString())
                {
                    FileContents[2] = (int.Parse(FileContents[2]) + int.Parse(Event[1])).ToString();
                    FileContents[3] += " " + Event[0];
                }
                File.WriteAllLines(path, FileContents);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CheckJson();
        }
    }
}