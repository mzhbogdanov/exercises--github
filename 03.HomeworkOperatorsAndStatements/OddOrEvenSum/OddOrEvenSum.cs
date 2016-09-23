using System;

        class OddOrEvenSum
    {
            static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //here is how numbers we will input, i will use 4 for example
            int sum = 0; // this sum will be used like a container to save every single next input number 
                for (int i=0; i<n; i++) // here we start a loop, whos count first "n" numbers in this case 4
                {
                    int b = int.Parse(Console.ReadLine()); // initialization a variable "b"(this is 1st from first 4 numbers
                    sum = sum + b; // this sum is first sum(from first N numbers in our case 4)
                    Console.WriteLine("first sum =" + sum);
                }
                
                int sum1 = 0;
                for (int i = 0; i < n; i++ ) // same loop like upper, but this count numbers for second "n" numbers
                {
                    int c = int.Parse(Console.ReadLine()); // here is the first variable from second "n" numbers
                    sum1 = sum1 + c;
                    Console.WriteLine("second sum =" + sum1);
                }
                if (sum == sum1) // here we use a conditional statement to check, equality of the first and second sums
                {
                    Console.WriteLine("Yes, sum = " + sum);
                }
                else
                {
                    double diff =Math.Abs(sum-sum1); // this variable , show the difference between sums in Absolute value
                    Console.WriteLine("No, diff =" + diff);
                }

                Console.ReadLine();

        }
    }

