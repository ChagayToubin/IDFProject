﻿using System.Runtime.InteropServices.JavaScript;

namespace Idf
{
    internal class Program
    {
        public static List<Terrorist> listTerrorist = new List<Terrorist>();
        public static Hamas hamas;
        public static IntelligenceDepartment IntelligenceDepartmentt;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           

        }
        public static void initialization()
        {
            initializationTerroist();
            initializationhamas();
            initializationIntelligenceDepartment();
        }
        public static void initializationhamas()
        {
             hamas = new Hamas("0000", "ali ali", listTerrorist);
        }
        public static void initializationIntelligenceDepartment()
        {
            IntelligenceDepartmentt=new IntelligenceDepartment(hamas);
        }
        public static void initializationTerroist()
        {

            //List<Terrorist> listTerrorist = new List<Terrorist>();

            Terrorist person1 = new Terrorist("Tariq Ahmad", 2, true, new List<string> { "Knife", "RPG", "Explosives" });
            listTerrorist.Add(person1);
            Terrorist person2 = new Terrorist("Omar Ali", 5, true, new List<string> { "Handgun" });
            listTerrorist.Add(person2);
            Terrorist person3 = new Terrorist("Khaled Fadi", 1, true, new List<string> { "M16", "Knife", "RPG" });
            listTerrorist.Add(person3);
            Terrorist person4 = new Terrorist("Hassan Hassan", 3, true, new List<string> { "Knife" });
            listTerrorist.Add(person4);
            Terrorist person5 = new Terrorist("Ibrahim Omar", 4, true, new List<string> { "Explosives", "AK-47" });
            listTerrorist.Add(person5);
            Terrorist person6 = new Terrorist("Ahmad Khaled", 2, true, new List<string> { "Grenade" });
            listTerrorist.Add(person6);
            Terrorist person7 = new Terrorist("Ahmad Yasir", 1, true, new List<string> { "Explosives" });
            listTerrorist.Add(person7);
            Terrorist person8 = new Terrorist("Khaled Ali", 3, true, new List<string> { "Handgun", "AK-47", "Explosives" });
            listTerrorist.Add(person8);
            Terrorist person9 = new Terrorist("Hassan Nabil", 5, true, new List<string> { "Knife", "Explosives" });
            listTerrorist.Add(person9);
            Terrorist person10 = new Terrorist("Ahmad Ibrahim", 2, true, new List<string> { "Knife", "Grenade", "RPG" });
            listTerrorist.Add(person10);
            Terrorist person11 = new Terrorist("Tariq Ali", 4, true, new List<string> { "AK-47", "Grenade", "Explosives" });
            listTerrorist.Add(person11);
            Terrorist person12 = new Terrorist("Ahmad Yasir", 5, true, new List<string> { "Knife", "RPG", "M16" });
            listTerrorist.Add(person12);
            Terrorist person13 = new Terrorist("Fadi Omar", 1, true, new List<string> { "Explosives", "M16", "Knife" });
            listTerrorist.Add(person13);
            Terrorist person14 = new Terrorist("Hassan Fadi", 3, true, new List<string> { "Grenade" });
            listTerrorist.Add(person14);
            Terrorist person15 = new Terrorist("Tariq Khaled", 2, true, new List<string> { "Knife", "M16" });
            listTerrorist.Add(person15);
            Terrorist person16 = new Terrorist("Fadi Yasir", 1, true, new List<string> { "AK-47", "RPG", "Knife" });
            listTerrorist.Add(person16);
            Terrorist person17 = new Terrorist("Ibrahim Ahmad", 4, true, new List<string> { "RPG", "Handgun" });
            listTerrorist.Add(person17);
            Terrorist person18 = new Terrorist("Tariq Fadi", 5, true, new List<string> { "Knife", "RPG", "AK-47" });
            listTerrorist.Add(person18);
            Terrorist person19 = new Terrorist("Ali Ahmad", 1, true, new List<string> { "Knife", "Explosives" });
            listTerrorist.Add(person19);
            Terrorist person20 = new Terrorist("Ahmad Ali", 3, true, new List<string> { "Explosives" });
            listTerrorist.Add(person20);
            Terrorist person21 = new Terrorist("Ali Yasir", 4, true, new List<string> { "AK-47", "Explosives", "Handgun" });
            listTerrorist.Add(person21);
            Terrorist person22 = new Terrorist("Ahmad Hassan", 2, true, new List<string> { "M16", "Explosives", "Knife" });
            listTerrorist.Add(person22);
            Terrorist person23 = new Terrorist("Fadi Omar", 3, true, new List<string> { "Explosives", "Handgun" });
            listTerrorist.Add(person23);
            Terrorist person24 = new Terrorist("Tariq Ali", 1, true, new List<string> { "M16", "AK-47", "Knife" });
            listTerrorist.Add(person24);
            Terrorist person25 = new Terrorist("Ibrahim Khaled", 2, true, new List<string> { "Handgun", "Explosives" });
            listTerrorist.Add(person25);
            Terrorist person26 = new Terrorist("Ali Ali", 5, true, new List<string> { "Knife", "Explosives" });
            listTerrorist.Add(person26);
            Terrorist person27 = new Terrorist("Tariq Yasir", 1, true, new List<string> { "Explosives", "AK-47", "Knife" });
            listTerrorist.Add(person27);
            Terrorist person28 = new Terrorist("Omar Fadi", 4, true, new List<string> { "AK-47" });
            listTerrorist.Add(person28);
            Terrorist person29 = new Terrorist("Khaled Omar", 3, true, new List<string> { "Knife", "RPG" });
            listTerrorist.Add(person29);
            Terrorist person30 = new Terrorist("Khaled Khaled", 5, true, new List<string> { "M16" });
            listTerrorist.Add(person30);
            Terrorist person31 = new Terrorist("Ali Ahmad", 4, true, new List<string> { "RPG" });
            listTerrorist.Add(person31);
            Terrorist person32 = new Terrorist("Nabil Yasir", 2, true, new List<string> { "Explosives", "Handgun", "Knife" });
            listTerrorist.Add(person32);
            Terrorist person33 = new Terrorist("Fadi Khaled", 5, true, new List<string> { "Knife", "Handgun", "Explosives" });
            listTerrorist.Add(person33);
            Terrorist person34 = new Terrorist("Khaled Khaled", 2, true, new List<string> { "Handgun", "Knife" });
            listTerrorist.Add(person34);
            Terrorist person35 = new Terrorist("Ali Ahmad", 1, true, new List<string> { "Knife" });
            listTerrorist.Add(person35);
            Terrorist person36 = new Terrorist("Hassan Ahmad", 3, true, new List<string> { "RPG", "AK-47" });
            listTerrorist.Add(person36);


            //Console.WriteLine(hamas.CurrentCommander +"   " + hamas.ListTerrorist[0].Name);


        }




    }
}
