namespace DictionaryFlasher
{
    using System.Windows.Forms;

    public static class Save
    {
        public static void DoSave(string input, ref FolderBrowserDialog folderBrowserDialog)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            string path;
            if (result == DialogResult.OK)
            {
                 path = folderBrowserDialog.SelectedPath;
            }
            else
            {
                 return;
            }

            TypeSave("Blooket", Formatter.FormatInput(input, FormatType.Blooket), path);
            TypeSave("Form8", Formatter.FormatInput(input, FormatType.Form8), path);
            TypeSave("Form7", Formatter.FormatInput(input, FormatType.Form7), path);
            TypeSave("Quizlet", Formatter.FormatInput(input, FormatType.Quizlet), path);
        }

        /*static string? FindFolder(string path, string name)
        {
            try
            {
                foreach (string subdirectory in Directory.GetDirectories(path))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(subdirectory);
                    if (directoryInfo.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        return directoryInfo.FullName;
                    }

                    string? foundPath = FindFolder(subdirectory, name);
                    if (!string.IsNullOrEmpty(foundPath))
                    {
                        return foundPath;
                    }
                }
            }
            catch { }

            return null;
        }*/

        static async void TypeSave(string name, string data, string path)
        {
            if(path == null) { return; }
            try
            {
                string filePath = path + "\\" + name;
                if(Directory.Exists(filePath))
                {
                    filePath += "\\Week" + (Directory.GetFiles(path).Length + 1) + ".txt";
                }
                else
                {
                    Directory.CreateDirectory(filePath);
                    filePath += "\\Week1.txt";
                }

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    await sw.WriteAsync(@data);
                    sw.Close();
                }
            }
            catch { }
        }
    }
}
