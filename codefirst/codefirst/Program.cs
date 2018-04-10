using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace codefirst
{
    public class emp
    {
        public int id { get; set; }
        public decimal salary { get; set; }
        public string name { get; set; }
    }
    public class blogDbcontext : DbContext
    {
        public DbSet<emp> obj { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
