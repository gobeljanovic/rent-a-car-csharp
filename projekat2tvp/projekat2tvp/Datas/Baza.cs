using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat2tvp.Datas
{
    internal class Baza
    {
        private static string connestionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Milovan Srejic\Desktop\lole viser\2. Godina\4. semestar\TVP\projekat\II_projekat_nrt_40_23\projekat2tvp\projekat2tvp\bin\Debug\RentACarDB.accdb""";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connestionString);
        }
    }
}
