using ClothesStoreApp.Data.Enums;
// This class represents a payment transaction for an order.
// It includes details like the account number, CVV, expiration date, amount, and status of the payment.
// It also has a reference to the associated order.
// Note: In a real application, sensitive information like account numbers and CVV should be handled securely and not stored in plain text. I’m doing it that way for training purposes only.
namespace ClothesStoreApp.Data.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string Cvv { get; set; } = null!;
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }

        public decimal Amount { get; set; }

        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public DateTime TimeOfPayment { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
