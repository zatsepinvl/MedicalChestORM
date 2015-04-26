using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalChestProject
{
    public class ConextManeger:Singleton<ConextManeger, string>
    {
        protected ConextManeger(){}
    }
}
