using HF2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace ModernLangToolsApp
{
    class Program
    {
        [Description("Feladat2")]
        public static void Masodik(Jedi jedi)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Jedi));
            FileStream fileStream = new FileStream("jedi.txt", FileMode.Create);
            serializer.Serialize(fileStream, jedi);
            fileStream.Close();

            fileStream = new FileStream("jedi.txt", FileMode.Open);
            Jedi clone = (Jedi)serializer.Deserialize(fileStream);
            fileStream.Close();
        }

        static void MessageReceived(string Message)
        {
            Console.WriteLine(Message);
        }

        [Description("Feladat3")]
        static void CouncilTest()
        {
            JediCouncil council = new JediCouncil();
            council.CouncilChanged += MessageReceived;
            council.Add(new Jedi());
            council.Add(new Jedi());
            council.Remove();
            council.Remove();
        }
        [Description("Feladat4")]
        static void BeginnerTest(JediCouncil jediCouncil)
        {
            Console.WriteLine("Kezdő jedik:");
            foreach (var jedi in jediCouncil.GetBeginners())
            {
                Console.WriteLine(jedi.Name);
            }
        }

        static void Main(string[] args)
        {
            CouncilTest();

            JediCouncil jediCouncil = new JediCouncil();
            jediCouncil.Add(new Jedi());
            BeginnerTest(jediCouncil);
            Console.ReadKey();
        }
    }
}
