using Indexer.Models;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ListInt class-ı yaradın. İçində private int[] array-ı olsun. Indexer vasitəsi ilə obyektə index yazdıqca o indexə uyğun həmin private arrayın həmin indexinə uyğun elementini get və set etmək olsun. ListInt class-ı daxilindəki methodlar.

            Add(int num)
            Add(params int[] nums) - Göndərilən parametrləri arraya daxil edir.
            Contains(int num) - Göndərilən ədəd array-da varsa true yoxdursa false qaytarır.
            Pop() - Array-ın sonuncu elementini arraydan silir və həmin elementi geri qaytarır.
            Sum() - Array-ı cəmləyir.
            ToString() - Array-ın elementlərini tək sıra geri qaytarır 
            */


            ListInt list = new ListInt();
            list.Add(1,2,3,4);

            list.ForeachList();
        }
    }
}