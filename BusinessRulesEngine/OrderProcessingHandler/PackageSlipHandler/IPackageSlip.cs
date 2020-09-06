namespace BusinessRulesEngine.OrderProcessingHandler.PackageSlipHandler
{
    public interface IPackageSlip
    {
        public string GeneratePackagingSlip(string inputOrder);
    }
}
