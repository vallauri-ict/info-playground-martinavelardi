using System;

namespace _25_OOP11_Mondo_Animale
{
    public abstract class AnimaleMarino : AnimaleAcquatico
    {
        public AnimaleMarino(String s) : base(s)
        {

        }
        public override String vive()
        {
            return "in mare";
        }
        public override String chi_sei()
        {
            return "un animale marino";
        }
    }
}
