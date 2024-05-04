namespace _4_5_exercicio_fila
{
    internal class FilaNumero
    {
        Numero head;
        Numero tail;

        public FilaNumero()
        {
            this.head = null;
            this.tail = null;
        }
        public void push(Numero aux)
        {
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                tail.setNext(aux);
                tail = aux;
            }
        }
        public void Pop()
        {
            if (!IsEmpty())
            {
                if (tail == head)
                {
                    head = tail = null;
                }
                else
                {
                    this.head = head.getNext();
                }
            }
        }
        bool vazia()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void print()
        {
            Numero aux = head;
            if (vazia())
            {
                Console.WriteLine("Fila vazia!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getNext();
                } while (aux != null);

                Console.WriteLine("Fim da impressão!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine("Fila vazia! Impossível remover!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                head = head.getNext();
            }
        }

        public int quantidade()
        {
            Numero aux = head;
            if (vazia())
            {
                return 0;
            }
            else
            {
                int cont = 0;
                do
                {
                    cont++;
                    aux = aux.getNext();
                } while (aux != null);
                return cont;
            }
        }

        static void CompararTamanhos(FilaNumero minhafila1, FilaNumero minhafila2)
        {
            int tamanhoFila1 = minhafila1.quantidade();
            int tamanhoFila2 = minhafila2.quantidade();

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

        public void Calcular()
        {
            Numero aux = head;
            int size = this.quantidade();
            int indice = 0;
            int soma = 0;
            int maiorNumero = 0;
            int menorNumero = Int32.MaxValue;
            float media = 0;


            if (vazia())
            {
                Console.WriteLine("Fila vazia!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    // média
                    soma += aux.getValor();
                    indice++;

                    // menor número
                    if (menorNumero > aux.getValor())
                        menorNumero = aux.getValor();

                    // maior número
                    if (maiorNumero < aux.getValor())
                        maiorNumero = aux.getValor();

                    aux = aux.getNext();
                } while (aux != null);

                media = ((float)soma / (float)size);
                Console.WriteLine("\nMédia : " + media);
                Console.WriteLine("\nMenor número da fila : " + menorNumero);
                Console.WriteLine("\nMaior número da fila : " + maiorNumero);
            }
        }

        public void TransferirImprimir(FilaNumero minhaFilaAuxiliar)
        {
            Numero aux = head;
            minhaFilaAuxiliar.push(aux);
            if (vazia())
            {
                Console.WriteLine("Fila vazia!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    pop();
                    aux = head;
                } while (aux != null);
            }
        }
        public void Impares()
        {
            Numero aux = head;
            int quantidadeImpares = 0;

            Console.WriteLine("Elementos ímpares:");

            while (aux != null)
            {
                int valor = aux.getValor();
                if (valor % 2 != 0)
                {
                    quantidadeImpares++;
                    Console.WriteLine(valor);
                }
                aux = aux.getNext();
            }

            Console.WriteLine("Quantidade de números ímpares: " + quantidadeImpares);
        }
        public void Pares()
        {
            Numero aux = head;
            int quantidadePares = 0;

            Console.WriteLine("Elementos pares:");

            while (aux != null)
            {
                int valor = aux.getValor();
                if (valor % 2 == 0)
                {
                    quantidadePares++;
                    Console.WriteLine(valor);
                }
                aux = aux.getNext();
            }

            Console.WriteLine("Quantidade de números pares: " + quantidadePares);
        }
        public bool IsEmpty()
        {
            return head == null && tail == null;
        }

    }
}

