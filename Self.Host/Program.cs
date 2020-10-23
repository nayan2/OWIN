using System;
using Microsoft.Owin.Hosting;

namespace Self.Host
{
    // http://www.codedigest.com/posts/1/what-is-owin-a-beginners-guide
    // http://www.codedigest.com/posts/2/creating-our-first-owin-based-application
    internal static class Program
    {
        public static void Main(string[] args)
        {
            WebApp.Start("http://localhost:5001");
            Console.WriteLine("Server Started...Press any key to exit");
            Console.ReadLine();
        }
    }
}