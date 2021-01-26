using System;

namespace _25_OOP11_Mondo_Animale
{
    public abstract class AnimaleAcquatico : Animale
    {
        public AnimaleAcquatico(String s) : base(s)
        {

        }
        public override String vive()
        {
            return "nell'acqua";
        }
        public override String chi_sei()
        {
            return "un animale acquatico";
        }
    }
}
