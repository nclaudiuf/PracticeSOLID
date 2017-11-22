using System;
using Handyman.Body;
using Handyman._Arms;
using Handyman._Head;
using Handyman._Spine;
using Handyman._Voice;

namespace Handyman
{
    internal class Handyman
    {
        internal static void Main(string[] args)
        {
            int cin = 1; 
            Voice speak = new Voice();        
            rArm ra = new rArm(speak);
            Spine<MainBody> spine = new Spine<MainBody>(speak, ra, cin);
            MainBody body = new MainBody(speak, ra, cin);
            Head<MainBody> head = new Head<MainBody>(spine, speak, body, ra, cin);

            bool execute = head.Connect().ArmParts(1).ArmArms(1).MoveArm(20, (int)HeadM.ArmActions.Down);

            Console.ReadLine();
        }
    }
}
