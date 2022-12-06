using System;
namespace Seoul
{
    class SeoulTower
    {
        public void print()
        {
            Console.WriteLine("서울 타워");
        }
    }
    namespace Namdaemoon
    {
        class Gate
        {
            public void print()
            {
                Console.WriteLine("남대문");
            }
        }
    }
}
namespace namespace_nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Seoul.SeoulTower tower = new Seoul.SeoulTower();
            Seoul.Namdaemoon.Gate gate = new Seoul.Namdaemoon.Gate();
            tower.print();
            gate.print();
        }
    }
}
