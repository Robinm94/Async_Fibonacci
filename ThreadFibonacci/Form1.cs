using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadFibonacci
{
    public partial class Form1 : Form
    {
        List<double> listFibonacci = new List<double>();
        public Form1()
        {
            InitializeComponent();
            lstFibResult.RightToLeft = RightToLeft.Yes;
        }

        private async void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                listFibonacci.Clear();
                lstFibResult.DataSource = null;
                int n = int.Parse(txtNumInput.Text);
                await Task.Run(() => Fibonacci(n));
                lstFibResult.DataSource = listFibonacci.Select(x => x.ToString("N0")).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Fibonacci(int n)
        {
            double a = 0;
            double b = 1;
            double c = 0;
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                listFibonacci.Add(c);
            }
        }
    }
}
