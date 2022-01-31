using System;
using System.Collections.Generic;

namespace Recreation_Room_Problem_Statement
{
    public class GeneralInfo
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Members = new List<string>();
        public List<string> Genders = new List<string>();
        public void DisplayDetails(out string msg)
        {
            try
            {
                msg = "";
                Console.WriteLine(@"Welcome to the Booking Counter
Press Enter to Continue...");
                Console.WriteLine("Please Enter your Name");
                Name = Console.ReadLine();
                Console.WriteLine(@"Please Enter your Gender
Enter M for Male and F for Female");
                Gender = Console.ReadLine();
                if (Gender.Trim().Length > 1 || !(Gender.Trim().ToUpper().StartsWith("M") || Gender.Trim().ToUpper().StartsWith("F")))
                {
                    while (true)
                    {
                        if (validateDetails(Gender))
                            break;
                    }

                }
                Members.Add(Name.Trim());
                Genders.Add(Gender.Trim());
                if (Genders.Count > 1)
                {
                    validateGender(Genders, Genders[0], out msg);
                }
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            
        }
        public bool validateDetails(string gender)
        {
            try
            {
                Console.WriteLine(@"Please Enter Correct Value
Enter M for Male and F for Female");
                Gender = Console.ReadLine();
                if (Gender.Trim().Length > 1 || !(Gender.Trim().ToUpper().StartsWith("M") || Gender.Trim().ToUpper().StartsWith("F")))
                {
                    return false;

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public void validateGender(List<string> Genders,string firstGender,out string message)
        {
            try
            {
                message = "";
                if (Genders.Count > 3)
                {
                    message = "Maximum of only 3 Members allowed";
                }
                else
                {
                    for (int i = 0; i < Genders.Count; i++)
                    {
                        if (Genders[i].ToUpper() != firstGender.ToUpper())
                        {
                            message = "Both Male and Female Cannot be in Recreation Room";
                            this.Genders.RemoveAt(i);
                            this.Members.RemoveAt(i);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                message = ex.Message;
            }
            
            
        }
    }
}
