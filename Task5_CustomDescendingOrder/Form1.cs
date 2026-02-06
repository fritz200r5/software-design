using System;
using System.Windows.Forms;

namespace Task5_CustomDescendingOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ArraySorter 
        {
            private int[] numbers;

            public ArraySorter(int[] numbers) 
            { 
               this.numbers=numbers;
            }

            public void SortDescendingArray() 
            {
                int num = numbers.Length;
                for(int i = 0; i< num-1; i++) 
                {
                    for(int j = i+1; j < num; j++) 
                    {
                        if(numbers[i] < numbers[j]) {
                            int initial = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = initial;
                        }
                    }
                }
            }

            public int[] FetchNum() 
            {
                return numbers;
            }
            
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 7, 3, 1, 5, 9, 2, 4, 8, 10, 6 };

            ArraySorter sorter = new ArraySorter(numbers);

            sorter.SortDescendingArray();

            int[] sortedNumbers= sorter.FetchNum();
            ListBoxResults.Items.Clear();

            foreach (int num1 in sortedNumbers)
            {
                ListBoxResults.Items.Add(num1);
            }
        }

    }
}
