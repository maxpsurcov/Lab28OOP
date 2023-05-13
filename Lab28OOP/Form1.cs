using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;


namespace Lab28OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDirectoryButton_Click(object sender, EventArgs e)
        {

            string directoryPath = DirectoryPathTextBox.Text;

            if (Directory.Exists(directoryPath))
            {
                MessageBox.Show("Каталог вже існує!");
            }
            else
            {
                Directory.CreateDirectory(directoryPath);
                MessageBox.Show("Каталог створено!");
            }
        }

        private void MoveDirectoryButton_Click(object sender, EventArgs e)
        {
            string sourceDirectoryPath = SourceDirectoryPathTextBox.Text;
            string destinationDirectoryPath = DestinationDirectoryPathTextBox.Text;

            if (Directory.Exists(sourceDirectoryPath))
            {
                Directory.Move(sourceDirectoryPath, destinationDirectoryPath);
                MessageBox.Show("Каталог переміщено!");
            }
            else
            {
                MessageBox.Show("Каталог не існує!");
            }
        }

        private void CopyDirectoryButton_Click(object sender, EventArgs e)
        {
            string sourceDirectoryPath = SourceDirectoryPathTextBox.Text;
            string destinationDirectoryPath = DestinationDirectoryPathTextBox.Text;

            if (Directory.Exists(sourceDirectoryPath))
            {
                Directory.CreateDirectory(destinationDirectoryPath);
                foreach (string file in Directory.GetFiles(sourceDirectoryPath))
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(destinationDirectoryPath, fileName);
                    File.Copy(file, destFile, true);
                }
                MessageBox.Show("Каталог скопійовано!");
            }
            else
            {
                MessageBox.Show("Каталог не існує!");
            }
        }

        private void DeleteDirectoryButton_Click(object sender, EventArgs e)
        {
            string directoryPath = DirectoryPathTextBox.Text;

            if (Directory.Exists(directoryPath))
            {
                Directory.Delete(directoryPath, true);
                MessageBox.Show("Каталог видалено!");
            }
            else
            {
                MessageBox.Show("Каталог не існує!");
            }
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextBox.Text;

            if (File.Exists(filePath))
            {
                MessageBox.Show("Файл вже існує!");
            }
            else
            {
                File.Create(filePath).Close();
                MessageBox.Show("Файл створено!");
            }
        }

        private void MoveFileButton_Click(object sender, EventArgs e)
        {
            string sourceFilePath = SourceFilePathTextBox.Text;
            string destinationFilePath = DestinationFilePathTextBox.Text;

            if (File.Exists(sourceFilePath))
            {
                File.Move(sourceFilePath, destinationFilePath);
                MessageBox.Show("Файл переміщено!");
            }
            else
            {
                MessageBox.Show("Файл не існує!");
            }
        }

        private void CopyFileButton_Click(object sender, EventArgs e)
        {
            string sourceFilePath = SourceFilePathTextBox.Text;
            string destinationFilePath = DestinationFilePathTextBox.Text;

            if (File.Exists(sourceFilePath))
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
                MessageBox.Show("Файл скопійовано!");
            }
            else
            {
                MessageBox.Show("Файл не існує!");
            }
        }

        private void DeleteFileButton_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextBox.Text;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                MessageBox.Show("Файл видалено!");
            }
            else
            {
                MessageBox.Show("Файл не існує!");
            }
        }

        private void EditAttributesButton_Click(object sender, EventArgs e)
        {
            string path = EditAttributesPathTextBox.Text;

            if (Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                directoryInfo.Attributes = GetAttributes();
                MessageBox.Show("Атрибути каталогу змінено!");
            }
            else if (File.Exists(path))
            {
                FileInfo fileInfo = new FileInfo(path);
                fileInfo.Attributes = GetAttributes();
                MessageBox.Show("Атрибути файлу змінено!");
            }
            else
            {
                MessageBox.Show("Шлях не існує!");
            }
        }
        private FileAttributes GetAttributes()
        {
            FileAttributes attributes = 0;

            if (ReadOnlyCheckBox.Checked)
            {
                attributes |= FileAttributes.ReadOnly;
            }

            if (HiddenCheckBox.Checked)
            {
                attributes |= FileAttributes.Hidden;
            }

            if (SystemCheckBox.Checked)
            {
                attributes |= FileAttributes.System;
            }

            if (ArchiveCheckBox.Checked)
            {
                attributes |= FileAttributes.Archive;
            }
            if (NormalCheckBox.Checked)
            {
                attributes |= FileAttributes.Normal;
            }

            if (TemporaryCheckBox.Checked)
            {
                attributes |= FileAttributes.Temporary;
            }

            if (OfflineCheckBox.Checked)
            {
                attributes |= FileAttributes.Offline;
            }

            if (CompressedCheckBox.Checked)
            {
                attributes |= FileAttributes.Compressed;
            }

            if (EncryptedCheckBox.Checked)
            {
                attributes |= FileAttributes.Encrypted;
            }

            if (NotContentIndexedCheckBox.Checked)
            {
                attributes |= FileAttributes.NotContentIndexed;
            }

            return attributes;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            string filePath = EditFileTextBox.Text;

            if (File.Exists(filePath))
            {
                EditFileTextBox.Enabled = false;
                OpenFileButton.Enabled = false;
                SaveFileButton.Enabled = true;
                CancelButton.Enabled = true;
                EditFileTextBox.ReadOnly = true;

                StreamReader streamReader = new StreamReader(filePath);
                EditFileTextBox.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
            else
            {
                MessageBox.Show("Файл не існує!");
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            string filePath = EditFileTextBox.Text;

            StreamWriter streamWriter = new StreamWriter(filePath);
            streamWriter.Write(EditFileTextBox.Text);
            streamWriter.Close();

            MessageBox.Show("Файл збережено!");
            EditFileTextBox.Enabled = true;
            OpenFileButton.Enabled = true;
            SaveFileButton.Enabled = false;
            CancelButton.Enabled = false;
            EditFileTextBox.ReadOnly = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            string filePath = EditFileTextBox.Text;

            StreamReader streamReader = new StreamReader(filePath);
            EditFileTextBox.Text = streamReader.ReadToEnd();
            streamReader.Close();

            EditFileTextBox.Enabled = true;
            OpenFileButton.Enabled = true;
            SaveFileButton.Enabled = false;
            CancelButton.Enabled = false;
            EditFileTextBox.ReadOnly = false;
        }

        private void CompressFileButton_Click(object sender, EventArgs e)
        {
            string sourceFilePath = CompressFilePathTextBox.Text;
            string archiveFilePath = CompressArchivePathTextBox.Text;

            if (File.Exists(sourceFilePath))
            {
                if (File.Exists(archiveFilePath))
                {
                    MessageBox.Show("Архів уже існує!");
                }
                else
                {
                    ZipFile.CreateFromDirectory(sourceFilePath, archiveFilePath);
                    MessageBox.Show("Файл заархівовано!");
                }
            }
            else
            {
                MessageBox.Show("Файл не існує!");
            }
        }

        private void ExtractFileButton_Click(object sender, EventArgs e)
        {
            string archiveFilePath = ExtractArchivePathTextBox.Text;
            string destinationDirectoryPath = ExtractDirectoryPathTextBox.Text;

            if (File.Exists(archiveFilePath))
            {
                if (Directory.Exists(destinationDirectoryPath))
                {
                    ZipFile.ExtractToDirectory(archiveFilePath, destinationDirectoryPath);
                    MessageBox.Show("Файл розархівовано!");
                }
                else
                {
                    MessageBox.Show("Каталог не існує!");
                }
            }
            else
            {
                MessageBox.Show("Файл не існує!");
            }
        }
        public static class FileManager
        {
            public static void Copy(string sourcePath, string destinationPath)
            {
                if (File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, destinationPath);
                }
                else if (Directory.Exists(sourcePath))
                {
                    CopyDirectory(sourcePath, destinationPath);
                }
                else
                {
                    throw new FileNotFoundException("Файл або каталог не існує!", sourcePath);
                }
            }
        }
        private static void CopyDirectory(string sourcePath, string destinationPath)
        {
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            string[] files = Directory.GetFiles(sourcePath);

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destinationFilePath = Path.Combine(destinationPath, fileName);
                File.Copy(file, destinationFilePath);
            }

            string[] directories = Directory.GetDirectories(sourcePath);

            foreach (string directory in directories)
            {
                string directoryName = Path.GetFileName(directory);
                string destinationDirectoryPath = Path.Combine(destinationPath, directoryName);
                CopyDirectory(directory, destinationDirectoryPath);
            }
        }

        public static void Move(string sourcePath, string destinationPath)
        {
            if (File.Exists(sourcePath))
            {
                File.Move(sourcePath, destinationPath);
            }
            else if (Directory.Exists(sourcePath))
            {
                MoveDirectory(sourcePath, destinationPath);
            }
            else
            {
                throw new FileNotFoundException("Файл або каталог не існує!", sourcePath);
            }
        }

        private static void MoveDirectory(string sourcePath, string destinationPath)
        {
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            string[] files = Directory.GetFiles(sourcePath);

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destinationFilePath = Path.Combine(destinationPath, fileName);
                File.Move(file, destinationFilePath);
            }

            string[] directories = Directory.GetDirectories(sourcePath);

            foreach (string directory in directories)
            {
                string directoryName = Path.GetFileName(directory);
                string destinationDirectoryPath = Path.Combine(destinationPath, directoryName);
                MoveDirectory(directory, destinationDirectoryPath);
            }

            Directory.Delete(sourcePath);
        }

        public static void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else if (Directory.Exists(path))
            {
                DeleteDirectory(path);
            }
            else
            {
                throw new FileNotFoundException("Файл або каталог не існує!", path);
            }
        }

        private static void DeleteDirectory(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                File.Delete(file);
            }

            string[] directories = Directory.GetDirectories(path);

            foreach (string directory in directories)
            {
                DeleteDirectory(directory);
            }

            Directory.Delete(path);
        }
        public static class ZipManager
        {
            public static void CreateArchive(string archivePath, string directoryPath)
            {
                ZipFile.CreateFromDirectory(directoryPath, archivePath);
            }

            public static void ExtractArchive(string archivePath, string extractPath)
            {
                ZipFile.ExtractToDirectory(archivePath, extractPath);
            }

            public static void AddFileToArchive(string archivePath, string filePath)
            {
                using (FileStream fileStream = new FileStream(archivePath, FileMode.OpenOrCreate))
                {
                    using (ZipArchive archive = new ZipArchive(fileStream, ZipArchiveMode.Update))
                    {
                        string entryName = Path.GetFileName(filePath);
                        ZipArchiveEntry entry = archive.CreateEntry(entryName);
                        using (FileStream fileStreamToZip = new FileStream(filePath, FileMode.Open))
                        using (Stream zipStream = entry.Open())
                        {
                            fileStreamToZip.CopyTo(zipStream);
                        }
                    }
                }
            }

            public static void RemoveFileFromArchive(string archivePath, string fileName)
            {
                using (FileStream fileStream = new FileStream(archivePath, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(fileStream, ZipArchiveMode.Update))
                    {
                        ZipArchiveEntry entry = archive.GetEntry(fileName);
                        if (entry != null)
                        {
                            entry.Delete();
                        }
                    }
                }
            }
        }
    }
}