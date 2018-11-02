using SVGConverter_BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVGConverter
{
    public partial class SvgConverterForm : Form
    {
        //ObservableCollection<SvgFile> svgFiles;
        BindingList<SvgFile> svgFiles;
        BindingSource source;

        public SvgConverterForm()
        {
            InitializeComponent();
            //svgFiles = new ObservableCollection<SvgFile>();
            svgFiles = new BindingList<SvgFile>();
            source = new BindingSource(svgFiles, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            string dirName;
            // Список файлов
            FileInfo[] files;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                svgFiles.Clear();
                
                dirName= folderBrowserDialog1.SelectedPath;
                txtbFolder.Text = dirName;

                if (chckbSubDir.Checked)
                {
                    files = new DirectoryInfo(dirName).GetFiles("*.svg", SearchOption.AllDirectories);
                }
                else
                {
                    files = new DirectoryInfo(dirName).GetFiles("*.svg", SearchOption.TopDirectoryOnly);
                }

                if (files.Length>0)
                {
                    foreach (var item in files)
                    {
                        svgFiles.Add(new SvgFile(item.FullName));
                    }
                }
                dgvSvgFiles.DataSource = null;
                //dgvSvgFiles.DataSource = svgFiles;
                dgvSvgFiles.DataSource = source;

                for (int i = 0; i < dgvSvgFiles.Columns.Count; i++)
                {

                    string str = dgvSvgFiles.Columns[i].HeaderText;

                    switch (str)
                    {
                        case "SvgFileName":
                            dgvSvgFiles.Columns[i].HeaderText = "Имя файла";
                            break;
                        case "SvgFullFileName":
                            dgvSvgFiles.Columns[i].HeaderText = "Полный путь";
                            break;
                        case "Status":
                            dgvSvgFiles.Columns[i].HeaderText = "Статус";
                            break;
                    }
                }

                //dgvSvgFiles.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

                for (int i = 0; i < dgvSvgFiles.Columns.Count ; i++)
                {
                    dgvSvgFiles.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                

                //for (int i = 0; i < dgvSvgFiles.Columns.Count - 1; i++)
                //{
                //    dgvSvgFiles.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //}
                //dgvSvgFiles.Columns[dgvSvgFiles.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //for (int i = 0; i < dgvSvgFiles.Columns.Count; i++)
                //{
                //    int colw = dgvSvgFiles.Columns[i].Width;
                //    dgvSvgFiles.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //    dgvSvgFiles.Columns[i].Width = colw;
                //}

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Converter converter;
            if (svgFiles.Count>0)
            {
                converter = new Converter();
                converter.CharngeAttributesInFiles(svgFiles, chckbDataChanging.Checked, chckbDataChange.Checked);
                //foreach (SvgFile item in svgFiles)
                //{
                //    item.StatusWork();
                //    Task.Delay(3000).Wait(); 
                //    //Thread.Sleep(3000);
                //    item.StatusReady();
                //}
                MessageBox.Show("Преобразование файлов завершено", "Информационное сообщение", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Перечень выбранных файлов пуст", "Информационное сообщение", MessageBoxButtons.OK);
            }
        }

        private void chckbSubDir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbFolder_TextChanged(object sender, EventArgs e)
        {
            //if (!(String.IsNullOrEmpty(txtbFolder.Text)) && (svgFiles.Count > 0))
            if (!(String.IsNullOrEmpty(txtbFolder.Text)))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
