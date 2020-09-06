namespace BusinessRulesEngine
{
    using Processor;

    public class OrderProcessing
    {
        public IRedirectOrderProcessor RedirectOrderProcessor;
        public OrderProcessing(IRedirectOrderProcessor redirectOrderProcessor)
        {
            RedirectOrderProcessor = redirectOrderProcessor;
        }

        public bool Start(string input)
        {
            this.SetUpProcessor(input);
            return true;
        }

        public void Stop()
        {
            // to stop the service
        }

        private void SetUpProcessor(string input)
        {
            RedirectOrderProcessor.RedirectToHandler(input);
        }
    }
}
