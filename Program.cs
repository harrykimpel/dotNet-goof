using System;
using Halibut;

namespace dotNet_goof
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Text.Encodings.Web.HtmlEncoder.Default.Encode("...");
        }
    }

}
