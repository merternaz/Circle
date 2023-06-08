using System;
using System.Collections.Generic;

namespace structures
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
             double h;
            double r=0;
            Console.WriteLine("Yari cap giriniz: ");
            if(!double.TryParse(Console.ReadLine(),out r) || r<=0){

                Console.WriteLine("Negatif olamaz !");
            }else{

                for(int i=0;i<8;i++){

                    Console.WriteLine("Degree:"+45*i+" "+(MathF.Sin(45*i))*r+" ###  "+Math.Cos(45*i)*r);
                }

            }
        }
    }
}