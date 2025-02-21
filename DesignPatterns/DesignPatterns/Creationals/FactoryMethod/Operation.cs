namespace DesignPatterns.GoF.Creationals.FactoryMethod;

public class Operation
{
    public IPayment? PaymentMethod { get; private set; }

    public void SetPaymentType(PaymentType? paymentType)
    {
        PaymentMethod = paymentType switch
        {
            PaymentType.Pix => new PixPayment(),
            PaymentType.Card => new CardPayment(),
            PaymentType.Boleto => new BoletoPayment(),
            _ => throw new ArgumentException("Tipo de pagamento inválido.", nameof(paymentType))
        };
    }

    public string MakePayment()
    {
        if (PaymentMethod is null)
            throw new InvalidOperationException("Método de pagamento não definido.");

        return PaymentMethod.Process();
    }
}
