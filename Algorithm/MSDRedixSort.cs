using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class MSDRedixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public MSDRedixSort()
        {

        }
        public MSDRedixSort(IEnumerable<T> items) : base(items)
        {

        }
       protected override void MakeSort()
        {
            var result = SortCollection(Items, length - 1);
            for (int i = 0; i < result.Count; i++)
            {
                Set(i, result[i]);
            }
        }
        private List<T> SortCollection(List<T> collection, int step)
        {
            var result = new List<T>();
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            //распределение элементов по корзинам
            foreach (var item in collection)
            {
                var i = item.GetHashCode();
                var value = i % (int)Math.Pow(10, (step + 1)) / (int)Math.Pow(10, (step));
                groups[value].Add(item);
            }
            // сборка элементов
            foreach (var group in groups)
            {

                if (group.Count > 1 && step > 0)
                {
                    result.AddRange(SortCollection(group, step - 1));
                    continue;
                }
                result.AddRange(group);
            }
            return result;
        }
        private int GetMaxLength(List<T> collection)
        {
            var length = 0;
            foreach (var item in collection)
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
