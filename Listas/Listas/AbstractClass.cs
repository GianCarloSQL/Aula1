using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listas
{
    class AbstractClass
    {
        private static AbstractClass singleton =new AbstractClass();
        private int value;

        public static AbstractClass GetInstance()
        { 
            return singleton;
        }
        private AbstractClass() {

        }

        public void SetValue(int v) { this.value = v; }
        public int GetValue() { return value; }

    }
}

