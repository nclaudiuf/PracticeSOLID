namespace Handyman._Legs
{
    public class lLeg : ILegs<lLeg>
    {
        internal int cin { get; set; }

        public lLeg(int cin)
        {
            this.cin = cin;
        }

        public lLeg ArmParts(int cin)
        {
            if (cin == 1)
            {
                return new lLeg(cin);
            }

            return null;
        }
    }
}
