Console.WriteLine("Seja Bem - Vindo a Aluguel de Carros FreiTax!");
Console.WriteLine("Digite seu Nome e Sobrenome por favor: ");

var nomeSobrenome = Console.ReadLine();

Console.WriteLine("Possui CNH? 1 pra sim e 2 pra não");
int.TryParse(Console.ReadLine(), out int cnh);

switch (cnh)
{
    case 1:
        {
            Console.WriteLine("Seguindo para as opões do veiculo!");
            Console.WriteLine("Opção 1: Audi A5 2.0");
            Console.WriteLine("Opção 2: BWM 320i Sport 3.5");
            Console.WriteLine("Opção 3: Mercedez Benz GLA 2.5");
            Console.WriteLine("Opção 4: Chevrolet Camaro 6.2 V8");
            Console.WriteLine("Escolha seu veículo! Opçoes de 1 a 4.");
            int.TryParse(Console.ReadLine(), out int carro);
            switch (carro)
            {
               case 1:
                    Console.WriteLine("Audi A5 2.0");
                    Console.WriteLine("Opcionais: AR, Direção Elétrica, GPS");
                    Console.WriteLine("Gasto Médio = 9,5 KM/Litro");
                    break;
                case 2:
                    Console.WriteLine("BMW 320i Sport 3.5");
                    Console.WriteLine("Opcionais: AR, Direção Elétrica, GPS");
                    Console.WriteLine("Gasto Médio = 7,5 KM/Litro");
                    break;
                case 3:
                    Console.WriteLine("Mercedez Benz GLA 2.5");
                    Console.WriteLine("Opcionais: AR, Direção Elétrica, GPS");
                    Console.WriteLine("Gasto Médio = 8 KM/Litro");
                    break;
                case 4:
                    Console.WriteLine("Chevrolet Camaro 6.2 V8");
                    Console.WriteLine("Opcionais: AR, Direção Elétrica, GPS");
                    Console.WriteLine("Gasto Médio = 5 KM/Litro");
                    break;
                default:
                    Console.WriteLine("Opção Inválida, escolha de 1 á 4!!");
                    break;
            }

            break;
        }

    default:
        Console.WriteLine("Desculpe,você precisa ter CNH para continuar!");
        break;
}




