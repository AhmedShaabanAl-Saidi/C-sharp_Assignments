using Assignment1_C_.Enums;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Permissions
            //Users user = new Users();

            //user.Id = 1;
            //user.Name = "Ahmed";
            //user.Permissions = (Permissions)14;

            ////user.Permissions = user.Permissions ^ Permissions.Delete;
            ////user.Permissions = user.Permissions | Permissions.Read;
            ////user.Permissions = user.Permissions & Permissions.Read;


            //Console.WriteLine($"User Id => {user.Id}"  );
            //Console.WriteLine($"User Name => {user.Name}");
            //Console.WriteLine($"User Permissions => {user.Permissions}");

            /////////////////////////////////////////////////////////////////////////////////////

            // Part 2
            // 1
            // WeekDays
            //string[] weekDays= Enum.GetNames(typeof(WeekDays));
            //foreach (var day in weekDays)
            //    Console.WriteLine(day);

            ////////////////////////////////////////////////////////////////////////////////////

            // Part 2
            // 2
            // Seas on
            //Console.WriteLine("Please Enter The Season Name You Want know the Months in it :");

            //object SeasonName;
            //bool isParsed;
            //do
            //{
            //    isParsed = Enum.TryParse(typeof(SeasOn), Console.ReadLine(), true, out SeasonName);
            //    if (!isParsed)
            //        Console.WriteLine("Invalid Season Name, Please Enter a valid Season Name");
            //}
            //while (!isParsed);

            //if ((SeasOn)SeasonName == SeasOn.Summer)
            //    Console.WriteLine("The Range for Seasons is June to August");
            //else if((SeasOn)SeasonName == SeasOn.Spring)
            //    Console.WriteLine("The Range for Seasons is March to May");
            //else if ((SeasOn)SeasonName == SeasOn.Winter)
            //    Console.WriteLine("The Range for Seasons is December to February");
            //else if ((SeasOn)SeasonName == SeasOn.Autumn)
            //    Console.WriteLine("The Range for Seasons is September to November");

            /////////////////////////////////////////////////////////////////////////

            // Part 2
            // 3
            // Permissions
            //Users user = new Users();

            //user.Id = 1;
            //user.Name = "Ahmed";
            //user.Permissions = (Permissions)15;


            //Console.WriteLine($"User Permissions => {user.Permissions}"); // Read, Write, Execute, Delete

            //user.Permissions = user.Permissions ^ Permissions.Delete; 


            //Console.WriteLine($"User Id => {user.Id}");
            //Console.WriteLine($"User Name => {user.Name}");
            //Console.WriteLine($"User Permissions => {user.Permissions}"); // Read, Write, Execute


        }
    }
}
