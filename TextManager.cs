using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Менеджер_контактів
{
    internal class CsvFileManager
    {
        private static CsvFileManager? _instance;
        private static readonly object lockObject = new object();
        private readonly string filePath = "accounts.csv";
        private readonly char separator = ',';

        private CsvFileManager()
        {
            InitializeCsvFile();
        }

        public static CsvFileManager GetInstance()
        {
            lock (lockObject)
            {
                if (_instance == null)
                {
                    _instance = new CsvFileManager();
                }
                return _instance;
            }
        }

        private void InitializeCsvFile()
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Імʼя, Прізвище, Мобільний телефон, Робочий телефон");
                }
            }
        }
        

        public List<string> Read()
        {
            List<string> contacts = new(); 

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    contacts.Add(reader.ReadLine());
                }
            }

            return contacts;
        }

        public void DeleteRow(int index)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            if (index >= 0 && index < lines.Count)
            {
                lines.RemoveAt(index);
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        public void AddRow(string[] rowData)
        {
            if (rowData.Length != 4)
            {
                throw new ArgumentException("Invalid number of data elements provided. Expected 4 elements.");
            }

            string line = string.Join(separator.ToString(), rowData);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);
            }
        }
    }
}
