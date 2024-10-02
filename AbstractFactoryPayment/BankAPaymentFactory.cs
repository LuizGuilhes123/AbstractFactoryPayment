// Essa fábrica vai criar os pagamentos para o Banco A.
// Ela "segue" o molde IPaymentFactory, então precisa ter o método CreatePayment.
public class BankAPaymentFactory : IPaymentFactory
{
    private string _paymentType;

    // Quando criamos uma fábrica do Banco A, precisamos dizer qual tipo de pagamento vai ser (CreditCard ou PIX).
    public BankAPaymentFactory(string paymentType)
    {
        _paymentType = paymentType;
    }

    // Aqui, dependendo do tipo de pagamento escolhido, a fábrica vai criar um pagamento por Cartão ou PIX.
    public IPayment CreatePayment()
    {
        if (_paymentType == "CreditCard")
        {
            return new CreditCardPayment(); // Se for Cartão de Crédito, cria uma classe de pagamento por cartão.
        }
        else if (_paymentType == "PIX")
        {
            return new PixPayment(); // Se for PIX, cria uma classe de pagamento por PIX.
        }
        throw new Exception("Método de pagamento não suportado."); // Se escolher algo errado, dá um erro.
    }
}

// Essa é a fábrica para o Banco B. Funciona igual à do Banco A, mas para o outro banco.
public class BankBPaymentFactory : IPaymentFactory
{
    private string _paymentType;

    // Quando criamos uma fábrica do Banco B, também dizemos qual tipo de pagamento vai ser (CreditCard ou PIX).
    public BankBPaymentFactory(string paymentType)
    {
        _paymentType = paymentType;
    }

    // Dependendo do tipo de pagamento escolhido, cria um pagamento por Cartão ou PIX.
    public IPayment CreatePayment()
    {
        if (_paymentType == "CreditCard")
        {
            return new CreditCardPayment(); // Cria o pagamento por cartão de crédito.
        }
        else if (_paymentType == "PIX")
        {
            return new PixPayment(); // Cria o pagamento via PIX.
        }
        throw new Exception("Método de pagamento não suportado."); // Dá erro se escolher errado.
    }
}
