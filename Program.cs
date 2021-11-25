using System;

namespace SomaDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            soma  int = 0;
           Console . Write ( " Digite um número positivo inteiro: " );
            char [] caracteres  =  Console . ReadLine (). ToCharArray ();

             int [] digitos  =  retornaListaDigitos ( caracteres );

            Console . Write ( " Digitos: " );

            for ( int  i  =  0 ; i  <  caracteres.Length; i ++ )
            {
                Console . Write ($" { digitos [ i ]} " );

              soma + = digitos [ i ];
              
            }
            Console . WriteLine ($" \nSoma= {soma}");
        }

        static  int [] retornaListaDigitos ( char [] entrada )
        {
            int [] digitos  =  new  int [ entrada.Length ];

            for ( int  i  =  0; i<  entrada.Length; i ++ )
            {
                digitos [ i ] =  entrada [ i ] -  '0';
            }

            return  digitos ;
        
        }
    }
}
