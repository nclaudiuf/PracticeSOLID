using Handyman.Body;
using NUnit.Framework;
using Handyman._Arms;
using Handyman._Head;
using Handyman._Spine;
using Handyman._Voice;

namespace Handyman.Tests
{
    [TestFixture]
    public class HandymanTest
    {
        private Head<MainBody> head = null;

        [SetUp]
        public void HandymanTest_Init()
        {
            int cin = 1;
            Voice speak = new Voice();
            rArm ra = new rArm(speak);
            Spine<MainBody> spine = new Spine<MainBody>(speak, ra, cin);
            MainBody body = new MainBody(speak, ra, cin);
            head = new Head<MainBody>(spine, speak, body, ra, cin);          
        }

        [Test]
        public void HandymanTest_MoveLeftArm_Succeeded()
        {
            //Arrange
            bool execute = head.Connect().ArmParts(1).ArmArms(1).MoveArm(20, (int)HeadM.ArmActions.Down);

            //Act

            //Assert
            Assert.AreEqual(true, execute);
        }
    }
}
