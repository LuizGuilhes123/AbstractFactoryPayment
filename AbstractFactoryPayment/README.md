# Sistema de Pagamentos com Abstract Factory

Este projeto implementa o padrão de design Abstract Factory para simular um sistema de pagamentos com diferentes métodos de pagamento (Cartão de Crédito e PIX) e diferentes provedores (bancos que no caso ou é A ou B).

## Estrutura do Projeto

- **IPayment**: Interface para os métodos de pagamento.
- **CreditCardPayment** e **PixPayment**: Implementações de métodos de pagamento.
- **IPaymentFactory**: Interface para a fábrica de métodos de pagamento.
- **BankAPaymentFactory** e **BankBPaymentFactory**: Fábricas concretas que criam métodos de pagamento para os Bancos A e B.

## Executando o Projeto

1. Compile o projeto:
    ```bash
    dotnet build
    ```

2. Execute o programa:
    ```bash
    dotnet run
    ```

O sistema irá solicitar a escolha de um banco e um método de pagamento, e então processará um pagamento simulado de R$100,00.
