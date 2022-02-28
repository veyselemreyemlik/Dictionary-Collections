using System;
using System.Collections.Generic;

namespace Dictionary_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int,string> kullanıcılar = new Dictionary<int,string>();

            kullanıcılar.Add (10, "Veysel Emre");
            kullanıcılar.Add (7, "Veysel Yemlik");
            kullanıcılar.Add (17, "Emre Yemlik");
            kullanıcılar.Add (27, "Veysel");
            kullanıcılar.Add (37, "Emre");

            // Dizinin Elemanlarına Erişim
            Console.WriteLine("*************Dizinin Elemanalarına Erişim**************");
            Console.WriteLine(kullanıcılar[17]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            // Count ile kullanıcıları ekrana yazdırma.
            Console.WriteLine("***************Count**************");
            Console.WriteLine(kullanıcılar.Count);

            // Contais 
            Console.WriteLine("**************Contais***************");
            Console.WriteLine(kullanıcılar.ContainsKey(7));
            Console.WriteLine(kullanıcılar.ContainsValue("Veysel"));

            // Remove 
            Console.WriteLine("**************Remove***************");
            kullanıcılar.Remove(17);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("**************Keys***************");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("**************Values***************");
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }



        }
    }
}
