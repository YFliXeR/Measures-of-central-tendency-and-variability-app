using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    class Program
    {   
        static void Main(string[] args)
        {
            
            // Initialize variables
            int input = 0;
            List<int> integerlist = new List<int>();

            // Get input from user until they enter -1 to stop
            while (input != -1)
            {
            Console.Write("Enter list of integers(-1 to stop): ");
            input = Convert.ToInt32(Console.ReadLine());
                if (input != -1) 
                {
                    // Add input to list if it's not -1
                    integerlist.Add(input);
                }

            }
            

            // Print out the list of integers entered
            foreach (int num in integerlist)
            {   
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine("General types of measurement: - ");
            Console.WriteLine();
            Console.WriteLine("1- Measure of central tendency");
            Console.WriteLine("2- Measure of variability");
            Console.WriteLine();

            Console.Write("Enter the general type of measurement: ");
            int measurement = Convert.ToInt32(Console.ReadLine());
            if (measurement == 1)
            {
                // If user selected "measure of central tendency", show options
                Console.WriteLine();
                Console.WriteLine("List of Central Tendancy Measurements:");
                Console.WriteLine(); 
                Console.WriteLine("1.1 Mean");
                Console.WriteLine("1.2 Mode");
                Console.WriteLine("1.3 Median");
                Console.WriteLine();

                // Get input from user to choose from one of the options
                Console.Write("Enter the required calculation: ");
                double calculation = Convert.ToDouble(Console.ReadLine());
                switch (calculation) 
                {
                    case 1.1: //Mean

                        // Calculate the mean of the list
                        double mean = (double)integerlist.Sum() / integerlist.Count; 
                        Console.WriteLine("The Mean of a set of values equals (sum(values)/count(values)");
                        Console.WriteLine("The Mean of the entered data set is: " + mean);
                        break;

                    case 1.2: //Mode

                        // Calculate the mode of the list
                        int maxCount = 0;
                        int mode = 0;
                        foreach (int num in integerlist)
                        {
                            int count = integerlist.Count(n => n == num); //MEH
                            if (count > maxCount)
                            {
                                maxCount = count;
                                mode = num;
                            }
                        } 
                        Console.WriteLine("The Mode of a set of values is the value repeated most of time in central set");
                        Console.WriteLine("The Mode of the entered data set is: " + mode);
                        break;

                    case 1.3: //Median

                        // Calculate the median of the list
                        // Sort the list in ascending order
                        integerlist.Sort();
                        int count_median = integerlist.Count;
                        double median;
                        if (count_median % 2 == 0) // if count is even
                        {
                            int midIndex = count_median / 2;
                            // calculate the average of the two middle values
                            median = (integerlist[midIndex - 1] + integerlist[midIndex]) / 2.0;

                            Console.WriteLine("The Median of a set of even number of values is the average of the two middle values");
                            Console.WriteLine("The Median of the entered data set is: " + median);
                        }
                        else // if count is odd
                        {
                            int midIndex = (count_median - 1) / 2;
                            // middle value is the median
                            median = integerlist[midIndex];

                            Console.WriteLine("The Median of a set of odd number of values is the middle value");
                            Console.WriteLine("The Median of the entered data set is: " + median);

                        }
                        break;    
                }


            }
            else if (measurement == 2)
            {
                // If the user selects 2 for the general type of measurement, display the list of Central Tendency Measurements
                Console.WriteLine("List of Central Tendency Measurements:");
                Console.WriteLine();
                Console.WriteLine("2.1 Range");
                Console.WriteLine("2.2 Variance");
                Console.WriteLine();
                Console.Write("Enter the required calculation: ");

                // Get input from user to choose from one of the options
                double calculation = Convert.ToDouble(Console.ReadLine());
                switch (calculation)
                {
                    case 2.1: //Range

                        // Calculate the range by subtracting the minimum value from the maximum value in the list
                        double range = integerlist.Max() - integerlist.Min(); 
                        Console.WriteLine("The Range of a set of values is the difference between the maximum value and the minimum value");
                        Console.WriteLine("The range of the entered data set is: " + range);
                        break;

                    case 2.2: //Variance
        
                        // Calculate the variance by finding the average of the squared differences between each value and the mean
                        double mean = integerlist.Sum() / (double)integerlist.Count;
                        double variance = 0;
                        foreach (int num in integerlist)
                        {
                            variance += Math.Pow(num - mean, 2);
                        }
                        variance /= integerlist.Count;
                        Console.WriteLine("The variance of a set of values is calculated by taking the average of the squared differences between each value and the mean");
                        Console.WriteLine("The variance of the entered data set is: " + variance);
                        break;
                }
            }
        }   
    }

}


 

