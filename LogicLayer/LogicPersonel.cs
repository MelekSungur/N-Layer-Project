using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DALLayer;

namespace LogicLayer
{
    public class Class1
    {
        public static List<EntityPersonel>LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }

    }
}
