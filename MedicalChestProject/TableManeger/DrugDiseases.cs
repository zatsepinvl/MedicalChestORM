using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalChestProject
{
    public class DrugDiseases : IndexDependentTableManeger<MedicalChest, DrugDisease>
    {
        public DrugDiseases() { Init(); index = -1; LoadAll = true; }
        public override void Load()
        {
            ExecuteQuery(database =>
                {
                    var query = from dd in database.DrugDisease
                                from d in database.Drug.Where(q => q.DrugId == dd.DrugId).DefaultIfEmpty()
                                from dis in database.Disease.Where(q => q.DiseaseId == dd.DiseaseId).DefaultIfEmpty()
                                select DrugDisease.Build(dd, d, dis);
                    Data = query.ToList<DrugDisease>();
                    DataLoaded = true;
                    ChooseDataByIndex();
                });
        }

        protected override void ChooseDataByIndex()
        {
            if (!DataLoaded)
            {
                Load();
            }
            if (LoadAll)
            {
                DataByIndex = Data;
            }
            else
            {
                DataByIndex = Data.FindAll(d => d.DrugId == Index);
            }
        }
    }


}
