﻿using System;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using HelloWorld.Interfaces;
using System.Threading;

namespace ActorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IHelloWorld actor = ActorProxy.Create<IHelloWorld>(ActorId.CreateRandom(), new Uri("fabric:/MyApplication/HelloWorldActorService"));
            Task<string> retval = actor.GetHelloWorldAsync();
            Console.Write(retval.Result);
            Console.WriteLine("Please Enter Your name");
            string name = Console.ReadLine();
            Console.ReadLine();
        }
    }
}