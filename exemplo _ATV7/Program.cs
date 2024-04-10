int opcao;
do
{
    do
    {

        Console.WriteLine("=========MENU=========");
        Console.WriteLine("0 - SAIR");
        Console.WriteLine("1 - EX1");
        Console.WriteLine("2 - EX2");
        Console.WriteLine("3 - EX3");

        opcao = int.Parse(Console.ReadLine());

    } while (opcao < 0 || opcao > 3);

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Obrigado por usar o sistema!");
            break;
        case 1:
            Console.WriteLine("Executando o ex1");
            break;
        case 2:
            Console.WriteLine("Executando o ex2");
            break;
        case 3:
            Console.WriteLine("Executando o ex3");
            break;
    }

} while (opcao != 0);