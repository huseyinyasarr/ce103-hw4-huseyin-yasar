using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll;
using System.Text;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTestOne
    {
        [TestMethod]
        public void fibonacciNumber_cs_test_1()
        {
            ClassOne fibo = new ClassOne();
            int result = fibo.fibonacciNumber_cs(18);
            Assert.AreEqual(result, 1597);
        }
        [TestMethod]
        public void 
            fibonacciNumber_cs_imported_test_1()
        {
            ClassTwo fibo = new ClassTwo();
            int result = fibo.ce103_fibonacciNumber_cs_imported(18);
            Assert.AreEqual(result, 1597);
        }
        [TestMethod]
        public void fibonacciNumber_importedcppcs_test_1()
        {
            ClassOne fibo = new ClassOne();
            int result = fibo.fibonacciNumber_cs(15);
            ClassTwo fiboo = new ClassTwo();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(15);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void fibonacciNumber_cs_test_2()
        {
            ClassOne fibo = new ClassOne();
            int result = fibo.fibonacciNumber_cs(30);
            Assert.AreEqual(result, 514229);
        }
        [TestMethod]
        public void fibonacciNumber_cs_imported_test_2()
        {
            ClassTwo fibo = new ClassTwo();
            int result = fibo.ce103_fibonacciNumber_cs_imported(18);
            Assert.AreEqual(result, 1597);
        }
        [TestMethod]
        public void fibonacciNumber_importedcppcs_test_2()
        {
            ClassOne fibo = new ClassOne();
            int result = fibo.fibonacciNumber_cs(17);
            ClassTwo fiboo = new ClassTwo();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(17);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void fibonacciNumber_cs_test_3()
        {
            ClassOne fibo = new ClassOne();
            int result = fibo.fibonacciNumber_cs(5);
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void fibonacciNumber_cs_imported_test_3()
        {
            ClassTwo fibo = new ClassTwo();
            int result = fibo.ce103_fibonacciNumber_cs_imported(5);
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void fibonacciNumber_importedcppcs_test_3()
        {
            ClassOne fibo = new ClassOne();
            int result = fibo.fibonacciNumber_cs(5);
            ClassTwo fiboo = new ClassTwo();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(5);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void strrev_cs_test_1()
        {
            ClassOne strrev = new ClassOne();
            Assert.AreEqual(strrev.strrev_cs("Car"), "raC");
        }
  
        [TestMethod]
        public void strrev_cs_test_2()
        {
            ClassOne strrev = new ClassOne();
            Assert.AreEqual(strrev.strrev_cs("My Room"), "mooR yM");
        }
    
        [TestMethod]
        public void strrev_cs_test_3()
        {
            ClassOne strrev = new ClassOne();
            Assert.AreEqual(strrev.strrev_cs("TeamWorld"), "dlroWmaeT");         
        }
     
        [TestMethod]
        public void strlen_cs_test_1()
        {
            ClassOne strlen = new ClassOne();
            Assert.AreEqual(strlen.strlen_cs("Start"), 5);
        }

        [TestMethod]
        public void strlen_cs_test_2()
        {
            ClassOne strlen = new ClassOne();
            Assert.AreEqual(strlen.strlen_cs("car fabricator"), 14);
        }
    
        [TestMethod]
        public void strlen_cs_test_3()
        {
            ClassOne strlen = new ClassOne();
            Assert.AreEqual(strlen.strlen_cs("Voice"), 5);
        }

        [TestMethod]
        public void strcat_cs_test_1()
        {
            ClassOne strcat = new ClassOne();
            Assert.AreEqual(strcat.strcat_cs("Hi","Class"),"HiClass");
        }
  
        [TestMethod]
        public void strcat_cs_test_2()
        {
            ClassOne strcat = new ClassOne();
            Assert.AreEqual(strcat.strcat_cs("Smart","Phone"),"SmartPhone");
        }
 
        [TestMethod]
        public void strcat_cs_test_3()
        {
            ClassOne strcat = new ClassOne();
            Assert.AreEqual(strcat.strcat_cs("Covid","2019"),"Covid2019");
        }

        [TestMethod]
        public void strcmp_cs_test_1()
        {
            ClassOne strcmp = new ClassOne();
            Assert.AreEqual(strcmp.strcmp_cs("Smart", "Smart"), 0);
        }
 
        [TestMethod]
        public void strcmp_cs_test_2()
        {
            ClassOne strcmp = new ClassOne();
            Assert.AreNotEqual(strcmp.strcmp_cs("Notebook", "Computer"), 0);
        }

        [TestMethod]
        public void strcmp_cs_test_3()
        {
            ClassOne strcmp = new ClassOne();
            Assert.AreNotEqual(strcmp.strcmp_cs("My", "Team"), 0);
        }
 
        [TestMethod]
        public void strcpy_cs_test_1()
        {
            ClassOne strcpy = new ClassOne();
            Assert.AreEqual(strcpy.strcpy_cs("My", "Class"), "Class");
        }
 
        [TestMethod]
        public void strcpy_cs_test_2()
        {
            ClassOne strcpy = new ClassOne();
            Assert.AreEqual(strcpy.strcpy_cs("Small", "Car"), "Car");
        }
 
        [TestMethod]
        public void strcpy_cs_test_3()
        {
            ClassOne strcpy = new ClassOne();
            Assert.AreEqual(strcpy.strcpy_cs("Technology", "Store"), "Store");
        }
     
        [TestMethod]
        public void strrev_cs_imported_test_1()
        {
            ClassTwo strrev = new ClassTwo();
            Assert.AreEqual(strrev.strrev_cs_imported("Bedroom"), "moordeB");
        }
        [TestMethod]
        public void strrev_importedcppcs_test_1()
        {
            ClassOne strrev = new ClassOne();
            ClassTwo Strrev = new ClassTwo();
            Assert.AreEqual(strrev.strrev_cs("Bedroom"), "moordeB", Strrev.strrev_cs_imported("Bedroom"), "moordeB");
        }
 
        [TestMethod]
        public void strrev_cs_imported_test_2()
        {
            ClassTwo strrev = new ClassTwo();
            Assert.AreEqual(strrev.strrev_cs_imported("Hi World"), "dlroW iH");
        }
        [TestMethod]
        public void strrev_importedcppcs_test_2()
        {
            ClassOne strrev = new ClassOne();
            ClassTwo Strrev = new ClassTwo();
            Assert.AreEqual(strrev.strrev_cs("My Mountain"), "niatnuoM yM", Strrev.strrev_cs_imported("My Mountain"), "niatnuoM yM");
        }
     
        [TestMethod]
        public void strrev_cs_imported_test_3()
        {
            ClassTwo strrev = new ClassTwo();
            Assert.AreEqual(strrev.strrev_cs_imported("Wifi"), "ifiW");
        }
        [TestMethod]
        public void strrev_importedcppcs_test_3()
        {
            ClassOne strrev = new ClassOne();
            ClassTwo Strrev = new ClassTwo();
            Assert.AreEqual(strrev.strrev_cs("My Mountain"), "niatnuoM yM", Strrev.strrev_cs_imported("My Mountain"), "niatnuoM yM");
        }
       
        [TestMethod]
        public void strcat_cs_imported_test_1()
        {
            ClassTwo strcat = new ClassTwo();
            Assert.AreEqual(strcat.strcat_cs_imported("Green", "Screen"), "GreenScreen");
        }
        [TestMethod]
        public void strcat_importedcppcs_test_1()
        {
            ClassOne strcat = new ClassOne();
            ClassTwo Strcat = new ClassTwo();
            Assert.AreEqual(strcat.strcat_cs("Blue", "Screen"), "BlueScreen", Strcat.strcat_cs_imported("Blue", "Screen"), "BlueScreen");
        }
      
        [TestMethod]
        public void strcat_cs_imported_test_2()
        {
            ClassTwo strcat = new ClassTwo();
            Assert.AreEqual(strcat.strcat_cs_imported("Corona", "Virus"), "CoronaVirus");
        }
        [TestMethod]
        public void strcat_importedcppcs_test_2()
        {
            ClassOne strcat = new ClassOne();
            ClassTwo Strcat = new ClassTwo();
            Assert.AreEqual(strcat.strcat_cs("Corona", "Virus"), "CoronaVirus", Strcat.strcat_cs_imported("Corona", "Virus"), "CoronaVirus");
        }
        
        [TestMethod]
        public void strcat_cs_imported_test_3()
        {
            ClassTwo strcat = new ClassTwo();
            Assert.AreEqual(strcat.strcat_cs_imported("Auto", "System"), "AutoSystem");
        }
        [TestMethod]
        public void strcat_importedcppcs_test_3()
        {
            ClassOne strcat = new ClassOne();
            ClassTwo Strcat = new ClassTwo();
            Assert.AreEqual(strcat.strcat_cs("Auto", "System"), "AutoSystem", Strcat.strcat_cs_imported("Auto", "System"), "AutoSystem");
        }
    
        [TestMethod]
        public void strlen_cs_imported_test_1()
        {
            ClassTwo strlen = new ClassTwo();
            Assert.AreEqual(strlen.strlen_cs_imported("File"), 4);
        }
        [TestMethod]
        public void strlen_importedcppcs_test_1()
        {
            ClassOne strlen = new ClassOne();
            ClassTwo Strlen = new ClassTwo();
            Assert.AreEqual(strlen.strlen_cs("File"), 4, Strlen.strlen_cs_imported("File"));
        }
    
        [TestMethod]
        public void strlen_cs_imported_test_2()
        {
            ClassTwo strlen = new ClassTwo();
            Assert.AreEqual(strlen.strlen_cs_imported("Carpet"), 6);
        }
        [TestMethod]
        public void strlen_importedcppcs_test_2()
        {
            ClassOne strlen = new ClassOne();
            ClassTwo Strlen = new ClassTwo();
            Assert.AreEqual(strlen.strlen_cs("Carpet"), 6, Strlen.strlen_cs_imported("Carpet"));
        }
  
        [TestMethod]
        public void strlen_cs_imported_test_3()
        {
            ClassTwo strlen = new ClassTwo();
            Assert.AreEqual(strlen.strlen_cs_imported("Universty"), 9);
        }
        [TestMethod]
        public void strlen_importedcppcs_test_3()
        {
            ClassOne strlen = new ClassOne();
            ClassTwo Strlen = new ClassTwo();
            Assert.AreEqual(strlen.strlen_cs("Universty"), 9, Strlen.strlen_cs_imported("Universty"));
        }

        [TestMethod]
        public void strcmp_cs_imported_test_1()
        {
            ClassTwo strcmp = new ClassTwo();
            Assert.AreEqual(strcmp.strcmp_cs_imported("Car", "Car"), 0);
        }
        [TestMethod]
        public void strcmp_importedcppcs_test_1()
        {
            ClassOne strcmp = new ClassOne();
            ClassTwo Strcmp = new ClassTwo();
            Assert.AreEqual(strcmp.strcmp_cs("Car", "Car"), 0, Strcmp.strcmp_cs_imported("Car", "Car"));
        }
     
        [TestMethod]
        public void strcmp_cs_imported_test_2()
        {
            ClassTwo strcmp = new ClassTwo();
            Assert.AreNotEqual(strcmp.strcmp_cs_imported("Computer", "Engineering"), 0);
        }
        [TestMethod]
        public void strcmp_importedcppcs_test_2()
        {
            ClassOne strcmp = new ClassOne();
            ClassTwo Strcmp = new ClassTwo();
            Assert.AreNotEqual(strcmp.strcmp_cs("Computer", "Engineering"), 0, Strcmp.strcmp_cs_imported("Computer", "Engineering"));
        }
 
        [TestMethod]
        public void strcmp_cs_imported_test_3()
        {
            ClassTwo strcmp = new ClassTwo();
            Assert.AreNotEqual(strcmp.strcmp_cs_imported("Hi", "Class"), 0);
        }
        [TestMethod]
        public void strcmp_importedcppcs_test_3()
        {
            ClassOne strcmp = new ClassOne();
            ClassTwo Strcmp = new ClassTwo();
            Assert.AreNotEqual(strcmp.strcmp_cs("Hello", "World"), 0, Strcmp.strcmp_cs_imported("Hello", "World"));
        }

        [TestMethod]
        public void strcpy_cs_imported_test_1()
        {
            ClassTwo strcpy = new ClassTwo();
            Assert.AreEqual(strcpy.strcpy_cs_imported("Hi", "Honey"), "Honey");
        }
        [TestMethod]
        public void strcpy_importedcppcs_test_1()
        {
            ClassOne strcpy = new ClassOne();
            ClassTwo Strcpy = new ClassTwo();
            Assert.AreEqual(strcpy.strcpy_cs("Hi", "Honey"), "Honey", Strcpy.strcpy_cs_imported("Hi", "Honey"), "Honey");
        }
 
        [TestMethod]
        public void strcpy_cs_imported_test_2()
        {
            ClassTwo strcpy = new ClassTwo();
            Assert.AreEqual(strcpy.strcpy_cs_imported("PC", "Engineering"), "Engineering");
        }
        [TestMethod]
        public void strcpy_importedcppcs_test_2()
        {
            ClassOne strcpy = new ClassOne();
            ClassTwo Strcpy = new ClassTwo();
            Assert.AreEqual(strcpy.strcpy_cs("PC", "Engineering"), "Engineering", Strcpy.strcpy_cs_imported("PC", "Engineering"), "Engineering");
        }
     
        [TestMethod]
        public void strcpy_cs_imported_test_3()
        {
            ClassTwo strcpy = new ClassTwo();
            Assert.AreEqual(strcpy.strcpy_cs_imported("Class", "Hello"), "Hello");
        }
        [TestMethod]
        public void strcpy_importedcppcs_test_3()
        {
            ClassOne strcpy = new ClassOne();
            ClassTwo Strcpy = new ClassTwo();
            Assert.AreEqual(strcpy.strcpy_cs("Class", "Hello"), "Hello", Strcpy.strcpy_cs_imported("Class", "Hello"), "Hello");
        }
        [TestMethod]
        public void binToHex_cs_test1()
        {
            ClassOne bin2hex = new ClassOne();
            byte[] bin = { 0xBA, 0xFF, 0xAB, 0x26, 0x43, 0x14 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'B', 'A', 'F', 'F', 'A', 'B', '2', '6', '4', '3', '1', '4' };

            bin2hex.binToHex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void binToHex_imported_test1()
        {
            ClassTwo imported = new ClassTwo();
            byte[] bin = { 0xBA, 0xFF, 0xAB, 0x26, 0x43, 0x14 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'B', 'A', 'F', 'F', 'A', 'B', '2', '6', '4', '3', '1', '4' };

            imported.binToHex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void binToHex_importedcppcs_test1()
        {
            ClassOne bin2hex = new ClassOne();
            ClassTwo imported = new ClassTwo();
            byte[] bin = { 0xBA, 0xFF, 0xAB, 0x26, 0x43, 0x14 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.binToHex_cs(bin, bin.Length, hexstring1);
            imported.binToHex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void binToHex_cs_test2()
        {
            ClassOne bin2hex = new ClassOne();
            byte[] bin = { 0x11, 0x61, 0x11, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '6', '1', '1', '1', '1', '1', '1', '1' };

            bin2hex.binToHex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void binToHex_imported_test2()
        {
            ClassTwo imported = new ClassTwo();
            byte[] bin = { 0x11, 0x11, 0x61, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '1', '1', '6', '1', '1', '1', '1', '1' };

            imported.binToHex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void binToHex_importedcppcs_test2()
        {
            ClassOne bin2hex = new ClassOne();
            ClassTwo imported = new ClassTwo();
            byte[] bin = { 0xBB, 0xFB, 0xCD, 0x23, 0x43, 0x10 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.binToHex_cs(bin, bin.Length, hexstring1);
            imported.binToHex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void binToHex_cs_test3()
        {
            ClassOne bin2hex = new ClassOne();
            byte[] bin = { 0xFA, 0xCC, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'A', 'C', 'C', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            bin2hex.binToHex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void binToHex_imported_test3()
        {
            ClassTwo imported = new ClassTwo();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x16 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '1', '6' };

            imported.binToHex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void binToHex_importedcppcs_test3()
        {
            ClassOne bin2hex = new ClassOne();
            ClassTwo imported = new ClassTwo();
            byte[] bin = { 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.binToHex_cs(bin, bin.Length, hexstring1);
            imported.binToHex_cs_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void hexToBin_cs_test1()
        {
            ClassOne hex2bin = new ClassOne();
            string hexstring = "5113131313131361";
            byte[] expectedArr = { 0x51, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x61 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.hexToBin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void hexToBin_imported_test1()
        {
            ClassTwo hex2bin = new ClassTwo();
            string hexstring = "AAFBCD166124";
            byte[] expectedArr = { 0xAA, 0xFB, 0xCD, 0x16, 0x61, 0x24 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.hexToBin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void hexToBin_importedcppcs_test1()
        {
            ClassTwo imported = new ClassTwo();
            ClassOne hex2bin = new ClassOne();
            string hexstring = "FFFFFFFFFF";

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.hexToBin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.hexToBin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void hexToBin_cs_test2()
        {
            ClassOne hex2bin = new ClassOne();
            string hexstring = "2222224444";
            byte[] expectedArr = { 0x22, 0x22, 0x22, 0x44, 0x44 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.hexToBin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void hexToBin_imported_test2()
        {
            ClassTwo hex2bin = new ClassTwo();
            string hexstring = "23489759";
            byte[] expectedArr = { 0x23, 0x48, 0x97, 0x59};
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.hexToBin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void heToBin_importedcppcs_test2()
        {
            ClassTwo imported = new ClassTwo();
            ClassOne hex2bin = new ClassOne();
            string hexstring = "EAEC";
            byte[] expectedArr = { 0xEA, 0xEC };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.hexToBin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.hexToBin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void hexToBin_cs_test3()
        {
            ClassOne hex2bin = new ClassOne();
            string hexstring = "ACACACACACACAC";
            byte[] expectedArr = { 0xAC, 0xAC, 0xAC, 0xAC, 0xAC, 0xAC, 0xAC };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.hexToBin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void hexToBin_imported_test3()
        {
            ClassTwo hex2bin = new ClassTwo();
            string hexstring = "15151515151515151515";
            byte[] expectedArr = { 0x15, 0x15, 0x15, 0x15, 0x15, 0x15, 0x15, 0x15, 0x15, 0x15 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.hexToBin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void hexToBin_importedcppcs_test3()
        {
            ClassTwo imported = new ClassTwo();
            ClassOne hex2bin = new ClassOne();
            string hexstring = "11423FB23A234732FB";
            byte[] expectedArr = { 0x11, 0x42, 0x3F, 0xb2, 0x3A, 0x23, 0x47, 0x32, 0xFB };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.hexToBin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.hexToBin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
    }
}
