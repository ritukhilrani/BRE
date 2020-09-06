namespace BusinessRulesEngine
{
    using System;

    public class PackageSlip
    {
        private static string successfulMessage;
        public static string GeneratePackagingSlip(string inputOrder)
        {
            switch (inputOrder)
            {
                case "PHYSICALPRODUCT":
                    successfulMessage = GeneratePackagingSlipForProductOrdered("shipping");
                    break;
                case "BOOK":
                    successfulMessage = GeneratePackagingSlipForProductOrdered("royalty department");
                    break;
                case "VIDEO":
                    successfulMessage = GeneratePackagingSlipForProductOrdered("C://FilePath/ToVideo");
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
            
            Console.WriteLine(successfulMessage);
            return successfulMessage;
        }

        private static string GeneratePackagingSlipForProductOrdered(string inputOrder)
        {
            if (System.IO.Directory.Exists(inputOrder))
            {
                Console.WriteLine("Packaging slip generated and first aid video added");
            }
            successfulMessage = "Packaging slip successfully generated for " + inputOrder;
            return successfulMessage;
        }
    }
}
