using System;
using System.IO;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ascend = true;
            bool run = true;
            bool chooseArray = true;
            bool high = true;
            bool low = true;
            int sort;
            int asOrdes;
            int number;            
            int arrayNum;
            int highIndex = 0; 
            int lowIndex = 0;
            string arrayChoice;

            int[] myArray = new int[0];

            //loop to give the user a choice for which array they would like to select 
            while (chooseArray)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-which array would you like to analyse-");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1 : Net_1_256.txt | 4 : Net_1_2048");
                Console.WriteLine("2 : Net_2_256.txt | 5 : Net_2_2048");
                Console.WriteLine("3 : Net_3_256.txt | 6 : Net_3_2048");

                //read user input
                arrayNum = Convert.ToInt32(Console.ReadLine());

                //if the user enters 1 then it changes the string arrayChoice to the corresponding array
                //this string then gets passed into the fileToArray method when called
                if (arrayNum == 1)
                {
                    arrayChoice = "Net_1_256.txt";
                    myArray = new int[256];
                    fileToArray(myArray, arrayChoice);
                    break;
                }
                if (arrayNum == 2)
                {
                    arrayChoice = "Net_2_256.txt";
                    myArray = new int[256];
                    fileToArray(myArray, arrayChoice);
                    break;
                }
                if (arrayNum == 3)
                {
                    arrayChoice = "Net_3_256.txt";
                    myArray = new int[256];
                    fileToArray(myArray, arrayChoice);
                    break;
                }
                if (arrayNum == 4)
                {
                    arrayChoice = "Net_1_2048.txt";
                    myArray = new int[2048];
                    fileToArray(myArray, arrayChoice);
                    break;
                }
                if (arrayNum == 5)
                {
                    arrayChoice = "Net_2_2048.txt";
                    myArray = new int[2048];
                    fileToArray(myArray, arrayChoice);
                    break;
                }
                if (arrayNum == 6)
                {
                    arrayChoice = "Net_3_2048.txt";
                    myArray = new int[2048];
                    fileToArray(myArray, arrayChoice);
                    break;
                }

                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("please enter a valid option");
                    Console.WriteLine("---------------------------");
                }
            }

            //loop for the user to select which sorting algorithm they want to use
            while (run)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Which sorting algorithm would you like to use?");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1 : Bubble Sort");
                Console.WriteLine("2 : Insertion Sort");
                Console.WriteLine("3 : Merge Sort");
                Console.WriteLine("4 : Quick Sort");
                Console.WriteLine("5 : Heap Sort");

                //read user input
                sort = Convert.ToInt32(Console.ReadLine());

                //if the user input is 1 then it asks for ascending or descending
                if (sort == 1)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Do you want to sort in ascending(1) or descending(2)?");
                    Console.WriteLine("-----------------------------------------------------");

                    //reads user input 
                    asOrdes = Convert.ToInt32(Console.ReadLine());

                    //if user input is 1 then it sorts the array in ascending order
                    //calls the bubbleSort method to sort the array
                    //loops through the numbers in the array and prints them to console
                    if (asOrdes == 1)
                    {
                        Sort.bubbleSort(myArray, myArray.Length, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    //if user input is 2 then it sorts the array in descending order
                    //changes ascend bool to false so that it uses the descending sort 
                    //calls the bubbleSort method to sort the array 
                    //loops through the numbers in the array and prints them to console
                    if (asOrdes == 2)
                    {
                        ascend = false;
                        Sort.bubbleSort(myArray, myArray.Length, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    //if user doesnt enter either 1 or 2 then error message is shown and loops back for user input 
                    else
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("please enter a valid option");
                        Console.WriteLine("---------------------------");
                    }
                }
                //repeat of the same code but the sorting method is the one corresponding to the user input
                if (sort == 2)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Do you want to sort in ascending(1) or descending(2)?");
                    Console.WriteLine("-----------------------------------------------------");
                    asOrdes = Convert.ToInt32(Console.ReadLine());

                    if (asOrdes == 1)
                    {
                        Sort.InsertionSort(myArray, myArray.Length, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    if (asOrdes == 2)
                    {
                        ascend = false;
                        Sort.InsertionSort(myArray, myArray.Length, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("please enter a valid option");
                        Console.WriteLine("---------------------------");                        
                    }
                }
            
                if (sort == 3)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Do you want to sort in ascending(1) or descending(2)?");
                    Console.WriteLine("-----------------------------------------------------");
                    asOrdes = Convert.ToInt32(Console.ReadLine());

                    if (asOrdes == 1)
                    {
                        Sort.MergeSort(myArray, myArray.Length, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    if (asOrdes == 2)
                    {
                        ascend = false;
                        Sort.MergeSort(myArray, myArray.Length, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("please enter a valid option");
                        Console.WriteLine("---------------------------");
                    }
                }
            
                if (sort == 4)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Do you want to sort in ascending(1) or descending(2)?");
                    Console.WriteLine("-----------------------------------------------------");
                    asOrdes = Convert.ToInt32(Console.ReadLine());
                    if (asOrdes == 1)
                    {
                        Sort.QuickSort(myArray, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    if (asOrdes == 2)
                    {
                        ascend = false;
                        Sort.QuickSort(myArray, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("please enter a valid option");
                        Console.WriteLine("---------------------------");
                    }
                }
            
                if (sort == 5)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Do you want to sort in ascending(1) or descending(2)?");
                    Console.WriteLine("-----------------------------------------------------");
                    asOrdes = Convert.ToInt32(Console.ReadLine());

                    if (asOrdes == 1)
                    {
                        Sort.HeapSort(myArray, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    if (asOrdes == 2)
                    {
                        ascend = false;
                        Sort.HeapSort(myArray, ascend);
                        foreach (int num in myArray)
                        {
                            Console.WriteLine(num);
                            run = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("please enter a valid option");
                        Console.WriteLine("---------------------------");
                    }
                } 
                //if user doesnt enter 1,2,3,4 or 5 then error message is shown and loops back for user input
                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("please enter a valid option");
                    Console.WriteLine("---------------------------");               
                }              
            }        

            int count = 0;

            //if the array length is 256 then it will print every 10th value to console
            if (myArray.Length == 256)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Every 10th value of array");
                Console.WriteLine("-------------------------");
 
                foreach (int num in myArray)
                {
                    count++;
                    if (count % 10 == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            //if the array length is a different size to 256 (2048) then it will print every 50th value to console
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Every 50th value of array");
                Console.WriteLine("-------------------------");

                foreach (int num in myArray)
                {
                    count++;
                    if (count % 50 == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("please enter a number you would like to search for");
            Console.WriteLine("--------------------------------------------------");
            //reads user input for a number to search for 
            number = Convert.ToInt32(Console.ReadLine());

            bool running = true;
            //calls search method and passes the users number into it
            int index = Search.BinarySearch_R(number, myArray, 0, myArray.Length - 1, ascend);
            int highNum = number;
            int lowNum = number;

            while (running)
            {
                //if the number is not found it returns -1
                if (index == -1)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("number not found");
                    Console.WriteLine("----------------");
                    //when number is not found then does another search for the next highest number
                    while (high)
                    {
                        highNum++;

                        highIndex = Search.BinarySearch_R(highNum, myArray, 0, myArray.Length - 1, ascend);
                        if (highIndex != -1)
                        {
                            high = false;
                        }
                    }
                    //when number is not found then does another search for the next lowest number
                    while (low)
                    {
                        lowNum--;

                        lowIndex = Search.BinarySearch_R(lowNum, myArray, 0, myArray.Length - 1, ascend);
                        if (lowIndex != -1)
                        {
                            low = false;
                        }
                    }
                    //takes the lower number and higher number to find which one has the smallest distance to the users number
                    //then prints the closest number to the console
                    int lowToIndex = (number - lowNum);
                    int highToIndex = (highNum - number);
                    if (lowToIndex < highToIndex)
                    {
                        Console.WriteLine("closest number to your number is: " + lowNum + " at index: " + lowIndex);
                    }
                    else
                    {
                        Console.WriteLine("closest number to your number is: " + highNum + "at index: " + highIndex);
                    }
                    running = false;
                }
                //if the users number is found then it will display the location of the number (index)
                //then runs another search for the same number and will display if it is found again
                else
                {
                    Console.WriteLine("number found at index: " + index);
                    index = Search.BinarySearch_R(number, myArray, index + 1, myArray.Length - 1, ascend);
                    running = false;
                }
            }

            //method for creating an array from a file
            //passes the arrayChoice to the method so it knows which file to put into the array
            static void fileToArray(int[] array, string arrayChoice)
            {
                int counter = 0;
                string line;

                // Read the file
                System.IO.StreamReader file =
                    new System.IO.StreamReader(arrayChoice);
                while ((line = file.ReadLine()) != null)
                {
                    int number = Int32.Parse(line);
                    array[counter] = number;
                    counter++;
                }
                file.Close();

            }


        }
    }
}
