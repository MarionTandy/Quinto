using System;
using System.Runtime.CompilerServices;
using System.Xml;
using Newtonsoft.Json;


using System.IO;




namespace serializejson
{
    class Program
    {
        static Lexique lexique = new Lexique();
        static void Main(string[] args)
        {

            string dossier = @"C:\Users\CDA\source\repos";
            TestSaveJson(dossier);


        }
        private static void TestSaveJson(string dossier)
        {
            Console.WriteLine(lexique.SaveJson(dossier));
            Console.WriteLine(lexique.LoadJson(dossier));

        } 
    }
}
