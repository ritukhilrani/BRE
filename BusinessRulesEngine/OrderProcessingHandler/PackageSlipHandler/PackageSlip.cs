namespace BusinessRulesEngine
{
    using System;
    using OrderProcessingHandler.PackageSlipHandler;

    public class PackageSlip: IPackageSlip
    {
        private static string _successfulMessage;
        public string GeneratePackagingSlip(string inputOrder)
        {
            switch (inputOrder)
            {
                case "PHYSICALPRODUCT":
                    _successfulMessage = GeneratePackagingSlipForProductOrdered("shipping");
                    break;
                case "BOOK":
                    _successfulMessage = GeneratePackagingSlipForProductOrdered("royalty department");
                    break;
                case "VIDEO":
                    _successfulMessage = GeneratePackagingSlipForProductOrdered("C://FilePath/ToVideo");
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
            
            Console.WriteLine(_successfulMessage);
            return _successfulMessage;
        }

        private static string GeneratePackagingSlipForProductOrdered(string inputOrder)
        {
            if (System.IO.Directory.Exists(inputOrder))
            {
                Console.WriteLine("Packaging slip generated and first aid video added");
            }
            _successfulMessage = "Packaging slip successfully generated for " + inputOrder;
            return _successfulMessage;
        }
    }
}
