using System;
using System.Collections.Generic;

namespace structures
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Yari çap giriniz:");
            if(!double.TryParse(Console.ReadLine(),out r) || r<=0){

                Console.WriteLine("Negatif olamaz !");
            }else{

            CIRCLE_TRGONO(r);
            }
           
        }

        public static void CIRCLE(){
            double r=0;
             Console.WriteLine("Yari cap giriniz: ");
            if(!double.TryParse(Console.ReadLine(),out r) || r<=0){

                Console.WriteLine("Negatif olamaz !");
            }else{

                for(int i=0;i<8;i++){

                    Console.WriteLine("Degree:"+45*i+" "+(MathF.Sin(45*i))*r+" ###  "+Math.Cos(45*i)*r);
                }

                for(double y=r;y>=-r;y--){//int y=0;y<=r;y++
                    double limit=0,bosluk=0;
                    if(y>=0){
                        limit=r-y;
                        bosluk=y;
                    }else{
                        limit=r+y;
                        bosluk=-y;
                    }

                    for(int i=0;i<bosluk;i++){
                        Console.Write(" ");
                    }

                    for(int i=0;i<limit*2;i++){
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                    
                }

            }
        }

        public static void CIRCLE_TRGONO(double r){

            double radyan;
         
            for(double x=3;x>0;x-=1/r){
                radyan=(30*x)*(Math.PI/180);
                double deger=Math.Cos((float)(radyan)); // Dairenin üst yarım alanı
                double bosluk=1-deger;

                for(double a=0;a<=bosluk*r;a+=0.1)     
                    Console.Write(" ");
                
                for(double a=0;a<=deger*r;a+=0.1){
                    Console.Write("*");
                }

                for(double a=0;a<=deger*r;a+=0.1){
                    Console.Write("*");
                }

                 for(double a=0;a<=bosluk*r;a+=0.1)     
                    Console.Write(" ");
                    
                Console.WriteLine();
            }

            for(double x=3;x>0;x-=1/r){
                radyan=(30*x)*(Math.PI/180);
                double deger=Math.Sin((float)(radyan)); // daireinni alt yarım alanı
                double bosluk=1-deger;

                for(double a=0;a<=bosluk*r;a+=0.1)     
                    Console.Write(" ");
                
                for(double a=0;a<=deger*r;a+=0.1){
                    Console.Write("*");
                }

                for(double a=0;a<=deger*r;a+=0.1){
                    Console.Write("*");
                }

                 for(double a=0;a<=bosluk*r;a+=0.1)     
                    Console.Write(" ");

                Console.WriteLine();
            }

            

            

        }
  }
} 