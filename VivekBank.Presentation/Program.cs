using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivekBank.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mainManuChoice = -1;

            //Displaying title
            Console.WriteLine("**************************Vivek Bank********************");
            Console.WriteLine("::Login Page::");
            //Declare variable to store user name and password
            string userName = null, password = null;

            //read userName from keyboard
            Console.Write("Username:");
            userName = Console.ReadLine(); 

            //read password from keyboard only if username is entered
            if(userName != "") 
            {
                //read password from keyboard
                Console.Write("Password:");
                password = Console.ReadLine();
            }
            if(userName=="Vivek" && password == "VIVEK@singh")
            {
                do
                {
                    Console.WriteLine("To Do: Main menu here");
                    Console.WriteLine("1.Customer");
                    Console.WriteLine("2.Accounts");
                    Console.WriteLine("3.Funds Transfer");
                    Console.WriteLine("4.Fund Transfer Statement");
                    Console.WriteLine("5.Account Statement");
                    Console.WriteLine("6.Loan Department");
                    Console.WriteLine("7.Home Loan");
                    Console.WriteLine("0. Ecit");
                    Console.WriteLine("Enter your coice");
                    mainManuChoice = int.Parse(Console.ReadLine());
                    switch (mainManuChoice)
                    {
                        case 1://To Do : Display Customer menu
                            CustomerMenu();
                            break;
                        case 2://To Do : Display Account Menu
                            AccountsMenu();
                            break;

                        case 3://To Do: Display Funds Transfer
                            break;
                        case 4://To Display Fund Statement 
                            break;
                        case 5://To Do Display Account Statement
                            break;
                        case 6: //To Display Home Department
                            break;
                        case 7: //To Display Home Loan
                            break;
                        case 8://To Do Exit 
                            break;

                    }
                } while (mainManuChoice != 0);
            }
            Console.WriteLine("Thank you! Visit again");
            Console.ReadKey();

            
        }
        static void CustomerMenu()
        {
            //variable to store customers menu choice
            int customersMenu = -1;
            do
            {
                Console.WriteLine("\n :::Customers menu:::");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2.Delete Customer");
                Console.WriteLine("3.Update Customer");
                Console.WriteLine("4.View Customer");
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("Enter choice");
                customersMenu = Convert.ToInt32(Console.ReadLine());    

            } while (customersMenu != 0);

        }

        static void AccountsMenu()
        {
            //variable to store customers menu choice
            int customersMenu = -1;
            do
            {
                Console.WriteLine("\n :::Customers menu:::");
                Console.WriteLine("1. Add Accounts");
                Console.WriteLine("2.Delete Accounts");
                Console.WriteLine("3.Update Accounts");
                Console.WriteLine("4.View Accounts");
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("Enter choice");
                customersMenu = Convert.ToInt32(Console.ReadLine());

            } while (customersMenu != 0);

        }
    }
}
