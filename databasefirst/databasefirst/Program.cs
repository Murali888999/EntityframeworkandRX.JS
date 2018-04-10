using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databasefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var context = new databasefirstEntities();
                var datapost = new datapost();
                {
                    datapost.body = "body";
                    datapost.title = "title";
                    datapost.postid = 1;
                    datapost.datapublished = DateTime.Now;
                };
                context.dataposts.Add(datapost);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
