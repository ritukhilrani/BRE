namespace BusinessRulesEngine
{
    public class PackageSlip
    {
        private static string successfulMessage;
        public static string GeneratePackagingSlip(string inputOrder)
        {
            successfulMessage = "Packaging slip successfully generated for shipping";
            return successfulMessage;
        }

        public static string GenerateDuplicatePackagingSlip(string inputOrder)
        {
            successfulMessage = "Packaging slip successfully generated for royalty department";
            return successfulMessage;
        }
    }
}
