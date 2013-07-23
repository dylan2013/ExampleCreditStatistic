using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SmartSchool.Customization.PlugIn;

namespace ExampleCreditStatistic
{
    public class Program
    {
        [MainMethod()]
        static public void Main()
        {
            new CreditStatistic(); //學分統計表
        }
    }
}
