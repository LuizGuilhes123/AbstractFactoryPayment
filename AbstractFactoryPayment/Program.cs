class Program
{
    static void Main(string[] args)
    {
        // Primeiro, o programa pergunta qual banco o usuário quer (A ou B).
        Console.WriteLine("Escolha o banco (A ou B): ");
        string bankChoice = Console.ReadLine(); // Lê a escolha do banco.

        // Depois, o programa pergunta qual método de pagamento (1 para Cartão, 2 para PIX).
        Console.WriteLine("Escolha o método de pagamento (1 para CreditCard ou 2 para PIX): ");
        string paymentChoice = Console.ReadLine(); // Lê a escolha do pagamento.

        // Aqui, convertemos a escolha do usuário (1 ou 2) para o tipo correto de pagamento.
        if (paymentChoice == "1")
        {
            paymentChoice = "CreditCard"; // Se o usuário escolheu "1", mudamos para "CreditCard".
        }
        else if (paymentChoice == "2")
        {
            paymentChoice = "PIX"; // Se o usuário escolheu "2", mudamos para "PIX".
        }
        else
        {
            // Se o usuário digitar algo diferente de 1 ou 2, mostramos que o método é inválido e saímos.
            Console.WriteLine("Método de pagamento inválido.");
            return; // Sai do programa.
        }

        IPaymentFactory paymentFactory; // Variável que vai guardar a fábrica de pagamento.

        // Agora escolhemos a fábrica de pagamento com base no banco escolhido (A ou B).
        if (bankChoice == "A")
        {
            // Se o usuário escolheu o Banco A, criamos uma fábrica do Banco A.
            paymentFactory = new BankAPaymentFactory(paymentChoice);
        }
        else if (bankChoice == "B")
        {
            // Se o usuário escolheu o Banco B, criamos uma fábrica do Banco B.
            paymentFactory = new BankBPaymentFactory(paymentChoice);
        }
        else
        {
            // Se o usuário escolher qualquer coisa que não seja A ou B, mostramos erro e saímos.
            Console.WriteLine("Banco não suportado.");
            return; // Sai do programa.
        }

        // Aqui, a fábrica cria o tipo de pagamento escolhido (Cartão ou PIX) para o banco selecionado.
        IPayment payment = paymentFactory.CreatePayment();
        
        // Finalmente, o sistema processa o pagamento de R$100,00.
        payment.ProcessPayment(100.00m); // 100.00m significa 100 reais.
    }
}
