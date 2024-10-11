# Projeto Abstract Factory Payment

## Membros da Equipe

- Alison Aquino da Silva - (Inserir matrícula)
- Caio Henrique de Souza Lira - 1-2024130717
- Luiz Guilherme de Sousa Braga - 1-2023125277
- Sabrine Silva Marques - 1-2024130737



---

## Descrição do Projeto

Este projeto é uma implementação do padrão de design **Abstract Factory** em C#. O objetivo do projeto é simular um sistema de pagamento que permite ao usuário escolher entre dois bancos (Banco A e Banco B) e dois métodos de pagamento (Cartão de Crédito ou PIX). Dependendo das escolhas do usuário, o sistema cria e processa o pagamento de forma adequada.

O padrão **Abstract Factory** foi utilizado para criar diferentes tipos de fábricas (fábrica para Banco A e fábrica para Banco B), que por sua vez produzem diferentes tipos de pagamento (Cartão de Crédito e PIX).

OBS: Lembrando que esse projeto tem como objetivo fins academicos para os membros em questão.

## Estrutura do Projeto

O projeto segue a seguinte estrutura:

- **IPayment**: Interface que define o comportamento de um pagamento.
- **CreditCardPayment**: Implementa a interface IPayment para processar pagamentos por Cartão de Crédito.
- **PixPayment**: Implementa a interface IPayment para processar pagamentos via PIX.
- **IPaymentFactory**: Interface que define o comportamento de uma fábrica de pagamentos.
- **BankAPaymentFactory**: Implementa IPaymentFactory para criar métodos de pagamento para o Banco A.
- **BankBPaymentFactory**: Implementa IPaymentFactory para criar métodos de pagamento para o Banco B.
- **Program**: Ponto de entrada do programa, onde o usuário escolhe o banco e o método de pagamento, e o pagamento é processado.

## Design Pattern Utilizado

O padrão de projeto **Abstract Factory** foi escolhido para esse projeto, pois ele permite a criação de famílias de objetos relacionados (pagamentos de diferentes tipos) sem especificar suas classes concretas. Nesse exemplo, o padrão é usado para criar diferentes formas de pagamento dependendo do banco escolhido.

## Funcionalidades

- O usuário pode escolher entre dois bancos: **Banco A** e **Banco B**.
- O usuário pode escolher entre dois métodos de pagamento: **Cartão de Crédito** ou **PIX**.
- O sistema processa o pagamento de acordo com as opções escolhidas pelo usuário.

## Instruções de Instalação e Execução

### Pré-requisitos

Para rodar este projeto, é necessário ter o .NET SDK instalado. Você pode baixá-lo no site oficial da Microsoft: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

### Passos para Rodar o Projeto

1. **Clonar o Repositório**

   No terminal, clone o repositório para sua máquina local:

   ```bash
   git clone https://github.com/LuizGuilhes123/AbstractFactoryPayment.git
