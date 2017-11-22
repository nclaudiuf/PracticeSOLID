using Handyman.Body;
using Handyman._Arms;
using Handyman._Voice;

namespace Handyman._Spine
{
    public class Spine<T> : ISpine<MainBody>
    {
        private readonly rArm ra;
        private readonly Voice speak;

        internal int cin { get; set; }

        public Spine(Voice speak, rArm ra, int cin)
        {
            this.speak = speak;
            this.ra = ra;
            this.cin = cin;
        }

        public MainBody ArmParts(int cin)
        {
            return new MainBody(speak, ra, cin);
        }
    }
}
