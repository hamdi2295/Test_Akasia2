using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Akasia
{
    public class ClsEmployee
    {
        //duplicate handling (handling jika employee id yang sama)
        
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }




        //Add New Data
        public List<ClsEmployee> Add()
        {
            //add data hardacode sesuai dengan soal
            try
            {
                List<ClsEmployee> Data = new List<ClsEmployee>();

                //add data per row

                //row 1
                ClsEmployee Data1 = new ClsEmployee();

                Data1.EmployeeId = "1001";
                Data1.FullName = "Adit";
                Data1.BirthDate = Convert.ToDateTime("1954-08-17");

                //handling data duplicate
                var duplicate1 = Data.Where(x => x.EmployeeId == Data1.EmployeeId).FirstOrDefault();

                if(duplicate1 != null)
                {
                    //data duplicate, jadi tidak perlu di add (do nothing)
                }
                else
                {
                    //data tidak duplicate, add new data
                    Data.Add(Data1);
                }

                //row 2
                ClsEmployee Data2 = new ClsEmployee();

                Data2.EmployeeId = "1002";
                Data2.FullName = "Anton";
                Data2.BirthDate = Convert.ToDateTime("1954-08-18");

                //handling data duplicate
                var duplicate2 = Data.Where(x => x.EmployeeId == Data2.EmployeeId).FirstOrDefault();

                if (duplicate2 != null)
                {
                    //data duplicate, jadi tidak perlu di add (do nothing)
                }
                else
                {
                    //data tidak duplicate, add new data
                    Data.Add(Data2);
                }


                //row 3
                ClsEmployee Data3 = new ClsEmployee();

                Data3.EmployeeId = "1003";
                Data3.FullName = "Amir";
                Data3.BirthDate = Convert.ToDateTime("1954-08-19");

                //handling data duplicate
                var duplicate3 = Data.Where(x => x.EmployeeId == Data3.EmployeeId).FirstOrDefault();

                if (duplicate3 != null)
                {
                    //data duplicate, jadi tidak perlu di add (do nothing)
                }
                else
                {
                    //data tidak duplicate, add new data
                    Data.Add(Data3);
                }


                Console.WriteLine("Add Data Success");
                Console.WriteLine("");
                Console.WriteLine("");

                return Data;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Add Data Failed, ErrorMessage => " + ex.Message.ToString());
                Console.WriteLine();
                Console.WriteLine();

                return null;
            }
        }



        public List<ClsEmployee> Delete(List<ClsEmployee> Employee, string employeeId = "")
        {
            try
            {
                var data = Employee.Where(x => x.EmployeeId == employeeId).FirstOrDefault();

                //handling null
                if (data == null)
                {
                    //jika null tidak perlu hapus
                    Console.WriteLine("Data Not Found Where EmployeeId : " + employeeId);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Employee.Remove(data);

                    Console.WriteLine("Success Delete Data Where EmployeeId : " + employeeId);
                    Console.WriteLine();
                    Console.WriteLine();

                }

                return Employee;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Failed Delete Data Where EmployeeId : " + employeeId + ", Error Message => " + ex.Message.ToString());
                Console.WriteLine();
                Console.WriteLine();

                return Employee;
            }
            
        }



        public void Tampilkan_Data(List<ClsEmployee> Employee)
        {
            try
            {
                int flaq = 1;

                foreach (var item in Employee)
                {
                    Console.WriteLine("Data ke-" + flaq.ToString());
                    Console.WriteLine("===================");

                    Console.WriteLine("Employee ID : " + item.EmployeeId.ToString());
                    Console.WriteLine("Full Name : " + item.FullName.ToString());
                    Console.WriteLine("Birth Date : " + Convert.ToDateTime(item.BirthDate).ToString("yyyy-MM-dd"));
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    flaq++;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Gagal Menampilkan Data, Error Message => " + ex.Message.ToString());
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }


    }
}
