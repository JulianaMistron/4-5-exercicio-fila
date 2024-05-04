namespace _4_5_exercicio_fila
{
    internal class Numero
    {
        int numero;
        int valor;
        Numero proximo;

        public Numero(int numero)
        {
            this.numero = numero;
            this.proximo = null;
        }
        public override string? ToString()
        {
            return "\n\n>>>>NÚMERO: " + numero;
        }
        public void setNext(Numero numero)
        {
            proximo = numero;
        }
        public Numero getNext()
        {
            return proximo;
        }
        public int getValor()
        {
            return numero;
        }
    }
}