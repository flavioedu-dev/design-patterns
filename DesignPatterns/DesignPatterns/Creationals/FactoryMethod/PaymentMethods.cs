namespace DesignPatterns.GoF.Creationals.FactoryMethod;

public interface IPayment
{
    string Process();
}


public class PixPayment : IPayment
{
    public string Process()
    {
        return "Pagamento com pix.";
    }
}

public class CardPayment : IPayment
{
    public string Process()
    {
        return "Pagamento com cartão.";
    }
}

public class BoletoPayment : IPayment
{
    public string Process()
    {
        return "Pagamento com boleto.";
    }
}