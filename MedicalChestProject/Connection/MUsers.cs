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
        public override void Load()
        {
            ExecuteQuery((database) =>
            {
                var query = from u in database.MUser
                            select u;
                Data = query.ToList<MUser>();
                DataLoaded = true;
            });
        }
    }
}
