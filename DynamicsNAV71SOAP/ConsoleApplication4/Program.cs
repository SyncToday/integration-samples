using ConsoleApplication4.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://msdn.microsoft.com/en-us/library/dd355316(v=nav.70).aspx
            ServiceTasks_Binding client = new ServiceTasks_Binding();
            client.UseDefaultCredentials = true;
            ServiceTasks[] result = client.ReadMultiple(new ServiceTasks_Filter[] { }, "", 1000);
            foreach (ServiceTasks task in result)
                Console.WriteLine(task.Description);
            Console.ReadLine();
        }
    }
}
