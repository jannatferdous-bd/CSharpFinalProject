using CSharpFinalProject1.Entities;
using CSharpFinalProject1.Enums;
using CSharpFinalProject1.Factory;
using CSharpFinalProject1.Manager;
using CSharpFinalProject1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject1
{
    internal class Program
    {
        public static CustomerRepo repo = new CustomerRepo();
        static void Main(string[] args)
        {
			try
			{
				DoTask();
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
			finally
			{
                Console.ReadLine();
			}
        }

        private static void DoTask()
        {
            Console.WriteLine("\t\t\t\t\tSale Management\r");
            Console.WriteLine("\t\t==================================================\n");
            Console.WriteLine("\t\t\tHow many operation you would like to perform?\n");
            int opCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < opCount; i++)
            {
                Console.WriteLine("\t\t\t\tSelect Operation\n1.-- Read\n2.--Create\n3.-- Update\n4.-- Delete\n5.--Read Single Info");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ShowAllCustomer(0);
                        break;
                    case 2:
                            CreateNewCustomer(); 
                        break;
                    case 3:
                        UpdateCustomer();
                        break;
                    case 4:
                        DeleteCustomer();
                        break;
                    case 5: 
                        ShowCustomerById();
                        break;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;



                }
            }
        }

        private static void UpdateCustomer()
        {
            Console.WriteLine("Enter Customer Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Edit Name");
            string name = Console.ReadLine();
            Console.WriteLine("Edit Email");
            string email = Console.ReadLine();
            Console.WriteLine("Edit CustomerType:1.Regular 2. NewCustomer");
            int ctype = Convert.ToInt32(Console.ReadLine());
            CustomerType type;
            if (ctype == 1)
                type = CustomerType.Regular;
            else
                type = CustomerType.NewCustomer;
            Console.WriteLine("Edit Total Amount");
            double totalAmt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Edit discount percent");
            double pcnt = Convert.ToDouble(Console.ReadLine());
            Customer upCust = new Customer(id, name, email, type, totalAmt, pcnt, 0);
            repo.UpdateCustomer(upCust);
            ShowAllCustomer(0);

        }

        private static void DeleteCustomer()
        {
            Console.WriteLine("Enter Customer Id");
            int id = Convert.ToInt32(Console.ReadLine());
            repo.DeleteCustomer(id);
            ShowAllCustomer(0);

        }

        private static void CreateNewCustomer()
        {
            EnterCustomerType:
            Console.WriteLine("Enter CustomerType:1.Regular 2. NewCustomer");
            int ctype = Convert.ToInt32(Console.ReadLine());
            CustomerType type;
            if (ctype == 1) 
                type = CustomerType.Regular;
            else
                type= CustomerType.NewCustomer;
           





            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Total Amount");
            double totalAmt= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter discount percent");
            double pcnt = Convert.ToDouble(Console.ReadLine());

            Customer newCust = new  Customer (0,name,email,type,totalAmt,pcnt,0);
            BaseCustomerFactory factory = new CustomerManagerFactory().CreateFactory(newCust);
            factory.ApplyDiscount();
            repo.SaveCustomer(newCust);
            ShowAllCustomer(0);



        }

        private static void ShowCustomerById()
        {
            Console.WriteLine("Enter Customer Id");
            int id = Convert.ToInt32(Console.ReadLine());
            ShowAllCustomer(id);
        }

        private static void ShowAllCustomer(int id)
        {
            if (id==0)
            {
                Console.WriteLine("\t\t\t\t\tCustomer List\n");
            }
            else
            {
                Console.WriteLine("\t\t\t\t\tCustomer Details\n");
            }

                Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("|{0,5}|{1,10}|{2,25}|{3,15}|{4,10}|{5,10}|{6,5}","ID","Name","Email","Customer Type","Total","Discount ","Pay Amount"));
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            List<Customer> list= new List<Customer>();
            if (id>0)
            {
                list= repo.GetAllCustomers().Where(c=> c.CustomerId==id).ToList();
            }
            else 
            list = repo.GetAllCustomers().ToList();


            if (list != null)
            {

                foreach (var item in list)
                {
                    Console.WriteLine(String.Format("|{0,5}|{1,10}|{2,25}|{3,15}|{4,10}|{5,10}|{6,5}", item.CustomerId, item.CustomerName, item.CustomerEmail, item.CustType, item.TotalAmount, item.DiscountPcnt, item.PayAmount));
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                }
            }
        }
    }



}
