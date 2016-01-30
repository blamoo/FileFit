using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace FileFit
{
    public partial class MainForm : Form
    {
        private FileFitObject FFOInstance;
        FolderBrowserDialog OpenFolderDlg;

        public MainForm()
        {
            InitializeComponent();
            OpenFolderDlg = new FolderBrowserDialog();
            OpenFolderDlg.SelectedPath = Properties.Settings.Default.OpenFolderPath;
            FFOInstance = new FileFitObject();
        }

        private void CalcularBtn_Click(object sender, EventArgs e)
        {
            Int64 alvo = Convert.ToInt64(TamanhoTxt.Text);
            Int64 soma;

            IMensurable[][] todos = FFOInstance.TestRange((long) (alvo * 0.8), alvo, true);

            ResultadoLst.Items.Clear();

            if (todos.Length == 0)
                ResultadoLst.Items.Add("nope.avi");
            else
                foreach (IMensurable[] grupoatual in todos)
                {
                    soma = 0;
                    foreach (IMensurable nomeatual in grupoatual)
                    {
                        soma += nomeatual.Size;
                        ResultadoLst.Items.Add(new ListViewItem(nomeatual.Name));
                    }

                    double SobraMB = ((alvo - soma) / 1024d / 1024d);
                    double porcentagem = (double) soma / (double) alvo;

                    ResultadoLst.Items.Add(new ListViewItem(new String[] { "Sobra (em MB):", string.Format("{0:0.00}MB", SobraMB), string.Format("{0:P}", porcentagem) }) { BackColor = Color.Wheat, Tag = grupoatual });
                }

            ResultadoLst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void AddDirRecBtn_Click(object sender, EventArgs e)
        {
            if (OpenFolderDlg.ShowDialog() != DialogResult.OK) return;

            FFOInstance.AddDirectoryItems(OpenFolderDlg.SelectedPath, Convert.ToInt64(Properties.Settings.Default.Cluster));

            foreach (IMensurable i in FFOInstance.List)
                FilesLst.Items.Add(new ListViewItem(new string[] { i.Name, i.Size.ToString(), i.FullPath.ToString() }));
            FilesLst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.OpenFolderPath = OpenFolderDlg.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void LimparBtn_Click(object sender, EventArgs e)
        {
            FFOInstance.List.Clear();
            FilesLst.Items.Clear();
        }

        private void ResultadoLst_DoubleClick(object sender, EventArgs e)
        {
            IMensurable[] m = ResultadoLst.SelectedItems[0].Tag as IMensurable[];

            if (m == null)
                SystemSounds.Beep.Play();
            else
            {
                StringCollection s = new StringCollection();
                //StringBuilder b = new StringBuilder();
                foreach (IMensurable i in m)
                {
                    s.Add(i.FullPath);
                    //b.Append(i.Name);
                    //b.Append("\n");
                }
                Clipboard.SetFileDropList(s);
                //Clipboard.SetText(b.ToString());
            }

        }
    }
}
