using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers
{
    public class MathBL
    {
        public int sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}