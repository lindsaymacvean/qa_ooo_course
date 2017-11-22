using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1 {
    class Program {
        static void Main(string[] args) {
            //using (EntityConnection con = new EntityConnection("Name=NorthwindEntities")) {
            //    con.Open();
            //    using (EntityCommand com = new EntityCommand(
            //        "Select c.companyname, c.contacttitle from NorthwindEntities.Customers as c", con)) {
            //        EntityDataReader reader = com.ExecuteReader(CommandBehavior.SequentialAccess);
            //        while (reader.Read()) {
            //            Console.WriteLine("Name {0}, Title {1}", reader[0], reader[1]);
            //        }
            //    }
            //}

            using (NorthwindEntities ctx = new NorthwindEntities()) {
                var query = from c in ctx.Customers //.Include("Orders")
                            where c.Country == "UK"
                            select c;
                foreach (var c in query) {
                    Console.WriteLine(c.CustomerID);

                    ctx.Entry(c).Collection("Orders").Load();

                    foreach (var o in c.Orders) {
                        Console.WriteLine("\t{0}", o.OrderID);
                    }
                }
            }


        }
    }
}
