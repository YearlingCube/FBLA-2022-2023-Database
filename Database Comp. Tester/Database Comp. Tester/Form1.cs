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

            if (File.Exists(EventsPath))
            {
                foreach (string events in reader.ReadLine().Split(" "))
                {
                    comboBox1.Items.Add(events);
                }
            }
        }

        void CheckJson()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (InputTextBox.Text == (string)Students[i])
                {
                    ReadJson(StudentFolderPath + "//" + Students[i], Students[i]);
                }
            }
            
        }
        void ReadJson(string path, string studentID)
        {
            string[] FileContents = Array.Empty<string>();
            StreamReader reader = new StreamReader(path);

            FileContents = reader.ReadToEnd();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CheckJson();
        }
    }
}