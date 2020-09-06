namespace BusinessRulesEngine.UnitTests
{
    using FluentAssertions;
    using Xunit;

    public class PackageSlipShould
    {
        [Fact]
        public void When_physical_product_is_received_Generate_packagingSlip_Is_Successful()
        {
            const string inputOrder = "pen";
            var packageSlip = PackageSlip.GeneratePackagingSlip(inputOrder);
            packageSlip.Should().Be("Packaging slip successfully generated for shipping");
        }
    }
}
