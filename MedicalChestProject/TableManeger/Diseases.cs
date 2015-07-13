using System;
using System.Collections.Generic;
using System.Linq;


namespace MedicalChestProject
{
    public class Diseases:TableManeger<MedicalChest, Disease>
    {
        public Diseases() { Init(); }
        public override void Load()
        {
            ExecuteQuery(database =>
                {
                    var query = from d in database.Disease
                                select d;
                    Data = query.ToList<Disease>();
                    DataLoaded = true;
                });
        }
    }
}
