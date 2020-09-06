namespace BusinessRulesEngine.UnitTests
{
    using FluentAssertions;
    using Xunit;

    public class PackageSlipShould
    {
        private readonly PackageSlip packageSlip;
        public PackageSlipShould()
        {
            packageSlip = new PackageSlip();
        }

        [Fact]
        public void When_physical_product_is_received_Generate_packagingSlip_Is_Successful()
        {
            const string inputOrder = "physicalproduct";
            var packageSlip = this.packageSlip.GeneratePackagingSlip(inputOrder.ToUpper());
            packageSlip.Should().Be("Packaging slip successfully generated for shipping");
        }

        [Fact]
        public void When_book_is_received_Generate_duplicatePackagingSlip_Is_Successful()
        {
            const string inputOrder = "book";
            var packageSlip = this.packageSlip.GeneratePackagingSlip(inputOrder.ToUpper());
            packageSlip.Should().Be("Packaging slip successfully generated for royalty department");
        }

        [Fact]
        public void When_book_is_received_Generate_PackagingSlip_and_add_free_video_Is_Successful()
        {
            const string inputOrder = "video";
            var packageSlip = this.packageSlip.GeneratePackagingSlip(inputOrder.ToUpper());
            packageSlip.Should().Be("Packaging slip generated and first aid video added");
        }
    }
}
