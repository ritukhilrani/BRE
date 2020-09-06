namespace BusinessRulesEngine
{
    using System;
    using Castle.Windsor;
    using Installer;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide input for which payment has been received. \n 1.physicalproduct \n 2. book\n 3. Video");
            string input = Console.ReadLine();
            Bootstrap.Register();
            var orderProcessing = Bootstrap.Container.Resolve<OrderProcessing>();
            orderProcessing.Start(input);
        }
    }

    internal static class Bootstrap
    {
        public static IWindsorContainer Container { get; set; }

        public static void Register()
        {
            Container = new WindsorContainer();
            Container.Install(new MembershipInstaller());
        }
    }
}
