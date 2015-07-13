using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;

namespace MedicalChestProject
{
    public class AppTypes:TableManeger<MedicalChest, ApplicationType>
    {
        public AppTypes() { Init(); }

        public override void Load()
        {
            ExecuteQuery(database =>
                {
                    var query = from ap in database.ApplicationType
                                select ap;
                    Data = query.ToList<ApplicationType>();
                    DataLoaded = true;
                });
        }
    }
}
