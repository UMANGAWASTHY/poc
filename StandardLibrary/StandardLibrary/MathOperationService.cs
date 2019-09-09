using System;
using System.Collections.Generic;
using System.Text;

namespace StandardLibrary
{
    public class MathOperationService : IMathOperationService
    {
        int a = 0;
        int b = 0;
        public MathOperationService(int first, int sec)
        {
            this.a = first;
            this.b = sec;
        }
        public int Add()
        {
            return a + b;
        }

        public int Div()
        {
            return a / b;
        }

        public int Mul()
        {
            return a * b;
        }

        public int Sub()
        {
            return a - b;
        }
    }
}
