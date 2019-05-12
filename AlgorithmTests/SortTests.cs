using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.DataStructure;

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
        [TestMethod()]
        public void ShellTest()
        {
            // arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(items);
            // act
            shell.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], shell.Items[i]);
            }
        }
        [TestMethod()]
        public void BaseTest()
        {
            // arrange
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(items);
            // act
            bases.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], bases.Items[i]);
            }
        }
        [TestMethod()]
        public void TreeTest()
        {
            // arrange
            var tree = new TreeSort<int>();
            tree.Items.AddRange(items);
            // act
            tree.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], tree.Items[i]);
            }
        }
        [TestMethod()]
        public void HeapTest()
        {
            // arrange
            var heap = new Heap<int>(items);
            // act
            heap.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], heap.Items[i]);
            }
        }
        [TestMethod()]
        public void SelectionTest()
        {
            // arrange
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(items);
            // act
            selection.Sort();

            // assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], selection.Items[i]);
            }
        }
    }
}