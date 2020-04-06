using System;

namespace Hotels_EANAreaSync
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hotels area sync started.");
            AreaSync areaSync = new AreaSync();
            areaSync.Start();
            Console.WriteLine("Hotels area sync finished.");
        }
    }
}
