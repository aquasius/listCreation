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
            int number1 = 4;
            int number2 = 5;
            int number3 = 6;
            int number4 = 7;
            int number5 = 8;
            int number6 = 9;
            int number7 = 10;
            int number8 = 11;

            //act
            list3.Add(number1);
            list3.Add(number2);
            list3.Add(number3);
            list3.Add(number4);
            list3.Add(number5);
            list3.Add(number6);
            list3.Add(number7);
            list3.Add(number8);
            actual = list3.Count;

            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Custom_List_CheckNumberAtIndexTwenty()
        {
            CustomList<int> list4 = new CustomList<int>();
            // arrange
            int expected = 16;
            int actual;
            int number1 = 4;
            int number2 = 5;
            int number3 = 6;
            int number4 = 7;
            int number5 = 8;
            int number6 = 9;
            int number7 = 10;
            int number8 = 11;
            int number9 = 12;
            int number10 = 13;
            int number11 = 14;
            int number12 = 15;
            int number13 = 16;
            int number14 = 17;
            int number15 = 18;
            int number16 = 19;


            //act
            list4.Add(number1);
            list4.Add(number2);
            list4.Add(number3);
            list4.Add(number4);
            list4.Add(number5);
            list4.Add(number6);
            list4.Add(number7);
            list4.Add(number8);
            list4.Add(number9);
            list4.Add(number10);
            list4.Add(number11);
            list4.Add(number12);
            list4.Add(number13);
            list4.Add(number14);
            list4.Add(number15);
            list4.Add(number16);
            actual = list4.Count;

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





      }



}







