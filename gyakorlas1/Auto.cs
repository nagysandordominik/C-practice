namespace gyakorlas;

    internal class Auto
    {
        public string name;
        public int horsepower;
        
        public Auto()
        {
            Console.WriteLine("Give a horsepower:");
            this.horsepower = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Give a name");
            this.name = Console.ReadLine();
            
            Console.WriteLine(name + " has been created");
        }

        public void Drive()
        {
            Console.WriteLine(name +" is driving with " + horsepower + " horsepower. ");
        }

        public void Stop()
        {
            Console.WriteLine("Press a number");
            string userInput = Console.ReadLine();
            if (userInput == "1" )
            {
                Console.WriteLine(name+ " stopped");
            }
            else
            {
                Console.WriteLine(name +" is still going");
            }
        }
    }