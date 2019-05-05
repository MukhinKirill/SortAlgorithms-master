using Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                if (value > 99)
                {
                    AddTextBox.Text = "99";
                    return;
                }
                var item = new SortedItem(value, items.Count);
                items.Add(item);
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }

            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            ClearPanel();
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();

                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(0, 100), items.Count);
                    items.Add(item);
                    panel3.Controls.Add(item.ProgressBar);
                    panel3.Controls.Add(item.Label);
                }
            }

            FillTextBox.Text = "";
        }

        private void ClearPanel()
        {
            for (int j = 0; j < items.Count; j++)
            {
                panel3.Controls.Remove(items[j].ProgressBar);
                panel3.Controls.Remove(items[j].Label);
                panel3.Refresh();
            }
            items.Clear();
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwopEvent += Bubble_SwopEvent;
            bubble.Sort();
        }

        private void Bubble_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Value;
            e.Item1.SetValue(e.Item2.Value);
            panel3.Refresh();
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();
        }
    }
}
