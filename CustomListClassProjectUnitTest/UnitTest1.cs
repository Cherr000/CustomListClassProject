using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace CustomListClassProjectUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOnTest()
        {
            // Arrange
            ListClass<int> list = new ListClass<int>();
            int one = 1;
            // Act
            list.Add(one);
            int two = list.listArray[0];
            // Assert
            Assert.AreEqual(one, two); 
        }
        [TestMethod]
        public void AddOnTwoTest()
        {
            // Arrange
            ListClass<int> list = new ListClass<int>() { 0, 2, 3 };
            int one = 1;
            // Act
            list.Add(one);
            // Assert
            Assert.AreEqual(list.listArray[3], one);
        }
        [TestMethod]
        public void AddLength()
        {
            // Arrage
            ListClass<int> list = new ListClass<int>() { 0, 1, 2, 3 };
            int input = 4;
            // Act
            list.Add(input);
            //Assert
            Assert.AreEqual(5, list.Counts);
        }
        [TestMethod]
        public void Add_FiveValues_ReturnsValueAtIndex()
        {
            // Arrage
            ListClass<int> list = new ListClass<int>() { 0, 1, 2, 3 };
            int input = 7;
            // Act
            list.Add(input);
            //Assert
            Assert.AreEqual(7, list.listArray[4]);
        }
        //--------------------------------------------------------------
        [TestMethod]
        public void RemoveOffTest()
        {
            // Arrange
            ListClass<int> list = new ListClass<int>() { 1, 2, 3, 4, 5 };
            int three = 3;
            // Act
            list.Remove(three);
            // Assert
            Assert.AreEqual(list.listArray[2], 4);
        }
        [TestMethod]
        public void RemoveTwoOff()
        {
            // Arrange
            ListClass<int> list = new ListClass<int>() { 1, 2, 3, 4, 5 };
            int three = 3;
            int five = 5;
            // Act
            list.Remove(three);
            list.Remove(five);
            // Assert
            Assert.AreEqual(list.listArray[2], 4);
            Assert.AreEqual(list.listArray[0], 1);
            Assert.AreEqual(list.listArray[1], 2);
        }
        [TestMethod]
        public void RemoveOffCounts()
        {
            // Arrage
            ListClass<int> list = new ListClass<int>() { 1, 2, 3, 4, 5 };
            int five = 5;
            // Act
            list.Remove(five);
            // Assert
            Assert.AreEqual(4, list.Counts);
        }
        //--------------------------------------------------------------
        [TestMethod]
        public void TestToString()
        {
            // Arrage
            ListClass<string> list = new ListClass<string>();
            // Act
            list.Add("Hello");
            list.Add("World");
            // Assert
            Assert.AreEqual("HelloWorld", list.ToString());
        }
        //--------------------------------------------------------------
        [TestMethod]
        public void TestAddOprator()
        {
            // Arrage
            ListClass<string> valueOne = new ListClass<string>() { "Jordan", "Nike" };
            ListClass<string> valueTwo = new ListClass<string>() { "retro", "roshe" };
            // Act
            ListClass<string> valueOfList = valueOne + valueTwo;
            // Assert
            Assert.AreEqual(4, valueOfList.Counts);
        }
        [TestMethod]
        public void TestSubtractOprator()
        {
            // Arrage
            ListClass<string> valueOne = new ListClass<string>() { "Jordan", "Nike" };
            ListClass<string> valueTwo = new ListClass<string>() { "retro", "roshe" };
            // Act
            ListClass<string> valueOfList = valueOne - valueTwo;
            // Assert
            Assert.AreEqual(2, valueOfList.Counts);
        }
    }
}
