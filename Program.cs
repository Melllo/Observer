using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Zhek zhek = new Zhek();
            Flat flat1 = new Flat("Soborna 13, 6", zhek);
            Flat flat2 = new Flat("Morehodnaya 10a, 3", zhek);

            
            zhek.addPosition("tasnsport of gas = 56.90");
        }
    }
}
