namespace Aula25Recursividade
{
    public class Fibonacci
    {
        
        public void GerarFibonacci(int num1, int num2, int vezes){

            if( vezes >= 0 ){

                System.Console.WriteLine(num1);
                GerarFibonacci(num2, num1 + num2, vezes -1);

            }

        }

        public void GerarTribonacci( int numero1, int numero2, int numero3, int vezes ){

            if( vezes>= 0 ){

                System.Console.WriteLine(numero1);
                GerarTribonacci(numero2, numero3, numero1 + numero2 + numero3, vezes-1);


            }

        }

    }
}