using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalChestProject
{
    public class Drugs:TableManeger<MedicalChest, Drug>
    {
        public override void Load()
        {
            ExecuteQuery((database) =>
                {
                    var query = from d in database.Drug
                                from s in database.Storage.Where(q => q.StorageId == d.StorageId).DefaultIfEmpty()
                                from a in database.ApplicationType.Where(q => q.AppTypeId == d.ApplicationTypeId).DefaultIfEmpty()
                                select Drug.Build(d, s, a);
                    Data = query.ToList<Drug>();
                    DataLoaded = true;
                });
        }
    }
}
