public class BaseApiResponse
{
    public OrderModel Order { get; set; }
    public ConfigurationModel Configuration { get; set; }
    public BusinessModel Business { get; set; }
    public List<AssociatedOrderModel> AssociatedOrders { get; set; }


    public class OrderModel
    {
        public string Status { get; set; }

        public string CreationTime { get; set; }
        public long Id { get; set; }
        public string Reference { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalCapturedAmount { get; set; }
        public decimal? TotalAuthorizedAmount { get; set; }
        public string Currency { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Channel { get; set; }
        public List<OrderItemModel> Items { get; set; }
        public string Context { get; set; }
        public bool IsOrderContextPayInvoice => Context != null
                                                && Context.ToString()
                                                    .Equals("PayInvoice", StringComparison.OrdinalIgnoreCase);

        public class OrderItemModel
        {
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public string Name { get; set; }
            public decimal? Vat { get; set; }
        }
    }

    public class ConfigurationModel
    {
        public bool? TokenizeCc { get; set; }
        public string ReturnUrl { get; set; }
        public bool? PayerConsentForToken { get; set; }
        public bool? RequiredCardHolderName { get; set; }
        public int? AllowedRetries { get; set; }
        public string Locale { get; set; }
        public string TermsAndConditionsUrl { get; set; }
        public DateTime? InitiationValidity { get; set; }
    }

    public class BusinessModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class AssociatedOrderModel
    {
        public string Status { get; set; }
        public long Id { get; set; }
        public int AttemptNumber { get; set; }
        public int? AllowedRetries { get; set; }
    }
}