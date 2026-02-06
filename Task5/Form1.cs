using System;
using System.Windows.Forms;

namespace Task5
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

        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++) {
                    if (arr[j] > arr[j + 1])
                    {
                        int initial = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = initial;
                    }
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 7, 3, 9, 1, 5, 2, 4, 8, 10, 6 };
            BubbleSort(numbers);

            ListBoxResults.Items.Clear();
            foreach (int num1 in numbers)
            {
                ListBoxResults.Items.Add(num1);
            }
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
