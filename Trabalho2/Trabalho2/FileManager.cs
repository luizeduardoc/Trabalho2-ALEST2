using System;
using System.Collections.Generic;
using System.IO;

namespace Trabalho2
{
    public class FileManager
    {
        private const string TEST_CASE_NAME = "caso1.txt";
        private const string TEST_CASE_FOLDER = "\\TestCases\\";
        private string filePath;
        private List<string> fileContent;

        public FileManager()
        {
            fileContent = new List<string>();
            filePath = BuildFilePath();
            ReadFile(filePath);
        }

        private string BuildFilePath()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var rootDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName;
            var testCasesDiretory = rootDirectory + TEST_CASE_FOLDER;
            return testCasesDiretory + TEST_CASE_NAME;
        }

        private List<string> ReadFile(string filePath)
        {            
            string line;
            StreamReader file = new StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                fileContent.Add(line);
            }

            return fileContent;
        }

        public List<string> GetTestCase()
        {
            return fileContent;
        }
    }
}
