using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FaftasyevSchoolWorkers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateAnswer();
        }

        private void UpdateAnswer()
        {
            var monthlyRequired = new int[]
            {
               (int) numericUpDown1.Value,
               (int) numericUpDown2.Value,
               (int) numericUpDown3.Value,
               (int) numericUpDown4.Value
            };

            int l = int.Parse(lTextBox.Text);
            int j = int.Parse(jTextBox.Text);
            int h = int.Parse(hTextBox.Text);

            List<int> budgets = new List<int>();

            for (int i = 1; i < monthlyRequired.Max() + 1; i++)
            {
                var budget = 0;
                foreach (var peopleAmount in monthlyRequired)
                {
                    budget += (i <= peopleAmount) ? l * (peopleAmount - i) : h * (peopleAmount - i) + j;
                }

                budgets.Add(budget);
            }

            answerTextBox.Text = (budgets.IndexOf(budgets.Min()) + 1).ToString();
        }

        private void hTextBox_Validated(object sender, EventArgs e)
        {
            UpdateAnswer();
        }
    }
}
