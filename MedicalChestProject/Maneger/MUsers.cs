using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;

namespace MedicalChestProject
{
    public class MUsers : TableManeger<MedicalChest, MUser>
    {
        public MUsers()
        {
            Init();
        }
        public override void LoadAll()
        {
            ExecuteQuery((database) =>
            {
                var query = from u in database.MUser
                            select u;
                Data.LoadData(query.ToList<MUser>());
                DataLoaded = true;
                int i=1;
                foreach(MUser u in Data)
                {
                    u.UserId = i++;
                }
            });
        }
    }
}
