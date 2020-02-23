using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class FileIO
    {
        public static int currFileNum = 0;  
        public FileIO()
        {

        }
        public FileIO(string first, string last, string username, string password, string experience, string goals)
        {
            WriteToFile(first, last, username, password, experience, goals);
        }
      
        private void WriteToFile(string first, string last, string username, string password, string experience, string goals)
        {
            string fileName = username + "'sFile.txt";
            string textToFile = currFileNum + "," + first + "," + last + "," + username + "," + password + "," + experience + "," + goals;
            File.WriteAllText(fileName, textToFile);
            currFileNum++;
        }
        public string RetreiveLevel(string username)
        {
            string fileName = username + "'sFile.txt";
            string content = File.ReadAllText(fileName);
            string[] splitContent = content.Split(',');
            return splitContent[5];
        }
        public bool CheckForFile(string username, string password)
        {
            string fileName = username + "'sFile.txt";
            if(File.Exists(fileName))
            {
                string content = File.ReadAllText(fileName);
                string[] splitContent = content.Split(',');
                if(password == splitContent[4])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
