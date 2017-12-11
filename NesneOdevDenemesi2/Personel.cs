using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdevDenemesi2
{
    public class Personel:Kisi
    {
        public int personelID { get; set; }
        public Personel(int personelID)
        {
            this.personelID = personelID;
        }

    }
}
