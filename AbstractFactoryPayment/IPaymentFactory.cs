// Aqui temos uma interface (um "molde") para criar as fábricas de pagamento.
// Cada fábrica vai criar uma forma de pagamento (Cartão de Crédito ou PIX).
public interface IPaymentFactory
{
    // Esse método vai ser responsável por criar o pagamento, seja por Cartão ou PIX.
    IPayment CreatePayment();
}
