using System;
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("İstanbul");
            myDictionary.Add("İzmit");
            myDictionary.Add("Edirne");
            Console.WriteLine(myDictionary.Count);
        }
    }
    class MyDictionary<T>
    {
        T[] dizi;
        T[] geciciDizi;

        public MyDictionary()
        {
            dizi = new T[0];
        }

        public void Add(T item)
        {
            geciciDizi = dizi;
            dizi=new T[dizi.Length+1];
            for (int i = 0; i < geciciDizi.Length; i++)
            {
                dizi[i] = geciciDizi[i];
            }
            dizi[dizi.Length-1] = item;
        }

        public int Count
        {
            get { return dizi.Length; }
        }
    }

}
