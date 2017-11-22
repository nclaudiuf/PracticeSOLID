using Handyman._Head;
using Handyman._Spine;
using Handyman._Voice;

namespace Handyman._Arms
{
    public class rArm : IrArms<rArm>
    {
        private readonly Voice speak;
        internal bool ArmExists = false;
        public int cin { get; set; }

        public rArm(Voice speak)
        {
            this.speak = speak;
            if (cin == 1)
            {
                ArmExists = true;             
            }           
        }

        rArm ISpine<rArm>.ArmParts(int cin)
        {
            return new rArm(speak);
        }

        public bool MoveArm(int force, int action)
        {
            if (force == 0)
            {
               speak.SpeakToDisplay("Bring it on!");      
            }
            else if (force < 100 && force > 0)
            {
                if (HeadM.armActions.ContainsKey(action))
                {
                    switch (action)
                    {
                        case (int) HeadM.ArmActions.Up:
                        {
                            speak.SpeakToDisplay(HeadM.armActions[(int) HeadM.ArmActions.Up]);
                            break;
                        }
                        case (int) HeadM.ArmActions.Down:
                        {
                            speak.SpeakToDisplay(HeadM.armActions[(int) HeadM.ArmActions.Down]);
                            break;
                        }
                        case (int) HeadM.ArmActions.Stop:
                        {
                            speak.SpeakToDisplay(HeadM.armActions[(int) HeadM.ArmActions.Stop]);
                            break;
                        }
                    }

                    return true;
                }
            }

            return false;
        }   
    }
}
