using Handyman.Body;
using Handyman._Arms;
using Handyman._Spine;
using Handyman._Voice;

namespace Handyman._Head
{
    public class Head<T> : IHead<T>
    {
        private readonly Voice speak;
        private readonly Spine<T> spine;
        private readonly rArm ra;
        private readonly MainBody body;
        internal int cin { get; set; }

        public Head(Spine<T> spine, Voice speak, MainBody body, rArm ra, int cin)
        {
            this.spine = spine;
            this.speak = speak;
            this.body = body;
            this.ra = ra;           
            this.cin = cin;
        }

        public Spine<T> Connect()
        {
            return new Spine<T>(speak, ra, cin);
        }
    }
}
