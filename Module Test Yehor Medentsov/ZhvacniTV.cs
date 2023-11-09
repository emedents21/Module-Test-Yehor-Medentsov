using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Test_Yehor_Medentsov
{
    public class ZhvacniTV : Volier
    {
        public int x;
        public int y;
        public string nameTV = "Буйвол";


        public ZhvacniTV()
        {
            this.x = 5;
            this.y = 6;
            name = "Вольер для жвачних тварин";
        }

        public override double Plosha()
        {
            return this.x * this.y;
        }


        public override string Show()
        {
            return "Вольер: " + name + "; Тварина: " + nameTV + "; Площа вольеру: " + Plosha().ToString();
        }
    }
}
