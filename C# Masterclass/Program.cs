﻿using System;
namespace HelloWorld

{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Patrick";
            string friend1 = "Noela";
            string friend2 = "Raysun";

            GreetFriend(friend);
            GreetFriend(friend1);
            GreetFriend(friend2);
            Console.Read();
        }


        public static void GreetFriend(string friendName)
        {

            Console.WriteLine("Hi" + friendName + ", my friend");
        }
    }

}
