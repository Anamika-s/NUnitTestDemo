using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingDemo
{
    public class NumericFunctions
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int subt(int x, int y)
        {
            return x - y;
        }
        public int GetLeaves(string department)
        {
            if (department.Equals("HR"))
            {
                return 5;
            }
            else if (department.Equals("Accounts"))
            {
                return 6;
            }
            else
            {
                return 8;
            }
        }
        public int CallingSomeotherMethod(int value)
        {
            SecondClass obj = new SecondClass();
            int x = obj.ThisMethodWillBeCalled(value);
            if (x > 10) return 10;
            else return 100;
        } 
    }
    class SecondClass
    {

        public int ThisMethodWillBeCalled(int x)
        {
            x = x + 10;
            return x;
        }

        //public int ThisMethodWillBeCalled(int x)
        //{
        //    x = x + 10;
        //    return x;
        //}
    }
}
