using System;

namespace Recreation_Room_Problem_Statement
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var message = string.Empty;
            var generalInfo = new GeneralInfo();
            while (true)
            {
                generalInfo.DisplayDetails(out message);
                if (!string.IsNullOrWhiteSpace(message))
                {
                    Console.WriteLine(message);
                    if (generalInfo.Genders.Count<3)
                    {
                        continue;
                    }
                    break;
                }
            }
            Console.ReadLine();
        }
        
    }
}
