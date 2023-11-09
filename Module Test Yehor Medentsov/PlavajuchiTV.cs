using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_Test_Yehor_Medentsov
{
    public class PlavajuchiTV : Volier
    {
        public int x;
        public int y;
        public string nameTV = "Бегемот";


        public PlavajuchiTV()
        {
            this.x = 6;
            this.y = 7;
            name = "Вольер для плаваючих тварин";
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
