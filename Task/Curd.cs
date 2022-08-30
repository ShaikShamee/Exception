using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Task
{
    public class Curd
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            SqlConnection con = new SqlConnection("server=.;database=DBCustomer;integrated security=true;");
            Console.WriteLine("Press 1 for insert");
            Console.WriteLine("Press 2 for Delete ");
            Console.WriteLine("Press 3 for Update");
            Console.WriteLine("Press 4 for Search");

            int Entry = int.Parse(Console.ReadLine());
            switch (Entry)
            {
                case 1:
                    Console.Write("Enter name of Customer : ");
                    customer.name = Console.ReadLine();
                    Console.Write("Enter Email of Customer : ");
                    customer.Email = Console.ReadLine();
                    Console.Write("Enter Age of Customer : ");
                    customer.Age= int.Parse(Console.ReadLine());
                    Console.Write("Enter Address of Customer : ");
                    customer.Address = Console.ReadLine();
                    Console.Write("Enter salary of Customer : ");
                    customer.salary = double.Parse(Console.ReadLine());
                    Console.Write("Enter gender of Customer : ");
                    customer.gender = Console.ReadLine();
                    SqlCommand scmd = new SqlCommand("insert into Customer_Table values(' " + customer.name + " ',' " +customer.Email + " ',' " + customer.Age + " ',' " + customer.Address + " ','" + customer.salary+ "',' " + customer.gender + " ')", con);
                    con.Open();
                    scmd.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record inserted successfully");
                    break;
                case 2:
                    Console.WriteLine("Enter Id of Customer");
                    customer.id= int.Parse(Console.ReadLine());
                    SqlCommand scmd1= new SqlCommand("delete from Customer_Table where id=" + customer.id + " ", con);
                    con.Open();
                    scmd1.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record deleted successfully");
                    break;
                case 3:
                    Console.WriteLine("Enter id of Customer ");
                    customer.id = int.Parse(Console.ReadLine());

                    Console.Write("Enter name of Customer : ");
                    customer.name = Console.ReadLine();
                    Console.Write("Enter Email of Customer : ");
                    customer.Email = Console.ReadLine();
                    Console.Write("Enter Age of Customer : ");
                    customer.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Address of Customer : ");
                    customer.Address = Console.ReadLine();
                    Console.Write("Enter salary of Customer : ");
                    customer.salary = double.Parse(Console.ReadLine());
                    Console.Write("Enter gender of Customer : ");
                    customer.gender = Console.ReadLine();

                    SqlCommand scmd2 = new SqlCommand("update Customer_Table set name='" + customer.name + "' ,Email='" + customer.Email + "' ,Age=" + customer.Age + " ,Address='" + customer.Address + "' ,salary='" + customer.salary + "',gender='" + customer.gender + "' where id=" + customer.id + "", con);
                    con.Open();
                    scmd2.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record Updated successfully");
                    break;
                case 4:
                    Console.WriteLine("Enter id of Customer to Search");
                    customer.id = int.Parse(Console.ReadLine());
                    SqlDataAdapter da = new SqlDataAdapter("select * from Customer_Table ", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Customer_Table");

                    int count = ds.Tables[0].Rows.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (customer.id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                        {
                            Console.WriteLine("Name : " + ds.Tables[0].Rows[i][1].ToString());
                            Console.WriteLine("Email : " + ds.Tables[0].Rows[i][2].ToString());
                            Console.WriteLine("Age: " + ds.Tables[0].Rows[i][3].ToString());
                            Console.WriteLine("Address : " + ds.Tables[0].Rows[i][4].ToString());
                            Console.WriteLine("Salary : " + ds.Tables[0].Rows[i][5].ToString());
                            Console.WriteLine("Gender : " + ds.Tables[0].Rows[i][6].ToString());
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Please select the anyone operations below");
                    break;
            }
        }

    }
}

