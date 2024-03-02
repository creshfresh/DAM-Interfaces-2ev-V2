using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SalesLineDs
    {

        public static List<SalesLine> GetSalesLines()
        {
            var customer = constructCustomers();
            var items = constructItems();

            var res = new List<SalesLine>();

            var rnGenerator = new Random();
            for (int i = 1; i <= 25; i++)
            {
                var rndCustomers = "C0000" + rnGenerator.Next(1, 11);
                var rndItem = "0000" + rnGenerator.Next(1, 11);
                var rndQty = rnGenerator.NextDouble() * 100;
                var rndUnitPrice = rnGenerator.NextDouble() * 100;

                var salesLine = new SalesLine();

                salesLine.CustAccount = rndCustomers;
                salesLine.CustName = customer[rndCustomers];
                salesLine.Decription = items[rndItem];
                salesLine.Qty = (decimal)rndQty;
                salesLine.UnitPrice = (decimal)rndUnitPrice;
                salesLine.TotalPrice = salesLine.Qty * salesLine.UnitPrice;

                res.Add(salesLine);

            }
            return res;
        }

        private static Dictionary<string, string> constructCustomers()
        {
            var clientes = new Dictionary<string, string>()
            {

            { "C00001", "Hammond" },
            { "C00002", "Dever Lecs" },
            { "C00003", "J Nemonic" },
            { "C00004", "J Nascis" },
            { "C00005", "LordieLord" },
            { "C00006", "Stan Inc" },
            { "C00007", "Paco Floress" },
            { "C00008", "Antohy Hopp" },
            { "C00009", "Marv Fun" },
            { "C000010", "Kyle Vidiclub" },
            { "C000011", "BFH in Madrid" },
            { "C000012", "Smt Smt" }

            };
            return clientes;
        }
        private static Dictionary<string, string> constructItems()
        {
            var items = new Dictionary<string, string>()
            {


            { "00001", "Model T576" },
            { "00002", "Model T800" },
            { "00003", "Model T100" },
            { "00004", "Model T2580" },
            { "00005", "Model T45" },
            { "00006", "Model T666" },
            { "00007", "Model T-rex" },
            { "00008", "Model T6789" },
            { "00009", "Model T-plus" },
            { "000010", "Model T-tas" },
            { "000011", "Model T-zone" },
            { "000012", "Model T12" }

            };
            return items;
        }
    }

}

