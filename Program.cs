using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    public class Building
    {
        string address;
        double length;
        double width;
        double height;
        
        public Building (string address, double length, double width, double height)
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double Long
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public void Print()
        {
            Console.WriteLine("Описание здания:");
            Console.WriteLine($"Адрес - {address}");
            Console.WriteLine($"Длина - {length}");
            Console.WriteLine($"Ширина - {width}");
            Console.WriteLine($"Высота - {height}");
        }
    }
    public class MultiBuilding:Building
    {
        double floors;
        public MultiBuilding(string address, double length, double width, double height, double floors)
            :base (address, length, width,height)
        {
            base.Address = address;
            this.Long = length;
            this.Width = width;
            this.Height = height;
            this.floors = floors;
        }
        public double Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Этажей - {Math.Truncate(Height / 2.7)}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес здания; его длину; его ширину; его высоту (каждый параметр вводится с новой строки):");
            Building building = new Building(Console.ReadLine(),Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));            
            building.Print();            
            MultiBuilding multiBuilding = new MultiBuilding(building.Address, building.Long, building.Width, building.Height, building.Height);
            Console.WriteLine("----------------");
            Console.WriteLine("При условии высоты этажа 2,7 метра:");            
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
}
