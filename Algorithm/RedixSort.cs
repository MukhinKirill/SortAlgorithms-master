using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class RedixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public RedixSort()
        {

        }
        public RedixSort(IEnumerable<T> items) : base(items)
        {

        }
        protected override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }
            int length = GetMaxLength();
            for (int step = 0; step < length; step++)
            {
                //распределение элементов по корзинам
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10,(step + 1)) / (int)Math.Pow(10, (step));
                    groups[value].Add(item);
                }
                Items.Clear();
                // сборка элементов
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }
                //очистка корзин
                foreach (var group in groups)
                {
                    group.Clear();
                }

            }
        }

        private int GetMaxLength()
        {
            var length = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Поразрядная сортировка поддерживает только натуральные числа", nameof(item));
                }
                //var l = Convert.ToInt32(Math.Log10(item.GetHashCode()) + 1);//Не работает со значением Item == 0. Дает -inf
                var l = item.GetHashCode().ToString().Length;
                if (l > length)
                {
                    length = l;
                }
            }
            return length;
        }
    }
}
