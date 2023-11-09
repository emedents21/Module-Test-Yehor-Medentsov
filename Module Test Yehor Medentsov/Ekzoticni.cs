using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_Test_Yehor_Medentsov
{
    public class Ekzoticni : Volier
    {
        public int x;
        public int y;
        public string nameTV = "Змея";


        public Ekzoticni()
        {
            this.x = 3;
            this.y = 4;
            name = "Вольер зi скла";
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
