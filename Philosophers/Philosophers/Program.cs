using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Philosophers
{
    class Program
    {
        public static bool[] tenedores = new bool[5];

        delegate void ManejadorFilosofos();

        static void Main(string[] args)
        {
            Thread filo1 = new Thread(Filosofo1);
            Thread filo2 = new Thread(Filosofo2);
            Thread filo3 = new Thread(Filosofo3);
            Thread filo4 = new Thread(Filosofo4);
            Thread filo5 = new Thread(Filosofo5);

            ManejadorFilosofos maneja1 = new ManejadorFilosofos(filo1.Start);
            ManejadorFilosofos maneja2 = new ManejadorFilosofos(filo2.Start);
            ManejadorFilosofos maneja3 = new ManejadorFilosofos(filo3.Start);
            ManejadorFilosofos maneja4 = new ManejadorFilosofos(filo4.Start);
            ManejadorFilosofos maneja5 = new ManejadorFilosofos(filo5.Start);

            maneja1();
            maneja2();
            maneja3();
            maneja4();
            maneja5();
        }

        public static void Filosofo1()
        {
            while (true)
            {
                lock (tenedores)
                {
                    Console.WriteLine("Filosofo 1 agarra tenedor derecho...");
                    tenedores[0] = true;
                    Thread.Sleep(100);
                    lock (tenedores)
                    {
                        Console.WriteLine("Filosofo 1 agarra tenedor izquierdo...");
                        tenedores[4] = true;
                        Thread.Sleep(1000);
                        tenedores[0] = false;
                        tenedores[4] = false;
                        Console.WriteLine("Comio Filosofo 1");
                    }
                }
            }
        }

        public static void Filosofo2()
        {
            while (true)
            {
                lock (tenedores)
                {
                    Console.WriteLine("Filosofo 2 agarra tenedor derecho...");
                    tenedores[1] = true;
                    Thread.Sleep(100);
                    lock (tenedores)
                    {
                        Console.WriteLine("Filosofo 2 agarra tenedor izquierdo...");
                        tenedores[0] = true;
                        Thread.Sleep(1000);
                        tenedores[0] = false;
                        tenedores[1] = false;
                        Console.WriteLine("Comio Filosofo 2");
                    }
                }
            }
        }

        public static void Filosofo3()
        {
            while (true)
            {
                lock (tenedores)
                {
                    Console.WriteLine("Filosofo 3 agarra tenedor derecho...");
                    tenedores[2] = true;
                    Thread.Sleep(100);
                    lock (tenedores)
                    {
                        Console.WriteLine("Filosofo 3 agarra tenedor izquierdo...");
                        tenedores[1] = true;
                        Thread.Sleep(1000);
                        tenedores[1] = false;
                        tenedores[2] = false;
                        Console.WriteLine("Comio Filosofo 3");
                    }
                }
            }
        }

        public static void Filosofo4()
        {
            while (true)
            {
                lock (tenedores)
                {
                    Console.WriteLine("Filosofo 4 agarra tenedor derecho...");
                    tenedores[3] = true;
                    Thread.Sleep(100);
                    lock (tenedores)
                    {
                        Console.WriteLine("Filosofo 4 agarra tenedor izquierdo...");
                        tenedores[2] = true;
                        Thread.Sleep(1000);
                        tenedores[2] = false;
                        tenedores[3] = false;
                        Console.WriteLine("Comio Filosofo 4");
                    }
                }
            }
        }

        public static void Filosofo5()
        {
            while (true)
            {
                lock (tenedores)
                {
                    Console.WriteLine("Filosofo 5 agarra tenedor derecho...");
                    tenedores[4] = true;
                    Thread.Sleep(100);
                    lock (tenedores)
                    {
                        Console.WriteLine("Filosofo 5 agarra tenedor izquierdo...");
                        tenedores[3] = true;
                        Thread.Sleep(1000);
                        tenedores[3] = false;
                        tenedores[4] = false;
                        Console.WriteLine("Comio Filosofo 5");
                    }
                }
            }
        }
    }
}
