using System;


namespace Test_Lucky_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.WriteLine("Please input your ticket");
            do
            {
                string strTicket = null;
                int firstHalfTicket = 0;
                int secondHalfTicket = 0;
                bool check = true;

                //check input number,if it has 4-5 digits, add 0 if number contains an odd number of digits
                while (check) 
                {
                    
                    strTicket = Console.ReadLine();
                    strTicket = strTicket.Replace(" ", string.Empty);
                    // quit app
                    if (strTicket == "q" || strTicket == "Q") { return; }

                    if (strTicket.Length > 8 || strTicket.Length < 4 || int.TryParse(strTicket, out _) == false)
                    {
                        Console.WriteLine("Your ticket invalid, enter valid ticket number from 4 to 8");
                    }
                    else if (strTicket.Length % 2 != 0)
                    {
                        strTicket = "0" + strTicket; 
                        Console.WriteLine("In your ticket was added 0 at the beggining"); 
                        check = false;
                    }
                    else check = false;
                }
                // Parse ticket string to int array
                int[] ticketArray = new int[8];
                int i = 0;
                foreach (char c in strTicket)
                {
                    check = int.TryParse(c.ToString(), out ticketArray[i]);
                    i++;
                }
                int counter = strTicket.Length / 2;
                for (int j = 0; j < counter; j++)
                {
                    firstHalfTicket += ticketArray[j];
                }
                for (int j = counter; j < strTicket.Length; j++)
                {
                    secondHalfTicket += ticketArray[j];
                }
                if (firstHalfTicket == secondHalfTicket)
                {
                    Console.WriteLine("Your ticket is lucky");
                    Console.WriteLine("Enter the next number of ticket or press Q or q to Exit");

                }
                else
                {
                    Console.WriteLine("Your ticket is unlucky");
                    Console.WriteLine("Enter the next number of ticket or press Q or q to Exit");
                }
            } while (repeat == true);
        }

    
    }
}
