// Essa classe é uma forma específica de pagamento, usando o Cartão de Crédito.
// Ela "segue" o molde IPayment, então precisa ter o método ProcessPayment.
public class CreditCardPayment : IPayment
{
    // Quando o pagamento for feito com cartão, essa mensagem vai aparecer no console.
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processando pagamento de R${amount} via Cartão de Crédito.");
    }
}


// Essa classe também "segue" o molde IPayment, mas aqui o pagamento é feito via PIX.
public class PixPayment : IPayment
{
    // Quando o pagamento for feito via PIX, essa mensagem vai aparecer no console.
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processando pagamento de R${amount} via PIX.");
    }
}
