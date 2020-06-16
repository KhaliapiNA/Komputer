using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komputer
{
    class ZPU
    {
        public void OperationA()
        {
            Console.WriteLine("загрузка ЦПУ");
        }
    }
    class Pamyt
    {
        public void OperationB()
        {
            Console.WriteLine("загрузка памяти");
        }
    }
    class Gost_Disk
    {
        public void OperationC()
        {
            Console.WriteLine("чтение данных");
        }
    }

    class Monitor
    {
        public void Print(char p)
        {
            Console.WriteLine(p);
        }
    }

    class Komputer
    {
        ZPU zpu = new ZPU();
        Pamyt pamyt = new Pamyt();
        Gost_Disk gos_disk = new Gost_Disk();
        Monitor monitor= new Monitor();

        public void LoadZPU()
        {
            zpu.OperationA();
            pamyt.OperationB();
            gos_disk.OperationC();
           
        }

        public void Print(char p)
        {
            monitor.Print(p);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Komputer komputer = new Komputer();
            komputer.LoadZPU();
            komputer.Print('@');
            Console.ReadLine();
        }
    }
}
