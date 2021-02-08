using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChallengeBluefragments
{
    class Program
    {

        static void Main(string[] args)
        {

            // ------------------------------------------    Challenge 101  ----------------------------------------------- //
            #region

            //  Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.

            // Examples:

            // FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]
            // FindMinMax([2334454, 5]) ➞ [5, 2334454]
            // FindMinMax([1]) ➞ [1, 1]


            int[] Listen1 = new int[] { 1, 2, 3, 4, 5 };
            int[] Listen2 = new int[] { 1 };
            int[] Listen3 = new int[] { 2334454, 5 };

            Console.WriteLine("// ------------------    Challenge 101  --------------------- //");
            Console.WriteLine();
            string result1 = string.Join(",", Listen1);
            string result2 = string.Join(",", Listen2);
            string result3 = string.Join(",", Listen3);
            Console.WriteLine("Min og max for [" + result1 + "] er: " + GetMaxandMin(Listen1));
            Console.WriteLine("Min og max for [" + result2 + "] er: " + GetMaxandMin(Listen2));
            Console.WriteLine("Min og max for [" + result3 + "] er: " + GetMaxandMin(Listen3));
            Console.WriteLine();


            // -------- Funktion ---------- //

            static string GetMaxandMin(int[] array)
            {

                // Jeg initialiserer de to variable til det første element i array'et
                int max = array[0];
                int min = array[0];

                // Jeg looper igennem array'et og finder min og max
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }

                
               
                return "[" + min + "," + max + "]";
               
            }


            #endregion



            // ------------------------------------------    Challenge 102  ----------------------------------------------- //

            #region


            // Create a function that accepts a string of a person's first and last name 
            // and returns a string with the first and last name swapped.

            // Examples:
            //    NameShuffle("Donald Trump") ➞ "Trump Donald"
            //    NameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"
            //    NameShuffle("Seymour Butts") ➞ "Butts Seymour"

            // ------- Løsning:

            string Navn1 = new string("Donald Trump");
            string Navn2 = new string("Rosie O'Donnell");
            string Navn3 = new string("Seymour Butts");

            Console.WriteLine("// ------------------    Challenge 102  --------------------- //");
            Console.WriteLine();
            Console.WriteLine("Navnet: '" + Navn1 + "'omvendt er: '" + Navnebyt(Navn1) + "'");
            Console.WriteLine("Navnet: '" + Navn2 + "'omvendt er: '" + Navnebyt(Navn2) + "'");
            Console.WriteLine("Navnet: '" + Navn3 + "'omvendt er: '" + Navnebyt(Navn3) + "'");
            Console.WriteLine();

            // -------- Funktion ---------- //

            static string Navnebyt(string navn)
            {

                // Jeg splitter tekststrengen ved mellemrum og tilgår derefter elementerne i array'et
                string[] split = navn.Split(" ");

                
                return (split[1] + " " + split[0]);
              


            }




            #endregion

            // ------------------------------------------    Challenge 103  ----------------------------------------------- //

            #region



            // Create a function that returns true if an input string contains only uppercase or only lowercase letters.

            // Examples:
            // SameCase("hello") ➞ true
            // SameCase("HELLO") ➞ true
            // SameCase("Hello") ➞ false
            // SameCase("ketcHUp") ➞ false

            string Ord1 = new string("hello");
            string Ord2 = new string("HELLO");
            string Ord3 = new string("Hello");
            string Ord4 = new string("ketcHUp");

            Console.WriteLine("// ------------------    Challenge 103  --------------------- //");
            Console.WriteLine();
            Console.WriteLine("Indeholder ordet: '" + Ord1 + "' udelukkende store eller små bogstaver: " + SameCase(Ord1));

            Console.WriteLine($"Indeholder ordet: '" + Ord2 + "' udelukkende store eller små bogstaver: " + SameCase(Ord2));
            Console.WriteLine($"Indeholder ordet: '" + Ord3 + "' udelukkende store eller små bogstaver: " + SameCase(Ord3));
            Console.WriteLine($"Indeholder ordet: '" + Ord4 + "' udelukkende store eller små bogstaver: " + SameCase(Ord4));
            Console.WriteLine();


            // ----------- Funktion ----------- //


            static bool SameCase(string ord)
            {
                // Jeg tester om strengen ikke indeholder små bogstaver, altså kun store bogstaver
                if (!ord.Any(char.IsLower))
                {
                    return true;
                }

                // Jeg tester om strengen ikke indeholder store bogstaver, altså kun små bogstaver
                else if (!ord.Any(char.IsUpper))
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }


            #endregion


            // ------------------------------------------    Challenge 104  ----------------------------------------------- //

            #region


            // An isogram is a word that has no duplicate letters. 
            // Create a function that takes a string and returns either true or false depending on whether or not it's an "isogram".

            // Examples:
            // IsIsogram("Algorism") ➞ true
            // IsIsogram("PasSword") ➞ false
            // Not case sensitive.
            // IsIsogram("Consecutive") ➞ false


            string Isogram1 = new string("Algorism");
            string Isogram2 = new string("PasSword");
            string Isogram3 = new string("Consecutive");


            Console.WriteLine("// ------------------    Challenge 104  --------------------- //");
            Console.WriteLine();

            Console.WriteLine("Er ordet '" + Isogram1 + "' et Isogram: " + is_isogram(Isogram1));
            Console.WriteLine("Er ordet '" + Isogram2 + "' et Isogram: " + is_isogram(Isogram2));
            Console.WriteLine("Er ordet '" + Isogram3 + "' et Isogram: " + is_isogram(Isogram3));
            Console.WriteLine();


            // ------------ Funktion ------------ //

            static bool is_isogram(string str)
            {
                
                bool isogram = true;

                // jeg laver alle bogstaver om til små bogstaver for at sikre at der ikke skelnes mellem store og små bogstaver
                string lowered = str.ToLower();


                
                for (int i = 0; i < lowered.Length - 1; i++)
                {

                    // Jeg konverterer templetter til en tekststreng, da jeg vil sammenligne to strings,
                    // og ikke kan sammenligne char med string
                    string tempLetter = lowered[i].ToString();

                    // jeg lægger 1 til i for at sikre, at jeg ikke tjekker bogstavet mod sig selv, men i stedet det efterfølgende bogstav
                    for (int j = i + 1; j < lowered.Length; j++)
                    {

                        if (tempLetter == lowered[j].ToString())
                        {
                            isogram = false;
                            break;
                        }
                    }
                }

                return isogram;
            }


            #endregion

            // ------------------------------------------    Challenge 105  ----------------------------------------------- //
            #region

            // Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. 
            // For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.

            // Examples:
            // MonthName(3) ➞ "March"
            // MonthName(12) ➞ "December"
            // MonthName(6) ➞ "June"


            int Number1 = 1;
            int Number2 = 5;
            int Number3 = 8;
            int Number4 = 10;

            Console.WriteLine("// ------------------    Challenge 105  --------------------- //");
            Console.WriteLine();

            Console.WriteLine("Måned nr " + Number1 + " er: " + ReturnMonth(Number1));
            Console.WriteLine("Måned nr " + Number2 + " er: " + ReturnMonth(Number2));
            Console.WriteLine("Måned nr " + Number3 + " er: " + ReturnMonth(Number3));
            Console.WriteLine("Måned nr " + Number4 + " er: " + ReturnMonth(Number4));
            Console.WriteLine();

            // ---------------- Funktion ----------------- //

            static string ReturnMonth(int number)
            {

                // Metoden "GetMonthName" returnerer det fulde navn for den måned tallet repræsenterer
                string Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(number);

                return Month;
            }


            #endregion

            // ------------------------------------------    Challenge 106  ----------------------------------------------- //

            #region

            // Create a function that takes a string and replaces each letter with its appropriate position in the alphabet. 
            // "a" is 1, "b" is 2, "c" is 3, etc, etc.

            // Examples:
            // AlphabetIndex("Wow, does that work?") ➞ "23 15 23 4 15 5 19 20 8 1 20 23 15 18 11"
            // AlphabetIndex("The river stole the gods.") ➞ "20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19"
            // AlphabetIndex("We have a lot of rain in June.") ➞ "23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5"


            string Sentence1 = "Wow, does that work?";
            string Sentence2 = "The river stole the gods.";
            string Sentence3 = "We have a lot of rain in June.";

            Console.WriteLine("// ------------------    Challenge 106  --------------------- //");
            Console.WriteLine();

            Console.WriteLine($"Sætning 1: {Sentence1} ");
            Console.WriteLine(AlphabetIndex(Sentence1));
            Console.WriteLine();
            Console.WriteLine($"Sætning 2: {Sentence2} ");
            Console.WriteLine(AlphabetIndex(Sentence2));
            Console.WriteLine();
            Console.WriteLine($"Sætning 3: {Sentence3} ");
            Console.WriteLine(AlphabetIndex(Sentence3));

            Console.WriteLine();



            // ----------- Funktion ------------ //



            static string AlphabetIndex(string str)
            {
                // En konstant (baseret på ASCII-tabellen) anvendes til at udregne positionerne; a har ASCII-værdien 97 
                int ASCII = 96;

                // laver alle bogstaver om til små bogstaver
                string lower = str.ToLower();

                // jeg fjerner alt, der ikke er bogstaver
                string lettersOnly = Regex.Replace(lower, "[^a-z]", "");

                StringBuilder sb = new StringBuilder();

                sb.Append("'");

                // så looper jeg igennem tekststrengen lettersOnly
                for (int i = 0; i < lettersOnly.Length; i++)
                {

                    
                    // Jeg konverterer char til int og får herved ASCII-værdien og ved at - 96 
                    // så jeg får index-tallet for det pågældende bogstav.
                    sb.Append((int)lettersOnly[i] - ASCII);

                    // hvis det ikke er sidste bogstav i tekststrengen, så tilføjes mellemrum.
                    if (i < lettersOnly.Length - 1)

                        sb.Append(" ");




                }
                sb.Append("'");
                return sb.ToString();

            }






            #endregion

            // --------------------------------------------------- Challenge 201 ------------------------------------- //

            #region


            //Your task is to create a function that takes a string, transforms all but the last four 
            // characters into "#" and returns the new masked string.

            // Examples:
            // Maskify("4556364607935616") ➞ "############5616"
            // Maskify("64607935616") ➞ "#######5616"
            // Maskify("1") ➞ "1"
            // Maskify("") ➞ ""

            string tal1 = "4556364607935616";
            string tal2 = "64607935616";
            string tal3 = "1";
            string tal4 = "12345";



            Console.WriteLine("// ------------------    Challenge 201  --------------------- //");
            Console.WriteLine();
            Console.WriteLine("'" + Maskify(tal1) + "'");
            Console.WriteLine("'" + Maskify(tal2) + "'");
            Console.WriteLine("'" + Maskify(tal3) + "'");
            Console.WriteLine("'" + Maskify(tal4) + "'");

            // ----------- Funktion ------------- //

            static string Maskify(string str)
            {

                StringBuilder sb = new StringBuilder();

                // I tilfælde af at tekststrengen er mere end 4 karakterer
                if (str.Length > 4)
                {

                    for (int i = 0; i < str.Length; i++)
                    {
                        string temp = str[i].ToString();

                        // alle karakterer skjules på nær de sidste fire 
                        if (i + 4 >= str.Length)
                        {
                            sb.Append(temp.ToString());
                        }
                        else
                        {
                            sb.Append("#");
                        }

                    }


                }
                else
                {
                    sb.Append(str);
                }

                return sb.ToString();
            }


            #endregion

            // --------------------------------------------------- Challenge 202 ------------------------------------- //

            #region

            // Create a function that takes a positive integer and returns a string expressing how the 
            // number can be made by multiplying powers of its prime factors.

            // Examples:
            // ExpressFactors(2) ➞ "2"
            // ExpressFactors(4) ➞ "2^2"
            // ExpressFactors(10) ➞ "2 x 5"
            // ExpressFactors(60) ➞ "2^2 x 3 x 5"


            Console.WriteLine("// ------------------    Challenge 202 Ny løsning  --------------------- //");
            Console.WriteLine();
            Console.WriteLine("Indtast et positivt tal: ");
            int tal01 = int.Parse(Console.ReadLine());
            Console.WriteLine(primeFactorFinder(tal01));
            Console.WriteLine();

            static string primeFactorFinder(int n)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 2; 1 < n; i++)
                {
                    // Initialiserer tællevariabel x 
                    int x = 0;
                    // så laver jeg et while loop, for at tælle hvor mange gange det pågældende tal er primfaktor
                    while (n % i == 0)
                    {
                        n /= i;
                        x++;
                    }
                    if (x == 1)
                    {
                        sb.Append(i + " x ");
                    }
                    else if (x > 1)
                    {
                        sb.Append(i + "^" + x + " x ");
                    }

                }

                // Her fjerner jeg de to sidste karakterer, da jeg jo tilføjer/appender " x " efter hver primfaktor
                sb = sb.Remove(sb.Length - 2, 2);
                return sb.ToString();
            }





            #endregion



            // -------------------------------------------------------- Challenge 203 ---------------------------------------------- //
            #region


            //  Create a function that finds a target number in a list of prime numbers.Implement a binary search 
            //  algorithm in your function. The target number will be from 2 through 97.If the target is prime then 
            //  return "yes" else return "no".

            //  Examples: int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }
            //  IsPrime(primes, 3) ➞ "yes"
            //  IsPrime(primes, 4) ➞ "no"
            //  IsPrime(primes, 67) ➞ "yes"
            //  IsPrime(primes, 36) ➞ "no"


            Console.WriteLine("// ------------------    Challenge 203  --------------------- //");
            Console.WriteLine();

            Console.WriteLine("Indtast et positivt tal mellem 2 og 97:");
            int tal = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

            Console.WriteLine("Er det et primtal: " + IsPrime(primes, tal));
            Console.WriteLine();

            static string IsPrime(int[] primes, int tal)
            {
                StringBuilder sb = new StringBuilder();

                // Jeg søger i array'et for at finde et evt. match med input-paramteren "tal"
                int res = Array.Find(primes, ele => ele.Equals(tal));

                if (res != 0)
                {
                    sb.Append("Yes");
                }
                else
                {
                    sb.Append("No");
                }
                return sb.ToString();
            }




            #endregion

            // -------------------------------------------------------- Challenge 204 ---------------------------------------------- //

            #region


            // Create a function to return the amount of potatoes there are in a string.

            // Examples:
            // Potatoes("potato") ➞ 1
            // Potatoes("potatopotato") ➞ 2
            // Potatoes("potatoapple") ➞ 1

            string potato1 = "potatopotatopotatopotato";
            string potato2 = "potatopotato";
            string potato3 = "potatoapple";
            string potato4 = "potato";


            Console.WriteLine("// ------------------    Challenge 204  --------------------- //");
            Console.WriteLine();
            Console.WriteLine("Ordet 'potato' indgår " + Potatoes(potato1) + " gang/gange i strengen: " + potato1);
            Console.WriteLine("Ordet 'potato' indgår " + Potatoes(potato2) + " gang/gange i strengen: " + potato2);
            Console.WriteLine("Ordet 'potato' indgår " + Potatoes(potato3) + " gang/gange i strengen: " + potato3);
            Console.WriteLine("Ordet 'potato' indgår " + Potatoes(potato4) + " gang/gange i strengen: " + potato4);
            Console.WriteLine();
            // ----------------- Funktion -------------- //

            static int Potatoes(string str)
            {
               
                // splitter strengen op i et array og trækker en fra
                int antalpotato = str.Split("potato").Length - 1;

                return antalpotato;
            }


            #endregion

            // -------------------------------------------------------- Challenge 205 ---------------------------------------------- //

            #region


            // Create two functions that take a string and an array and returns a coded or decoded message.

            // The first letter of the string, or the first element of the array represents the Character Code of that letter.
            // The next elements are the differences between the characters: e.g.A +3 --> C or z -1 --> y.

            // Examples:
            // Encrypt("Hello") ➞ [72, 29, 7, 0, 3]
            // H = 72, the difference between the H and e is 29 (upper- and lowercase).
            // The difference between the two l's is obviously 0.
            // Decrypt([ 72, 33, -73, 84, -12, -3, 13, -13, -68 ]) ➞ "Hi there!"
            // Encrypt("Sunshine") ➞ [83, 34, -7, 5, -11, 1, 5, -9]

            Console.WriteLine("// ------------------    Challenge 205  --------------------- //");
            Console.WriteLine();
            Console.WriteLine(Encrypt("Sunshine"));
            Console.WriteLine();
            Console.WriteLine(Encrypt("Hello"));
            Console.WriteLine();

            static string Encrypt(string tekst)
            {

                StringBuilder sb = new StringBuilder();

                sb.Append("[");

                // Konverterer input-parameteren til et char-array
                char[] tektsarray = tekst.ToCharArray();


                for (int i = 0; i < tektsarray.Length; i++)
                {
                    if (i == 0)
                    {
                        // Jeg får ASCII-værdien ved at caste til INT
                        sb.Append((int)tektsarray[i]);
                        sb.Append(", ");

                    }
                    else
                    {
                       
                        // Da det er den nuværende ASCII-værdi lagt sammen
                        // med den foregående, der giver ASCII-værdien for den nuværende,
                        // så laver jeg nedenstående regnestykke.
                        sb.Append((int)tektsarray[i] - (int)tektsarray[i - 1]);
                        if (i < tektsarray.Length - 1)
                        {
                            sb.Append(", ");
                        }
                    }
                }
                sb.Append("]");
                return sb.ToString();
            }


            // ---------------------------------------- decrypt ------------------------------------ //

            // Decrypt([ 72, 33, -73, 84, -12, -3, 13, -13, -68 ]) ➞ "Hi there!"

            int[] numbersArr = { 72, 33, -73, 84, -12, -3, 13, -13, -68 };

            Console.WriteLine();
            Console.WriteLine(Decrypt(numbersArr));
            Console.WriteLine();

            static string Decrypt(int[] numbers)
            {

                StringBuilder sb = new StringBuilder();

                sb.Append("'");
                // Da det er summen af alle de foregående ASCII-værdier lagt sammen
                // med den nuværende, der giver ASCII-værdien for den pågældende,
                // så laver jeg en "sum"-variabel.
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum = sum + numbers[i];
                    
                    sb.Append((char)sum);
                }

                sb.Append("'");

                return sb.ToString();
            }


            #endregion
        }






    }
}













