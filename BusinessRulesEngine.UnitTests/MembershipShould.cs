namespace BusinessRulesEngine.UnitTests
{
    using FluentAssertions;
    using Moq;
    using Xunit;

    public class MembershipShould
    {
        private readonly Mock<ISendEmail> iSendEmailMock;
        private readonly Membership _membership;

        public MembershipShould ()
        {
            iSendEmailMock = new Mock<ISendEmail>();
            _membership = new Membership(iSendEmailMock.Object);
        }

        [Fact]
        public void When_payment_for_membership_is_received_Activate_membership_Is_Successful_and_Email_is_sent()
        {
            const string inputOrder = "membership - new";
            iSendEmailMock.Setup(a => a.SendEmailToMember(It.IsAny<string>()));
            var packageSlip = _membership.ActivateMembership(inputOrder);
            
            iSendEmailMock.Verify(a=>a.SendEmailToMember(It.IsAny<string>()), Times.AtLeastOnce);
            packageSlip.Should().Be("Membership activated and email sent");
        }
    }
}
