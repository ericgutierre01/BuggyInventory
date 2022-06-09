using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyInventory
{
    static class dbConnection
    {

        public static string getConnection()
        {
            return "Data Source=localhost;Initial Catalog=BuggyDb;Integrated Security=True; MultipleActiveResultSets=True";

        }
    }
}
