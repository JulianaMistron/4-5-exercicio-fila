using _4_5_exercicio_fila;

internal class Program
{
    private static void Main(string[] args)
    {
        FilaNumero minhaFila1 = new FilaNumero();
        FilaNumero minhaFila2 = new FilaNumero();
        FilaNumero minhaFilaAuxiliar = new FilaNumero();


        int opc;
        do
        {
            Console.WriteLine("\n>>>MENU PRINCIPAL - FILA DE NÚMEROS<<<");
            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Inserir número na fila 1");
            Console.WriteLine("2 - Inserir número na fila 2");
            Console.WriteLine("3 - Remover número na fila 1");
            Console.WriteLine("4 - Remover número na fila 2");
            Console.WriteLine("5 - Imprimir fila 1");
            Console.WriteLine("6 - Imprimir fila 2");
            Console.WriteLine("7 - Comparar o tamanho das filas");
            Console.WriteLine("8 - Calcular para fila 1: média, menor e maior número");
            Console.WriteLine("9 - Calcular para fila 2: média, menor e maior número");
            Console.WriteLine("10 - Trocar elementos de fila 1");
            Console.WriteLine("11 - Trocar elementos de fila 2");
            Console.WriteLine("12 - Ímpares fila 1");
            Console.WriteLine("13 - Ímpares fila 2");
            Console.WriteLine("14 - Pares fila 1");
            Console.WriteLine("15 - Pares fila 2");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Informe a opção desejada: \b\b");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    minhaFila1.push(cadastro_numero());
                    break;
                case 2:
                    minhaFila2.push(cadastro_numero());
                    break;
                case 3:
                    minhaFila1.pop();
                    break;
                case 4:
                    minhaFila2.pop();
                    break;
                case 5:
                    minhaFila1.print();
                    break;
                case 6:
                    minhaFila2.print();
                    break;
                case 7:
                    CompararTamanhos(minhaFila1, minhaFila2);
                    break;
                case 8:
                    minhaFila1.Calcular();
                    break;
                case 9:
                    minhaFila2.Calcular();
                    break;
                case 10:
                    minhaFila1.TransferirImprimir(minhaFilaAuxiliar);
                    Console.WriteLine("Início da impressão da fila auxiliar: ");
                    minhaFilaAuxiliar.print();
                    break;
                case 11:
                    minhaFila2.TransferirImprimir(minhaFilaAuxiliar);
                    Console.WriteLine("Início da impressão da pilha auxiliar: ");
                    minhaFilaAuxiliar.print();
                    break;
                case 12:
                    minhaFila1.Impares();
                    break;
                case 13:
                    minhaFila2.Impares();
                    break;
                case 14:
                    minhaFila1.Pares();
                    break;
                case 15:
                    minhaFila2.Pares();
                    break;
                case 0:
                    Console.WriteLine("Fim do programa :)");
                    break;
                default:
                    Console.WriteLine("Opção inexistente");
                    break;
            }
        } while (opc != 0);

        static Numero cadastro_numero()
        {
            int numero;
            Console.WriteLine("\nInforme o número");
            numero = int.Parse(Console.ReadLine());
            return new Numero(numero);
        }
        static void CompararTamanhos(FilaNumero minhaFila1, FilaNumero minhaFila2)
        {
            int tamanhoFila1 = minhaFila1.quantidade();
            int tamanhoFila2 = minhaFila2.quantidade();

            if (tamanhoFila1 == tamanhoFila2)
            {
                Console.WriteLine("As filas têm o mesmo tamanho.");
            }
            else if (tamanhoFila1 > tamanhoFila2)
            {
                Console.WriteLine("A fila 1 é maior que a fila 2.");
            }
            else
            {
                Console.WriteLine("A fila 2 é maior que a fila 1.");
            }
        }
    }
}