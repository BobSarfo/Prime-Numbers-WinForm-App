using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbersApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            leftListView.Columns.Add("Numbers", 200);
            rightListView.Columns.Add("Numbers", 200);
        }


        private void leftBtn_Click(object sender, EventArgs e)
        {
            if (!lBgWorker.IsBusy)
                lBgWorker.RunWorkerAsync();
        }


        private void rightBtn_Click(object sender, EventArgs e)
        {
         
            if (!rBgWorker.IsBusy)
                rBgWorker.RunWorkerAsync();
        }



        private void rBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Task.Run(() =>
            {
                rightListView.Items.Clear();
                if (int.TryParse(rTextBox.Text, out int rightValue))
                {
                    foreach (int i in MathUtils.GeneratePrimeNumbers(rightValue))
                    {
                        rightListView.Invoke(new Action(() =>
                        {
                            var item = new ListViewItem(i.ToString());
                            rightListView.Items.Add(item).EnsureVisible();
                        }));

                    }
                }
            });
        }

        private void lBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Task.Run(() =>
            {
                leftListView.Items.Clear();

                if (int.TryParse(lTextBox.Text, out int leftValue))
                {
                    foreach (int i in MathUtils.GeneratePrimeNumbers(leftValue))
                    {
                        leftListView.Invoke(new Action(() =>
                        {
                            var item = new ListViewItem(i.ToString());
                            leftListView.Items.Add(item).EnsureVisible();
                        }));

                    }
                }
            });
        }

    }
}
