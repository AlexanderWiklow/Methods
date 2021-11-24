using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2Vecka2
{
    class Program
    {
        static void Main(string[] args)
        {

            int rader = 0;
            int kolumner = 0;

            Random rnd = new Random();

            // Användaren anger antal rader som sparas i en int 
            Console.WriteLine("Hur många rader ska finnas med?");
            rader = int.Parse(Console.ReadLine());

            // Användaren anger antal kolumner som sparas i en int 
            Console.WriteLine("Hur många kolumner ska finnas med?");
            kolumner = int.Parse(Console.ReadLine());

            // Deklarera array med variablerna 
            int[,] TalArray = new int[rader, kolumner];

            // Deklarera en variabel som håller reda på antal slumptal som genereras
            // int AntalTal = 0;

            // En variabel som håller reda på summan av alla talen och medelvärde
            //int sum = 0;
            //int avg = 0;

            //// Yttre loop som håller reda på raderna
            //for (int i = 0; i < rader; i++)
            //{
            //    // Inre loop som håller reda på kolumnerna i arrayen 
            //    // (j) används för att referera till kolumnerna i arrayen
            //    for (int j = 0; j < kolumner; j++)
            //    {
            //        // Fyll sedan arrayen med slumptal mellan 1 och 20
            //        TalArray[i, j] = rnd.Next(1, 21);
            //        AntalTal++;
            //        sum += TalArray[i, j];
            //        // Sum = TalArray[i] + TalArray[j];
            //    }
            //}

            // Uträkning för medelvärdet
            // avg = sum / AntalTal;

            int average = CalcAverage(TalArray, rader, kolumner);
            int antalsiffror = CalcAntal(TalArray, rader, kolumner);


            Console.WriteLine("Antal tal {0} ", antalsiffror);
            Console.WriteLine("Medelvärdet blir {0} ", average);

            Console.ReadLine();
        }

        static int CalcAverage(int[,] TalArray, int Row, int Col)
        {
            Random rnd = new Random();
            int avg = 0;
            int AntalTal = 0;
            int sum = 0;

            // Yttre loop som håller reda på raderna
            for (int i = 0; i < Row; i++)
            {
                // Inre loop som håller reda på kolumnerna i arrayen 
                // (j) används för att referera till kolumnerna i arrayen
                for (int j = 0; j < Col; j++)
                { 
                    // Fyll sedan arrayen med slumptal mellan 1 och 20
                    TalArray[i, j] = rnd.Next(1, 21);
                    AntalTal++;
                    sum += TalArray[i, j];
                    // Sum = TalArray[i] + TalArray[j];
                }
            }

            avg = sum / AntalTal;
            return avg;
        }



        static int CalcAntal(int[,] TalArray, int Row, int Col)
        {
            //Random rnd = new Random();
            //int avg = 0;
            //int sum = 0;

            int AntalTal = 0;

            // Yttre loop som håller reda på raderna
            for (int i = 0; i < Row; i++)
            {
                // Inre loop som håller reda på kolumnerna i arrayen 
                // (j) används för att referera till kolumnerna i arrayen
                for (int j = 0; j < Col; j++)
                {
                    // Fyll sedan arrayen med slumptal mellan 1 och 20
                    // TalArray[i, j] = rnd.Next(1, 21);
                    AntalTal++;
                    //sum += TalArray[i, j];
                    // Sum = TalArray[i] + TalArray[j];
                }
            }

            //avg = sum / AntalTal;
            return AntalTal;
        }
    }
}
