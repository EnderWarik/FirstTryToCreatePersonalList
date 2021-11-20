using System;
using System.Collections.Generic;
using System.Text;

namespace MishaTZ
{
    class EnderList<T> : Interface1<T>
    {
        
        public static int capaсity = 10;
        int size = 0;


        T[] array = new T[capaсity];
        
        public void add(int index, T obj)
        {
            array[index] = obj;
            size++;
            if((((float)size / capaсity) * 100)>70) { Console.WriteLine("EEEE"); Resize(ref array); }
        }

        public void Out(int index)
        {
            //Console.WriteLine(array[index]);
            for (int i = 0; i < capaсity; i++) Console.WriteLine(array[i]);
        }
        void Resize(ref T[]array)
        {
            capaсity = capaсity * 2;
            T[] arr = new T[capaсity*2];
            for(int i = 0; i< array.Length;i++)
            {
                arr[i]=array[i];
            }
            
            array = arr;
            
        }

        public void Remove(int index)
        {
           // object obj = null;
       //     array[index]=;
        }

        public int Capaсity { get { return capaсity; } }
        public int Size { get {return size ; } }
    }
}
