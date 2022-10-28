using System;
using System.Collections;
using System.IO;
using System.Json;
using System.Text.Json;

namespace Database_Comp._Tester
{
    public partial class Form1 : Form
    {
        string DatabasePath = Directory.GetCurrentDirectory() + "\\Students.json";
        ArrayList Students = new ArrayList();

        int DatabasePos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenDatabase();

        }
        void OpenDatabase()
        {
            StreamReader reader = new StreamReader(DatabasePath);

            if (File.Exists(DatabasePath))
            {
                for (int i = 0; i < reader.Peek(); i++)
                {

                    Students[i] = reader.ReadLine();
                }
            }
            else
            {
                File.Create(DatabasePath);
            }
        }

        void CheckJson()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (InputTextBox.Text == (string)Students[i])
                {
                    OutputLabel.Text = (string)Students[i];
                }
            }
            File.WriteAllText(DatabasePath, JsonSerializer.Serialize(InputTextBox.Text));
        }
        void ReadJson(int line)
        {
            //StreamReader reader = new StreamReader(DatabasePath);

            //int pos = 0;
            //while (reader.Peek() > -1)
            //{
            //    Sentences[pos] = reader.ReadLine();
            //    pos++;
            //}



            //OutputTextBox.Text = Sentences[line].ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CheckJson();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            //if (Sentences.Count> DatabasePos)
            //    ReadJson(DatabasePos++);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (DatabasePos >0)
                ReadJson(DatabasePos--);
        }
    }
}