using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Test_Yehor_Medentsov
{
    public abstract class Volier
    {
        public string name;
        public int x;
        public int y;//размер вольера
        
        public abstract double Plosha();
        public abstract string Show();
    }
}
