using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManager1
{
    public partial class TextEditor : Form
    {
        string path;
       public string Content
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public TextEditor(string content,string path)
        {
            InitializeComponent();
            Content = content;
            this.path = path;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.SelectionStart = 0;
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
             File.WriteAllText(path, Content,Encoding.GetEncoding(1251));
            }
            catch
            {
                MessageBox.Show("Не вдалось зберегти текст");
            }
            
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Content = "";
        }

        private void ToUpToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            int start=textBox1.SelectionStart;
            int lenght=textBox1.SelectionLength;
            string firstPart = textBox1.SelectedText.ToUpper();
            string secondPart=Content.Substring(start+lenght);
            Content = Content.Substring(0, start) + firstPart + secondPart;
        }

        private void ToDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int start = textBox1.SelectionStart;
            int lenght = textBox1.SelectionLength;
            string firstPart = textBox1.SelectedText.ToLower();
            string secondPart = Content.Substring(start + lenght);
            Content = Content.Substring(0, start) + firstPart + secondPart;
        }

        public void AutoCorrectionWords()
        {
            string file = File.ReadAllText(@"D:\ListWords.txt");
            string[] list = file.Split(new Char[]{ ' ' });
        }
        public string SelectWord(string word,string[]list)
        {
            string result = "";
            int minDif=word.Length;
            for (int i = 0; i < list.Length;i++)
            {
                int dif = 0;
                for(int j=0;j<word.Length;j++)
                {

                }

            }

                return result;
        }
    }
}
