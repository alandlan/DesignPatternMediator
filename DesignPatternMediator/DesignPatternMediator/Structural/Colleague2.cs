﻿using System;

namespace DesignPatternMediator.Structural
{
    public class Colleague2 : Colleague
    {
        //public Colleague2(Mediator mediator) : base(mediator)
        //{
        //}

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Collegue2 receives notification message: {message}");
        }
    }
}