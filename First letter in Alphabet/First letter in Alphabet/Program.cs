using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace First_letter_in_Alphabet
{
    class Program
    {
        /*
             PROGRAMME	:	First Letter in Alphabet Assignment

             OUTLINE	:	The program lets the user type in a string where the program would give you an output
                of what letter in the alphabet comes first. The program lets you use upper or lowercase 
                letters but will show an invalid screen when a sign or digit is typed into the name closing
                the console itself. The program works by using Methods, for loops, if and else statments, arrays,
                and bool and while loops to do so. For better understanding comments are presented below telling
                how it works

             PROGRAMMER	:	Methunan Uthayakumar
     
             DATE		:	November 18, 2020
       */
        static void Main(string[] args)
        {
            
            Console.Write(" write any word down and press enter: "); // user inputs a word they want to see what occurs first in the Alphabet 
            string nameInput = Console.ReadLine().ToLower();
            char[] inputLetter = nameInput.ToCharArray(); // puts the word into an array 
            int[] intalpha = new int [inputLetter.Length];


            bool check = false; // boolean which is set to false 
            for (int i = 0; i < inputLetter.Length; i++) // for loop has i as zero and when its less then the strings length executes bottom code then increments i by one
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(nameInput, @"^[a-zA-Z]+$")) // this uses a existing library called RegularExpressions where regex calls it and uses IsMatch to find if the users input nameInput only has letters a-z or A-Z
                { // if the input is true it will then go to the method alphaName where before it goes the ToLower function puts everything in lowercase 
                    check = true;
                    int wordCount = alphaName(inputLetter[i],0);
                    intalpha[i] = wordCount; // puts values into an array
                    
                }
                else 
                { // if its false then it will show a prompt and close the program  
                    check = false;
                    Console.WriteLine("Invalid input, Only add letters no signs, numbers, or blanks allowed \n Console is closing please press enter to close");
                    Console.ReadLine();
                    break;
                }
            }
            
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };

            Array.Sort(intalpha); // sorts the numbers into numerical order
   
            while (check == true ) // while the check is true it will print out the intalpha value that the alphabet array presents from example if intalpha
                                   // is sorted and the first number is a 3 the alphabet array will go to the 3rd letter which is d and would write it down and stop
            {
                 Console.WriteLine(alphabet[intalpha[0]] + " is the first letter press enter to leave");
                 Console.ReadLine();
                break;
            }
             

        }

        static int alphaName(char input, int num) // input is the string the user inputs 
        {

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                if (alphabet[num] == input) // if the statment is true the name written is there it ends and returns the value
                {
                    return num;
                }
                else // it increases the count and returns the value to the method and would loop till the space 
                {
                    return alphaName(input, num + 1);
                }
            
       }
    }
}
