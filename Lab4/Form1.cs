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
using System.Diagnostics;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public List<string> List { get; set; } = new List<string>();

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            // open file dialog
            var fileDialog = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Текстовые файлы (*.txt)|*.txt"
            };
            fileDialog.ShowDialog();
            if (fileDialog.FileName == "")
            {
                return;
            }

            var time = new Stopwatch();
            time.Start();

            // reading
            using (var sr = new StreamReader(fileDialog.FileName, Encoding.UTF8))
            {
                var text = sr.ReadToEnd();
                foreach (var word in text.Split())
                {
                    if (!List.Contains(word))
                    {
                        List.Add(word);
                    }
                }
            }
            time.Stop();

            // send result time to textbox
            var result = time.Elapsed.TotalMilliseconds;
            labelRead.Text = result.ToString();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            var time = new Stopwatch();
            time.Start();
            if (List.Contains(textBox2.Text))
            {
                listBox.BeginUpdate();
                listBox.Items.Add(textBox2.Text);
                listBox.EndUpdate();
            }
            time.Stop();

            var result = time.Elapsed.TotalMilliseconds;
            labelFind.Text = result.ToString();
        }
    }
}
