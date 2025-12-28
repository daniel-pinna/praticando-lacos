void calculadoraVendas() {
    double totalVendas = 0;
    double valorVenda = 0;
    do {
        Console.Write("Digite o valor da venda (ou 0 para encerrar):");
        valorVenda = Convert.ToDouble(Console.ReadLine());
        totalVendas += valorVenda;
    } while (valorVenda != 0D);
    Console.WriteLine($"Total de vendas do dia: R${totalVendas}");
}

void controleEstoque() {
    int estoque = 0;

    Console.WriteLine("Deseja adicionar um produto ao estoque?");
    Console.WriteLine("1 - Sim | 0 - Não");
    int resposta = int.Parse(Console.ReadLine()!);

    while (resposta == 1)
    {
        Console.WriteLine("Quantidade:");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        estoque += quantidade;
    
        Console.WriteLine($"Estoque atual: {estoque}");
    
        Console.WriteLine("Deseja continuar?");
        Console.WriteLine("1 - Sim | 0 - Não");
        resposta = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Obrigado por usar nosso sistema de estoque!");
}

void numeroSecreto() {
    int numeroSecreto = 7;

    Console.WriteLine("Tente adivinhar o número entre 1 e 10:");
    int resposta = int.Parse(Console.ReadLine()!);

    while (resposta != 7)
    {
        Console.WriteLine("Você errou! Tente novamente:");
        resposta = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine("Parabéns, você acertou!");
}

void chamadaEscolar() {
    List<string> listaAlunos = new List<string> { "Ana", "Carlos", "Bianca", "João", "Mariana" };

    Console.WriteLine("Digite o nome do aluno:");
    string resposta = Console.ReadLine()!;
    bool encontrado = false;

    int contador = 0;
    while (contador < listaAlunos.Count)
    {
        if (resposta == listaAlunos[contador])
        {
            Console.WriteLine($"Aluno encontrado na posição: {contador}");
            encontrado = true;
            break;
        }
        contador++;
    }

    if (!encontrado)
    {
        Console.WriteLine("Aluno não está presente na lista");
    }
}

void chamadaSenhas()
{
    int senhaGerada = 0;
    int senhaAtual = 0;
    int opcao;
    
    do {
        Console.WriteLine("1 - Gerar nova senha");
        Console.WriteLine("2 - Chamar próxima senha");
        Console.WriteLine("3 - Sair");

        Console.Write("Escolha uma opção: ");
        opcao = int.Parse(Console.ReadLine());
        
        switch (opcao)
        {
            case 1:
                senhaGerada++;
                Console.WriteLine("Senha gerada: " + senhaGerada.ToString("D3"));
                break;
            case 2:
                senhaAtual++;
                Console.WriteLine("Senha chamada: " + senhaAtual.ToString("D3"));
                break;
            case 3:
                Console.WriteLine("Encerrando sistema.");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    } while (opcao != 3);    
}

void conversorTemperatura() {
    int opcao;
    do {
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");
        Console.WriteLine("3 - Sair");

        Console.Write("Escolha uma opção: ");
        opcao = int.Parse(Console.ReadLine());
    
        switch (opcao)
        {
            case 1:
                Console.Write("Digite a temperatura em Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F");
                break;
            case 2:
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double fahr = double.Parse(Console.ReadLine());
                double cel = (fahr - 32) * 5 / 9;
                Console.WriteLine($"{fahr}°F equivalem a {cel}°C");
                break;
            case 3:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    } while (opcao != 3);
}

void listaComExclusao() {
    for (int i = 1; i <= 20; i++)
    {
         if (i % 3 == 0)
        {
            continue;
        }

        Console.WriteLine(i);
    }
}

void exibeTabuada() {
    int numeroEscolhido = 7;

    for (int i = 1; i <= 10; i++)
    {
        int resultado = numeroEscolhido * i;
        Console.WriteLine($"{numeroEscolhido} x {i} = {resultado}");
    }
}

void exibeResultadoNotas() {
    List <int> notas = new List<int> { 4, 7, 5, 9, 6 };

    foreach (int nota in notas) {
        if (nota <= 5) {
            Console.WriteLine($"Nota {nota} - Reprovado");
        } else {
            Console.WriteLine($"Nota {nota} - Aprovado");
        }
    }
}

void exibeAlertaAprovaoReprovacao() {
    List<double> notas= new List<double>{8.5, 6.2, 9.1, 5.8, 7.4};

    foreach (double nota in notas) {
        if (nota >= 7.0) {
            Console.WriteLine($"O aluno com a nota {nota} está indo muito bem!");
        } else {
            Console.WriteLine($"O aluno com a nota {nota} está abaixo da média!");
        }
    }
}

void totalNumeroImpares() {
    int qtdImpares = 0;
    
    for (int i = 0; i < 10; i++) {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);
    
        if (numero % 2 != 0) {
            qtdImpares++;
        }
    }
    
    Console.WriteLine($"Você digitou {qtdImpares} números ímpares.");    
}

// calculadoraVendas();
// controleEstoque();
// numeroSecreto();
// chamadaEscolar();
// chamadaSenhas();
// conversorTemperatura();
// listaComExclusao();
// exibeTabuada();
// exibeResultadoNotas();
// exibeAlertaAprovaoReprovacao();
totalNumeroImpares();