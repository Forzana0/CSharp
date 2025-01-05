using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileManagerApp
{
    public partial class MainForm : Form
    {
        private Stack<string> backStack = new Stack<string>();
        private Stack<string> forwardStack = new Stack<string>();

        public MainForm()
        {
            InitializeComponent();
            InitializeFileManager();
        }

        private void InitializeFileManager()
        {
            LoadDirectory("C:\\");
        }

        private void LoadDirectory(string path)
        {
            try
            {
                txtPath.Text = path;

                var directories = Directory.GetDirectories(path);
                var files = Directory.GetFiles(path);

                listBox.Items.Clear();

                listBox.Items.Add(".."); 
                listBox.Items.AddRange(directories.Cast<string>().ToArray());
                listBox.Items.AddRange(files.Cast<string>().ToArray());

                forwardStack.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити директорію: {ex.Message}");
            }
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = listBox.SelectedItem.ToString();

            if (selectedItem == "..")
            {
                string currentPath = txtPath.Text;
                string parentDirectory = Directory.GetParent(currentPath)?.FullName;

                if (!string.IsNullOrEmpty(parentDirectory))
                {
                    backStack.Push(currentPath);
                    LoadDirectory(parentDirectory);
                }
            }
            else if (Directory.Exists(selectedItem)) 
            {
                backStack.Push(txtPath.Text);
                LoadDirectory(selectedItem); 
            }
            else 
            {
                OpenFile(selectedItem);
            }
        }

        private void OpenFile(string filePath)
        {
            try
            {
                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".txt" || fileExtension == ".log")
                {
                    string fileContent = File.ReadAllText(filePath);
                    MessageBox.Show(fileContent, "Вміст файлу");
                }
                else
                {
                    MessageBox.Show("Цей тип файлу не підтримується для перегляду.", "Помилка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося відкрити файл: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (backStack.Count > 0)
            {
                string currentPath = txtPath.Text;
                forwardStack.Push(currentPath);
                string previousPath = backStack.Pop();
                LoadDirectory(previousPath);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (forwardStack.Count > 0)
            {
                string currentPath = txtPath.Text;
                backStack.Push(currentPath);
                string nextPath = forwardStack.Pop();
                LoadDirectory(nextPath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox.SelectedItem.ToString();

            try
            {
                if (Directory.Exists(selectedItem))
                {
                    Directory.Delete(selectedItem, true);
                }
                else if (File.Exists(selectedItem))
                {
                    File.Delete(selectedItem);
                }

                LoadDirectory(txtPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося видалити: {ex.Message}");
            }
        }
    }
}
