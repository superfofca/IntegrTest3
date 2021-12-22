using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrTest3
{
    class rash
    {
        public static double Resh (double x)
        {
            double result = 0;
            if (x <= 0)
            {
                result = IntegrTest3.Function.Function.Power((IntegrTest3.Function.Function.sec(x) + IntegrTest3.Function.Function.sec(x) / IntegrTest3.Function.Function.Tan(x) - IntegrTest3.Function.Function.cosec(x) * IntegrTest3.Function.Function.Sin(x)), 2);
            }
            else
            {
                result = (IntegrTest3.Function.Function.Power(IntegrTest3.Function.Function.Log(3, x), 3) + IntegrTest3.Function.Function.Power(IntegrTest3.Function.Function.Log(5, x), 3) / IntegrTest3.Function.Function.Log(5, x) / (IntegrTest3.Function.Function.Log(3, x) * IntegrTest3.Function.Function.Log(5, x)) + (IntegrTest3.Function.Function.Log(5, x) + IntegrTest3.Function.Function.Log(3, x) / IntegrTest3.Function.Function.Power(IntegrTest3.Function.Function.Ln(x), 2)));
            }
            return result;
        }

    }
}
