using System;
using System.Diagnostics;

namespace RunEdge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process.Start($"microsoft-edge:{String.Join(" ", args)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
