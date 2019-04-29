using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> items = new List<int>();
        List<int> sorted = new List<int>();
        [TestInitialize]//атрибут для обозначения метода инициализации, вызывается отдельно перед каждым тестовым методом
        public void Init()
        {
            items.Clear();
            for (int i = 0; i < 1000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            sorted.Clear();
            sorted.AddRange(items.OrderBy(x => x).ToArray());
        }
        [TestMethod()]//это тестовый метод и отображается в обозревателе тестов
        public void BubbleTest()
        {
            // arrange
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(items);
            // act
            bubble.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], bubble.Items[i]);
            }
        }
        [TestMethod()]
        public void CoctailTest()
        {
            // arrange
            var coctail = new CocktailSort<int>();
            coctail.Items.AddRange(items);
            // act
            coctail.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], coctail.Items[i]);
            }
        }
        [TestMethod()]
        public void InsertTest()
        {
            // arrange
            var insert = new InsertSort<int>();
            insert.Items.AddRange(items);
            // act
            insert.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], insert.Items[i]);
            }
        }
    }
}