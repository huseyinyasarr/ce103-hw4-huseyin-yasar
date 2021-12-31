using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll
{
    public class ClassOne
    {
		/**************************
        * Copyleft (L) 2021 CENG - All Rights Not Reserved
        * You may use, distribute and modify this code.
        **************************/

		 /**
		* @file ce103-hw4-cs-dll
		* @author Hüseyin Yaşar
		* @date 31 decemer 2021
		*
		* @brief <b> HW-4 Functions </b>
		*
		* HW-4 Sample Lib Functions
		*
	    * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
		*
		*/

		/**
	    * @name   fibonacciNumber (fibonacciNumber_cs)
	    *
	    * @brief Fibonacci Number Calculator
	    *
	    * Calculates the fibonacci number in the given index and return as output
	    *
	    * @param  [in] fiIndex [\b int]  index of fibonacci number in the serie
	    *
	    * @retval [\b int] calculated fibonacci number
	    **/
		public int fibonacciNumber_cs(int fiIndex)
		{
			fiIndex = fiIndex - 1;
			//First, let's define our integers.
			int s1 = 0, s2 = 1, nextStep = 0;
			int returnNum;
			//This if statement implicitly checks "is not 0", so we reverse that to mean "is 0".
			if (fiIndex <= 0)
			{
				// if index is lower than 1 function will return 0
				return 0;
			}
			//I used "for" because there are repetitive processes here.
			//In this part, if i=1 and i<= fiIndex, the following is done.
			for (int i = 1; i <= fiIndex; ++i)
			{
				s1 = s2;
				s2 = nextStep;
				nextStep = s1 + s2;
				returnNum = nextStep;
				//returnnumber or if the nextStep is less than 0
				if (returnNum < 0)
				{
					//if index is higher than 46 function will return -2 
					return -2;
				}
			}
			returnNum = nextStep;
			//fiIndex' th fibonacci number
			return returnNum;
		}

		/**
		@name   strrev (strrev_cs)

		@brief \b Reverse String

		Reverse given string

		@param [in] fiStr [\b string] The given string which is needed to be reversed.

		@retval [\b string] This function returns the string after reversing the given string
	    **/
		public string strrev_cs(string fiStr)
		{
			//Let i and j be our variables. In this function, we will take the inverse of the string we give.
			char[] chars = new char[strlen_cs(fiStr)];
			//Our variable i will start at zero and increment its value by one each time our for loop returns.
			for (int i = 0, j = strlen_cs(fiStr) - 1; i <= j; i++, j--)
			{
				chars[i] = fiStr[j];
				chars[j] = fiStr[i];
			}
			//return value that gives us the inverse of the string we entered
			return new string(chars);
		}

		/**
		@name   strlen (strlen_cs)
		@brief \b Get string length

		Returns the length of the C# string str.

		@param [in] fiStr [\b string] the null-terminated byte string to be examined

		@retval [\b int] The length of the null-terminated byte string str.
	    **/
		public int strlen_cs(string fiStr)
		{
			//Returns the length of the string we entered
			//Let's have a counter and it starts at 0.
			int count = 0;
			//Our count counter calculates the length of the string we entered into our loop and returns its length to us.
			foreach (char chr in fiStr)
			{
				count++;
			}
			//Return value of length found
			return count;
		}

		/**
		@name   strcat (strcat_cs)
		@brief \b Concatenate strings

		In this function, we combine 2 randomly entered strings.
        We give one of our strings "fiDest" and the other "fiSrc", that is, a random string.
        The sum of these strings gives us the combined return value of the strings.


		@param  [in] fiDest [\b string] the null-terminated byte string to append to
		@param  [in] fiSrc  [\b string] the null-terminated byte string to copy from

		@retval [\b string] returns a copy of dest
	    **/
		public string strcat_cs(string fiDest, string fiSrc)
        {
			//We give one of our strings "fiDest" and the other "fiSrc", that is, a random string.
			//The sum of these strings gives us the combined return value of the strings.
			return fiDest +fiSrc;
		}

		/**
		@name   strcmp (strcmp_cs)
		@brief  \b Compare two strings

		Compares two null-terminated byte strings lexicographically.

		@param  [in] fiLhs [\b string] the null-terminated byte strings to compare
		@param  [in] fiRhs [\b string] the null-terminated byte strings to compare

		@retval [\b int] Negative value if lhs appears before rhs in lexicographical order.
				Zero if lhs and rhs compare equal.
				Positive value if lhs appears after rhs in lexicographical order.
	    **/
		public int strcmp_cs(string fiLhs, string fiRhs)
        {
			//Let's say we have two strings.
			//If they are equal, our return value will be equal to 0.
			if (fiLhs == fiRhs)
			{
				return 0;
			}
			//If the lengths of the strings we entered are different from each other, the return value of the function will not be 0.
			else if (strlen_cs(fiLhs) < (strlen_cs(fiRhs)))
			{
				return -1;
			}
			else
			{
				return 1;
			}
		}

		/**
	    *
		@name  strcpy (strcpy_cs)
		@brief \b Copy string

		Copies the C# string pointed by source into the array pointed by destination,
		including the terminating null character (and stopping at that point).

		@param [out] foDestination	[\b string] the destination array where the content is to be copied.
		@param [in]  fiSource		[\b string]	C string to be copied.

		@retval [\b string] returns a copy of dest
	    **/
		public string strcpy_cs(string foDestination, string fiSource)
        {
			//this function copies the string in the string pointed to by the source.
			//If the copied string and the other string are equal, the function returns the copied string to us.
			foDestination = fiSource;
			return foDestination;
		}
		/**
        * @name    bin2hex (binToHex_cs)
        * 
        * @brief   \b Binary to Hexadecimal Conversion
        *
        * Unpacks alpha numeric value, Example: 0x12 0x34 = "1234".
        *
        * @param [in]  fiBin      [\b byte[]]    Binary data to be converted.
        * 
        * @param [in]  fiBinLen   [\b int]	 Binary data length.
        * 
        * @param [out] foHex      [\b char[]]	 Convertion result as ascii. Doubles the binary length.
        **/
		public void binToHex_cs(byte[] fiBin, int fiBinlen, char[] foHex)
        {
			char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			for (int x = 0; x < fiBinlen; x++)
            {
				foHex[x * 2] = arr[fiBin[x] >> 4];
				foHex[x * 2 + 1] = arr[fiBin[x] & 0x0F];
            }
        }

		/**
        * @name    hex2bin (hexToBin_cs)
        * 
        * @brief   \b Hexadecimal string to byte array Conversion
        * 
        * Convert hex string to byte array
        *
        * @param   [in]  fiHex    [\b string] Ascii hex string.
        * 
        * @param   [in]  fiHexLen [\b int]     Ascii data length.
        * 
        * @param  [out]  foBin    [\b byte[]]   Convertion result as binary.
        **/
		public void hexToBin_cs(string fiHex, int fiHexLen, byte[] foBin)
		{
			//char[] foBinArr = new char[fiHexLen / 2];

			int[] count = { 0, 0 };
			for (int a = 0; a < fiHexLen; a += 2)
			{   // array for assigning foBin elements
				// store two character from fiHex func
				char[] temp = new char[2];
				// hexint stores sum of two ascii values generated from hex base
				int hexint = 0;
				for (int y = 0; y < 2; y++)
				{  // for loop for calculating sum of ascii values
					temp[y] = (char)fiHex[a + y];
					if (y == 0)
					{  // if j == 0 meaning first element of temp
					   // if and else if code snippet is taken from below website and fixed
						if (temp[y] >= '0' && temp[y] <= '9')
						{  // bounds
							count[y] = temp[y] - '0';
							// multiply by 16 because of 16^1*hex digit
							count[y] *= 16;
						}
						else if (temp[y] >= 'A' && temp[y] <= 'F')
						{
							// take difference between temp and 'A' then plus 10
							count[y] = temp[y] - 'A' + 10;
							count[y] *= 16;
						}
					}
					else
					{
						if (temp[y] >= '0' && temp[y] <= '9')
						{
							// we're not multiplying by 16 because it's 16^0 digit
							count[y] = temp[y] - '0';
						}
						else if (temp[y] >= 'A' && temp[y] <= 'F')
						{
							count[y] = temp[y] - 'A' + 10;
						}
					}
					// get two digit value's sum and assign it to hexint
					hexint += count[y];
				}
				// assigning summed values to foBin
				foBin[a / 2] = (byte)hexint;
			}
		}



	}
}
	    


