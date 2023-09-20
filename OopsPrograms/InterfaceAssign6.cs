using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    /*Create interface Cake with a method declared as bake. Create 2 classes Strawberry, BlackForest both
     * implementing Cake interface*/
    internal class InterfaceAssign6
    {
        static void Main(string[] args)
        {
            Strawberry s = new Strawberry();
            s.Bake();
            BlackForest b= new BlackForest();
            b.Bake();
        }
    }
    public interface ICake
    {
        void Bake();
    }
    public class Strawberry : ICake
    {
        public void Bake()
        {
            Console.WriteLine("Interface Implemented in Strawberry class");
        }
    }
    public class BlackForest : ICake
    {
        public void Bake()
        {
            Console.WriteLine("Interface Implemented in BlackForest class");
        }
    }
}
