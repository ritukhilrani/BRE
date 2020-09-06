namespace BusinessRulesEngine.UnitTests
{
    using Moq;
    using OrderProcessingHandler.Membership_Handler;
    using OrderProcessingHandler.PackageSlipHandler;
    using Processor;
    using Xunit;

    public class RedirectOrderProcessorShould
    {
        private readonly Mock<IPackageSlip> _packageSlip;
        private readonly Mock<IMembership> _membership;
        private readonly RedirectOrderProcessor _redirectOrderProcessor;

        public RedirectOrderProcessorShould()
        {
            _packageSlip = new Mock<IPackageSlip>();
            _membership = new Mock<IMembership>();

            _packageSlip.Setup(a => a.GeneratePackagingSlip(It.IsAny<string>())).Returns("Packaging slip generated and first aid video added");
            _membership.Setup(a => a.ActivateMembership(It.IsAny<string>()))
                .Returns("Membership activated and email sent");

            _redirectOrderProcessor = new RedirectOrderProcessor(_membership.Object, _packageSlip.Object);
        }

        [Fact]
        public void When_payment_for_membership_is_received_Activate_membership_Is_Successful_and_Email_is_sent()
        {
            const string inputOrder = "membership new";

            _redirectOrderProcessor.RedirectToHandler(inputOrder);

            _membership.Verify(a => a.ActivateMembership(It.IsAny<string>()), Times.AtLeastOnce);
        }
    }
}
