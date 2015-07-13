using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalChestProject
{
    public class Storages:TableManeger<MedicalChest, Storage>
    {
        public Storages() { Init(); }
        public override void Load()
        {
            ExecuteQuery(database =>
                {
                    var query = from s in database.Storage
                                select s;
                    Data = query.ToList<Storage>();
                    DataLoaded = true;
                });
        }
    }
}
