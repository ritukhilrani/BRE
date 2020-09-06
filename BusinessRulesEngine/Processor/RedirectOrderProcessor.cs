namespace BusinessRulesEngine.Processor
{
    using OrderProcessingHandler.Membership_Handler;
    using OrderProcessingHandler.PackageSlipHandler;

    public class RedirectOrderProcessor: IRedirectOrderProcessor
    {
        private readonly IMembership _membership;
        private readonly IPackageSlip _packageSlip;

        public RedirectOrderProcessor(IMembership membership, IPackageSlip packageSlip)
        {
            _membership = membership;
            _packageSlip = packageSlip;
        }
        public void RedirectToHandler(string input)
        {
            switch (input.ToUpper())
            {
                case "membership new":
                    _membership.ActivateMembership(input);
                    break;
                default:
                    _packageSlip.GeneratePackagingSlip(input);
                    break;
            }
        }
    }

    public interface IRedirectOrderProcessor
    {
        public void RedirectToHandler(string input);
    }
}
