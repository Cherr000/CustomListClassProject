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

            // Act

            //Assert
        }
        //[TestMethod]
        //public void SubtractOffTest()
        //{
        //    // Arrange
        //    ListClass<int> list = new ListClass<int>() { 1, 2, 3, 4, 5};
        //    int three = 3;
        //    // Act
        //    list.SubtractOff(three);
        //    // Assert
        //    Assert.AreEqual(list.listArray[0], three);
        //}
        //[TestMethod]
        //public void AddLength()
        //{
        //    // Arrage
        //    ListClass<int> list = new ListClass<int>();
        //    // Act
        //    list.CheckLenght();
        //    //Assert
        //    Assert.AreEqual(list.listArray[0], 4);
        //}
    }
}
