using Handyman._Arms;
using Handyman._Voice;

namespace Handyman.Body
{
    public class MainBody : IMainBody<MainBody>
    {
        internal int cin { get; set; }
        private readonly Voice speak;
        private readonly rArm ra;

        public MainBody(Voice speak, rArm ra, int cin)
        {
            this.speak = speak;
            this.ra = ra;
            this.cin = cin;
        }

        public MainBody ArmParts(int cin)
        {
            if (cin == 1)
            {
                return new MainBody(speak, ra, cin);
            }

            return null;
        }

        public rArm ArmArms(int cin)
        {
            if (cin == 1)
            {
                return new rArm(speak);
            }

            return null;
        }
    }
}