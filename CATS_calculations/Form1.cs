using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
namespace CATS_calculations
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp = new Excel.Application();

        List<string> dates = new List<string>();
        List<int> time = new List<int>();
        string serviceRequests;
        string selectedValueInCB;
        int lastRow;
        public Form1()
        {
            InitializeComponent();
            ComboBoxForDates.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxForDates.Enabled = false;
            LabelTitleForCalcTime.Visible = false;
            ButtonForCalculatingCATS.Enabled = false;
            ButtonForCalculatingCATSweek.Enabled = false;
            ButtonForServiceRequest.Enabled = false;
            LabelKrutov.Text = "\u00A9 Krutov STAN-5000";
        }
        private void buttonForSelectFile_Click(object sender, EventArgs e)
        {
            xlApp.Quit();
            ComboBoxForDates.Items.Clear();
            dates.Clear();
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Выберете Excel файл";
            OFD.DefaultExt = "*.xls;*.xlsx";
            OFD.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            if (OFD.ShowDialog() == DialogResult.OK && OFD.FileName.Length != 0)
            {
                LabelForFileLocation.Text = OFD.FileName;
                LabelForCalculatedTime.Text = "";
                LabelTitleForCalcTime.Visible = false;
            }
            else
            {
                return;
            }
            string xlFileName = OFD.FileName;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlSheet;
            xlWorkBook = xlApp.Workbooks.Open(xlFileName);
            xlSheet = xlWorkBook.Sheets[1];
            lastRow = xlApp.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            GetDates(xlApp);
            dates = dates.GroupBy(x => x).Select(y => y.FirstOrDefault()).ToList<string>();
            dates.Sort();
            dates.Reverse();
            ComboBoxForDates.Items.AddRange(dates.ToArray<string>());
            try
            {
                ComboBoxForDates.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Скорее всего Вы выбрали не тот файл!");
                LabelForFileLocation.Text = "";
                LabelForCalculatedTime.Text = "";
                LabelTitleForCalcTime.Visible = false;
                ComboBoxForDates.Enabled = false;
                ButtonForCalculatingCATS.Enabled = false;
                ButtonForCalculatingCATSweek.Enabled = false;
                ButtonForServiceRequest.Enabled = false;
                return;
            }
            selectedValueInCB = dates[ComboBoxForDates.SelectedIndex];
            ComboBoxForDates.Enabled = true;
            ButtonForCalculatingCATS.Enabled = true;
            ButtonForCalculatingCATSweek.Enabled = true;
            ButtonForServiceRequest.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
        }
        public void CalculateTime()
        {
            for (int i = 2; i <= lastRow; i++)
            {
                if (xlApp.Cells[i, 6] != null)
                {
                    time.Add(Convert.ToInt32((xlApp.Cells[i, 6].Value)));
                }
            }
        }
        public void GetDates(Excel.Application xlApp)
        {
            Regex regex = new Regex(@"\d\d.\d\d.\d\d\d\d");
            for (int i = 2; i <= lastRow; i++)
            {
                if (xlApp.Cells[i, 3] != null)
                {
                    Match match = regex.Match((xlApp.Cells[i, 3].Value).ToString());
                    dates.Add(match.Value.ToString());
                }
            }
        }
        public void GetServiceRequests()
        {
            serviceRequests = "Выполнение обращений SR - ";
            for (int i = 2; i <= lastRow; i++)
            {
                string s = (xlApp.Cells[i, 3].Value).ToString();
                if (s.Contains(selectedValueInCB))
                {
                    serviceRequests += (xlApp.Cells[i, 2].Value).ToString() + ", ";
                }
            }
            serviceRequests = serviceRequests.Remove(serviceRequests.LastIndexOf(','));
        }
        private void ButtonForCalculatingCATS_Click(object sender, EventArgs e)
        {
            int calculatedTime = 0;
            for (int i = 2; i <= lastRow; i++)
            {
                string s = (xlApp.Cells[i, 3].Value).ToString();
                if (s.Contains(selectedValueInCB))
                {
                    calculatedTime += Convert.ToInt32(xlApp.Cells[i, 6].Value);
                }
            }
            LabelTitleForCalcTime.Visible = true;
            LabelForCalculatedTime.Text = Math.Round((((float)calculatedTime) / 60), 2).ToString();
        }
        private void ComboBoxForDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValueInCB = dates[ComboBoxForDates.SelectedIndex];
        }

        private void ButtonForCalculatingCATSweek_Click(object sender, EventArgs e)
        {
            time.Clear();
            CalculateTime();
            LabelTitleForCalcTime.Visible = true;
            LabelForCalculatedTime.Text = Math.Round((((float)time.Sum()) / 60), 2).ToString();
        }

        private void LabelForCalculatedTime_Click(object sender, EventArgs e)
        {
            if (LabelForCalculatedTime.Text.Length > 0)
            {
                Clipboard.SetText(LabelForCalculatedTime.Text, TextDataFormat.UnicodeText);
            }
        }
        private void ButtonForServiceRequest_Click(object sender, EventArgs e)
        {
            GetServiceRequests();
            if (serviceRequests.Length > 0)
            {
                Clipboard.SetText(serviceRequests, TextDataFormat.UnicodeText);
            }
            else
            {
                MessageBox.Show("Обращения отсутствуют");
            }
        }

        private void LabelForCalculatedTime_MouseEnter(object sender, EventArgs e)
        {
            LabelForCalculatedTime.Cursor = Cursors.Hand;
        }
    }
}
