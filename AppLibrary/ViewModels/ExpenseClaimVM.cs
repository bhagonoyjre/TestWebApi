using System;

namespace AppLibrary.ViewModels
{
    public class ExpenseClaimVM
    {
        public Guid Id { get; set; }
        public String CostCentre { get; set; }
        public Decimal Total { get; set; }
        public String PaymentMethod { get; set; }

    }
}