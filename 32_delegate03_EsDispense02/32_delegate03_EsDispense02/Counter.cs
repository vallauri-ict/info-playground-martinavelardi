using System;

namespace _32_delegate03_EsDispense02
{
    public delegate void OverMaxEventHandler(object sender, OverMaxEventArgs e);
    class Counter
    {
        private int maxVal;
        public Counter(int n)
        {
            if (n > 10)
            {
                throw new ArgumentException("Il valore massimo è 10");
            }
            else
            {
                maxVal = n;
            }
        }
    }
}
