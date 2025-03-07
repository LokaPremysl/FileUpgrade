using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace FileCorrection
{
    public static class FileManager
    {
        public static void SeFileNames()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "ASCDL Files (*.ascdl)|*.ascdl|All Files (*.*)|*.*",
                Title = "Load file(s)"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string[] fileNames = openFileDialog.FileNames;

            foreach (string file in fileNames)
            {
                string fileToChange = string.Empty;
                using (FileStream loadByStream = File.Open(file, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(loadByStream))
                {
                    fileToChange = reader.ReadToEnd();
                }
                if (file.Contains("part"))
                {
                    fileToChange = RemoveHead(fileToChange);
                }
                else
                {
                    string pattern = @"VYKRES\S*";
                    fileToChange = Regex.Replace(fileToChange, pattern, "VYKRES,\"XPSX\",\"XADRESARX\",\"XCVX\"", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(100));
                }
                fileToChange = Regex.Replace(fileToChange, @"\w+\s*$", "", RegexOptions.IgnoreCase).Trim();
                SaveFile(file, fileToChange);
            }
        }

        static void SaveFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        static string RemoveHead(string text)
        {
            if (Regex.IsMatch(text, @"RAMECEK\b", RegexOptions.IgnoreCase))
            {
                text = Regex.Replace(text, @"^.*?\b\w*END\w*\b", "", RegexOptions.IgnoreCase | RegexOptions.Singleline).Trim();
            }
            return text;
        }
    }
}
