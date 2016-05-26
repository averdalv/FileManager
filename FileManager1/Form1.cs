using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using System.Xml;
using System.IO;

namespace FileManager1
{
    public partial class FileManager : Form
    {

        string[] drives;
        int activeListView;
        Presenter presenter;
        public FileManager()
        {

            InitializeComponent();
            presenter = new Presenter(this);
            listView1.SmallImageList = imageList1;
            listView2.SmallImageList = imageList1;
            
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            listView2.MouseDoubleClick += listView2_MouseDoubleClick;
            listView1.Enter += listView1_Enter;
            listView2.Enter += listView2_Enter;
            drives = Environment.GetLogicalDrives();
            for(int i=0;i<drives.Length;i++)
            {
                comboBox1.Items.Add(drives[i]);
                comboBox2.Items.Add(drives[i]);
            }
            comboBox1.Text = drives[0];
            comboBox2.Text = drives[0];
            presenter.refresh(listView1, @drives[0]);
            presenter.refresh(listView2, @drives[0]);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string path = drives[comboBox2.SelectedIndex];

            try
            {
                presenter.refresh(listView2, path);
                presenter.CurrentPath2 = path;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Даний диск не працює");
                comboBox1.Text = drives[0];
                path = @"C:\";
                presenter.refresh(listView2, path);
                presenter.CurrentPath2 = path;
            }
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string path = drives[comboBox1.SelectedIndex];
           
            try
            {
                presenter.refresh(listView1, path); 
                presenter.CurrentPath1 = path;
            }
            catch(IOException ex) 
            {
                MessageBox.Show("Даний диск не працює");
                comboBox1.Text = drives[0];
                path = @"C:\";
                presenter.refresh(listView1, path);
                presenter.CurrentPath1 = path;
            }
        }

        void listView2_Enter(object sender, EventArgs e)
        {
            activeListView = 2;
        }

        void listView1_Enter(object sender, EventArgs e)
        {
            activeListView = 1;
        }
     

        void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            presenter.openItem(listView1,true);
        }
        void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            presenter.openItem(listView2,false);
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeListView == 1)
                {
                    if (listView1.SelectedItems.Count > 0)
                    {
                        presenter.addToBuffer(listView1, true);
                    }
                }
                else
                    if (listView2.SelectedItems.Count > 0)
                    {
                        presenter.addToBuffer(listView2, false);
                    }

            }
            catch
            {
                MessageBox.Show("Помилка при копіюванні");
            }
        }

        private void MoveMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeListView == 1)
                {
                    if (listView1.SelectedItems.Count > 0)
                    {
                        presenter.Move(listView1,true);
                    }
                }
                else
                    if (listView2.SelectedItems.Count > 0)
                        presenter.Move(listView2, false);
            }
            catch(IOException ex)
            {
                MessageBox.Show("Переміщення в дочірню директорію неможливе");
            }
            catch
            {
                MessageBox.Show("Помилка при переміщенні");
            }
            finally
            {
                presenter.refresh(listView1, presenter.CurrentPath1);
                presenter.refresh(listView2, presenter.CurrentPath2);
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeListView == 1)
                {
                    if (listView1.SelectedItems.Count > 0)
                    {
                        presenter.Delete(listView1,true);
                    }
                }
                else
                    if (listView2.SelectedItems.Count > 0)
                        presenter.Delete(listView2,false);
                
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні");
            }
            finally
            {
                presenter.refresh(listView1, presenter.CurrentPath1);
                presenter.refresh(listView2, presenter.CurrentPath2);
            }
        }

        private void buttonBack1_Click(object sender, EventArgs e)
        {
            presenter.Back(listView1, true);
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            presenter.Back(listView2, false);
        }

        private void buttonRefresh1_Click(object sender, EventArgs e)
        {
            presenter.refresh(listView1, presenter.CurrentPath1);
        }

        private void buttonRefresh2_Click(object sender, EventArgs e)
        {
            presenter.refresh(listView2, presenter.CurrentPath2);
        }
        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeListView == 1)
                        presenter.Paste(listView1, true);
                else
                        presenter.Paste(listView2, false);

            }
                catch(IOException ex)
            {
                MessageBox.Show("Переміщення в дочірню директорію неможливе");
            }
            catch
            {
                MessageBox.Show("Помилка при вставці");
            }
            finally
            {
                presenter.refresh(listView1, presenter.CurrentPath1);
                presenter.refresh(listView2, presenter.CurrentPath2);
            }
        }

        private void buttonAddFolder1_Click(object sender, EventArgs e)
        {
            presenter.CreateNewFolder(true);
            presenter.refresh(listView1, presenter.CurrentPath1);
            presenter.refresh(listView2, presenter.CurrentPath2);
        }

        private void buttonAddFile1_Click(object sender, EventArgs e)
        {
            presenter.CreateNewFile(true);
            presenter.refresh(listView1, presenter.CurrentPath1);
            presenter.refresh(listView2, presenter.CurrentPath2);
        }

        private void buttonAddFolder2_Click(object sender, EventArgs e)
        {
            presenter.CreateNewFolder(false);
            presenter.refresh(listView1, presenter.CurrentPath1);
            presenter.refresh(listView2, presenter.CurrentPath2);
        }

        private void buttonAddFile2_Click(object sender, EventArgs e)
        {
            presenter.CreateNewFile(false);
            presenter.refresh(listView1, presenter.CurrentPath1);
            presenter.refresh(listView2, presenter.CurrentPath2);
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Vlad Reva 2015");
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.refreshWithExtension(listView1, presenter.CurrentPath1, "txt");
            presenter.refreshWithExtension(listView2, presenter.CurrentPath2, "txt");
        }

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.refreshWithExtension(listView1, presenter.CurrentPath1, "xml");
            presenter.refreshWithExtension(listView2, presenter.CurrentPath2, "xml");
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.refreshWithExtension(listView1, presenter.CurrentPath1, "html");
            presenter.refreshWithExtension(listView2, presenter.CurrentPath2, "html");
        }

        private void SelectTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeListView == 1)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    presenter.SelectSentenses(listView1, true);
                }
            }
            else
                if (listView2.SelectedItems.Count > 0)
                    presenter.SelectSentenses(listView2, false);
        }

        private void MoveDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeListView == 1)
            {
                    presenter.MoveToDirectory(listView1, true);
            }
            else
                    presenter.MoveToDirectory(listView2, false);
            
                presenter.refresh(listView1, presenter.CurrentPath1);
                presenter.refresh(listView2, presenter.CurrentPath2);
        }
        
      }
   }
