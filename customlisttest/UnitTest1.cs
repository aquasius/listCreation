using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProj;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomList_Add_AddOneNumberToCount()
        {

            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 1;
            int actual;
            int number1 = 6;

            //act
            list1.Add(number1);
            actual = list1.Count;
            
            //assert
            Assert.AreEqual(expected, actual);
        
        }
    

    
    
    
    
    
    }






}
