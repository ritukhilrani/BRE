namespace BusinessRulesEngine.UnitTests
{
    using FluentAssertions;
    using Moq;
    using Xunit;

    public class MembershipShould
    {
        private readonly Mock<ISendEmail> iSendEmailMock;
        private readonly string membershipType;
        public MembershipShould ()
        {
            iSendEmailMock = new Mock<ISendEmail>();
        }

        [Fact]
        public void When_payment_for_membership_is_received_Activate_membership_Is_Successful_and_Email_is_sent()
        {
            const string inputOrder = "membership - new";
            iSendEmailMock.Setup(a => a.SendEmail(It.IsAny<string>()));
            var packageSlip = Membership.ActivateMembership(inputOrder);
            
            iSendEmailMock.Verify(a=>a.SendEmail(It.IsAny<string>()), Times.AtLeastOnce);
            packageSlip.Should().Be("Membership activated and email sent");
        }
    }
}
