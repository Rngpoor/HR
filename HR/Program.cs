// Reza Naghipoor

using System.Transactions;

namespace Company
{
    class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
 
    }

    class HR
    {
        static public void main(string[] args)
        {
            string recruitment = "fire";
            switch (recruitment)
            {
                //E=Enter or recruitment
                //F=fired
                case "E":
                    Console.WriteLine("please enter Id, Name");   
                    Console.Write("Id:    ");
                    Console.ReadLine();
                    Console.Write("Name:   ");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("He was succesfully hired for this company");
                    Console.ResetColor();
                    break;
                case "F":
                    Console.WriteLine("please enter Id, Name");
                    Console.Write("Id:    ");
                    Console.ReadLine();
                    Console.Write("Name:   ");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("He was succesfully Fired");
                    Console.ResetColor();
                    break;
                
            }
        }
        employee Boss = new employee { Id = 1, Name = "ali sadeghi" };
        employee E1 = new employee { Id = 123, Name = "Reza Mirzaie" };
        employee E2 = new employee { Id = 456, Name = "Hamed Beigloee" };
        


    }
    class finance
    {
        employee Boss = new employee { Id = 1, salary = 1500000000 };
        employee E1 = new employee { Id = 123, salary=200000 };
        employee E2 = new employee { Id = 123, salary = 200000 };
    }
}


            