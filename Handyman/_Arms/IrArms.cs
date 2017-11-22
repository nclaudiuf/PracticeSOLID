using Handyman._Spine;

namespace Handyman._Arms
{
    public interface IrArms<T>: ISpine<T>
    {
        bool MoveArm(int force, int action);
    }
}
