namespace BusinessRulesEngine.Installer
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;
    using OrderProcessingHandler.Membership_Handler;
    using OrderProcessingHandler.PackageSlipHandler;
    using Processor;

    public class MembershipInstaller: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ISendEmail>().ImplementedBy<SendEmail>());
            container.Register(Component.For<IMembership>().ImplementedBy<Membership>());
            container.Register(Component.For<IPackageSlip>().ImplementedBy<PackageSlip>());
            container.Register(Component.For<IRedirectOrderProcessor>().ImplementedBy<RedirectOrderProcessor>());
        }
    }
}
