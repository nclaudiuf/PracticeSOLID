using System;

namespace Handyman._Voice
{
    public class Voice
    {
        public Voice()
        {}

        public void SpeakToDisplay(String m)
        {
            if (m != null)
            {
                ConsoleLine(m);
            }
        }     

        private void ConsoleLine(String m)
        {
            Console.WriteLine(m);
            StyleDisplay();
        }

        private void StyleDisplay()
        {
            Console.WriteLine("#########################");
        }
    }
}