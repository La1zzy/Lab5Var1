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

namespace Lab5Var1Task2
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;

        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                fileWayTextBox.Text = selectedFilePath;
                DisplayFileInfo(selectedFilePath);
            }
        }

        private void DisplayFileInfo(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);

                string fileName = fileInfo.Name;
                long fileSize = fileInfo.Length;
                DateTime lastModified = fileInfo.LastWriteTime;

                richTextBox1.Text = $"File name: {fileName}\nSize: {fileSize} byte\nLast edited by: {lastModified}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving file information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
        }
    }
}

