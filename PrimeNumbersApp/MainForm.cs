using System;
using System.ComponentModel;
using System.Threading;
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
            leftListView.Items.Clear();
            if (!lBgWorker.IsBusy)
                lBgWorker.RunWorkerAsync();
        }


        private void rightBtn_Click(object sender, EventArgs e)
        {
            rightListView.Items.Clear();

            if (!rBgWorker.IsBusy)
                rBgWorker.RunWorkerAsync();
        }



        private void rBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread thread = new Thread(() =>
            {
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
            thread.Start(); 
        }

        private void lBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread thread = new Thread(() => 
            {
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
            thread.Start(); 
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => {
                addCalculateLbl.Invoke(new Action(() =>
                {
                    if (double.TryParse(addInput1.Text, out double input1) && double.TryParse(addInput2.Text, out double input2))
                        addCalculateLbl.Text = MathUtils.add(input1, input2).ToString();
                }));
            });

            thread.Start(); 
        }
    }
}
