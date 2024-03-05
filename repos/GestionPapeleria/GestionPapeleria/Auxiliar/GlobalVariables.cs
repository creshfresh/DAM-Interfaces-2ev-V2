using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPapeleria.Auxiliar
{
    internal class GlobalVariables
    {
        public static string DB_CONNECTION = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
    }
}
