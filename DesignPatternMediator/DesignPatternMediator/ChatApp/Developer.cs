﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMediator.ChatApp
{
    public class Developer : TeamMember
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"{this.Name} ({nameof(Developer)}) has received");
            base.Receive(from, message);
        }
    }
}
