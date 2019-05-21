﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    class SortedItem:IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get;private set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }
        public int Number { get; set; }
        public int StartNumber { get; set; }
        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();
            var x = number * 20;
            // 
            // verticalProgressBar1
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(x, 3);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar" + number;
            ProgressBar.Size = new System.Drawing.Size(18, 96);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            // 
            // label2
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(x, 102);
            Label.Name = "label"+number;
            Label.Size = new System.Drawing.Size(19, 13);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
        }
        public void SetPosition(int number)
        {
            Number = number;
            var x = Number * 20;
            ProgressBar.Location = new Point(x, 3);
            ProgressBar.Name = "ProgressBar" + Number;
            Label.Location = new Point(x, 102);
            Label.Name = "label" + Number;
        }

        public void SetColor(Color color)
        {
            ProgressBar.Color = color;
        }
        public void Refresh()
        {
            Number = StartNumber;
            var x = Number * 20;
            ProgressBar.Location = new Point(x, 3);
            ProgressBar.Name = "ProgressBar" + Number;
            Label.Location = new Point(x, 102);
            Label.Name = "label" + Number;
        }
        public int CompareTo(object obj)
        {
            if(obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}");
            }
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        public override int GetHashCode()
        {
            return Value;
        }
    }
}
