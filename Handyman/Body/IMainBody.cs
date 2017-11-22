using Handyman._Arms;
using Handyman._Spine;

namespace Handyman.Body
{
    public interface IMainBody<T> : ISpine<T>
    {
        rArm ArmArms(int cin);
    }
}