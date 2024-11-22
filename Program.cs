namespace b2task
{
    class Program
    {
        static void Main(string[] args)
        {
             int count;
             do
             {
                 //Console.WriteLine("enter the count of stations");
                 if (!(int.TryParse(Console.ReadLine(), out count)) && count >= 1 && count <= 100)
                 {
                    // Console.WriteLine();
                 }
             } while (!(count >= 1 && count <= 100));
             string input; int max = 0; int difference=0;int helper; 
             int[] getonpassenger = new int[count];
             int[] getoffpassenger = new int[count];
             for (int i = 0; i < count;)
             {
                // Console.WriteLine($"enter the number of passengers getting on and off on {i + 1} station");
                 input = Console.ReadLine();
                 getonpassenger[i] = int.Parse(input.Split(" ")[0]);
                 getoffpassenger[i] = int.Parse(input.Split(" ")[1]);
                 if (getonpassenger[i] >= 0 && getoffpassenger[i] <= 50)
                 {
                    helper = difference + getonpassenger[i];
                    difference = helper - getoffpassenger[i]; 
                    if(difference > max)
                    {
                        max = difference;
                    }
                    i++;
                 }
             }
             Console.WriteLine(max);
           /* Console.Write("Enter the number of stations: ");
            int N = int.Parse(Console.ReadLine());

            int maxPassengers = 0;
            int currentPassengers = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter the number of passengers getting on at station {i + 1}: ");
                int passengersGettingOn = int.Parse(Console.ReadLine());

                Console.Write($"Enter the number of passengers getting off at station {i + 1}: ");
                int passengersGettingOff = int.Parse(Console.ReadLine());

                currentPassengers = currentPassengers + passengersGettingOn - passengersGettingOff;
                maxPassengers = Math.Max(maxPassengers, currentPassengers);
            }

            Console.WriteLine($"Maximum number of passengers: {maxPassengers}");*/

        }
    }
}
    


     

