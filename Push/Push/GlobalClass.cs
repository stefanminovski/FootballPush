using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Push
{
    
     static class GlobalClass
     {
            private static int m_globalVar = 0;
            private static string ime = "";

            public static int GlobalVar
            {
                get { return m_globalVar; }
                set { m_globalVar = value; }
            }

            public static string GlobalVar1
            {
                get { return ime; }
                set { ime = value; }
            }

     }
    
}
