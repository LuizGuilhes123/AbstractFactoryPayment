// Essa interface é como um "molde" para criar diferentes tipos de pagamento.
// Qualquer classe que "seguir" essa interface vai precisar ter um método chamado ProcessPayment.
public interface IPayment
{
    // Esse método vai processar o pagamento, recebendo o valor como parâmetro.
    void ProcessPayment(decimal amount);
}