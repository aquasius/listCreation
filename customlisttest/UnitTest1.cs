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


            //act
            list1.Add(6);
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void CustomList_Add_Numbers_To_ResizeCapacity()
        {
            //arrange
            CustomList<int> list2 = new CustomList<int>();
            int expected = 5;
            int actual;
            int number1 = 4;
            int number2 = 5;
            int number3 = 6;
            int number4 = 7;
            int number5 = 8;

            //act
            list2.Add(number1);
            list2.Add(number2);
            list2.Add(number3);
            list2.Add(number4);
            list2.Add(number5);
            actual = list2.Count;


            //assert
            Assert.AreEqual(expected, actual);





        }

        [TestMethod]
        public void Custom_List_CheckNumberAtIndexEight()
        {
            CustomList<int> list3 = new CustomList<int>();
            // arrange
            int expected = 8;
            int actual;
            

            //act
            list3.Add(4);
            list3.Add(5);
            list3.Add(6);
            list3.Add(7);
            list3.Add(8);
            list3.Add(9);
            list3.Add(10);
            list3.Add(11);
            actual = list3.Count;

            //assert
            Assert.AreEqual(expected, actual);


        }


        [TestMethod]

        public void CustomList_Add_to_List_then_Remove_Index_2()
        {
            //Arrange
            CustomList<int> list5 = new CustomList<int>();
            int expected = 1;
            int actual;
            int value1 = 10;
            int value2 = 20;


            //Act
            list5.Add(value1);
            list5.Add(value2);
            list5.Remove(value2);
            actual = list5.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void CustomList_Add_to_List_then_RemoveANumberAndFindValueOfIndex2()
        {
            //Arrange
            CustomList<int> list6 = new CustomList<int>();
            int expected = 40;
            int actual;
           
 
            //Act
            list6.Add(10);
            list6.Add(20);
            list6.Add(30);
            list6.Add(40);
            list6.Remove(30);
            actual = list6[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_Add_to_List_Remove_2numbers_And_FindWhatsAtIndex3()
        {
            //Arrange
            CustomList<int> list7 = new CustomList<int>();
            
   
            int expected = 50;
            int actual;
        
            //Act
            list7.Add(10);
            list7.Add(20);
            list7.Add(30);
            list7.Add(40);
            list7.Add(50);
            list7.Remove(30);
            list7.Remove(40);
            actual = list7[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }





        [TestMethod]
        public void CustomList_Add5_to_List_Remove_32numbers_And_CheckCount()
        {
            //Arrange
            CustomList<int> list8 = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            list8.Add(10);
            list8.Add(20);
            list8.Add(30);
            list8.Add(40);
            list8.Add(50);
            list8.Remove(20);
            list8.Remove(40);
            actual = list8.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }

}






