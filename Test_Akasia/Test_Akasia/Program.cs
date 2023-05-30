using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Akasia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsEmployee cls = new ClsEmployee();

            List<ClsEmployee> Data = new List<ClsEmployee>();

            //ada data
            Data = cls.Add();

            //delete data
            string employeeId = "1003";

            Data = cls.Delete(Data, employeeId);


            //tampilkan data
            cls.Tampilkan_Data(Data);

            Console.ReadKey();

        }
    }
}
