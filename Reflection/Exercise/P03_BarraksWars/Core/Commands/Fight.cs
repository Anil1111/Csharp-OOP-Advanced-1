﻿namespace _03BarracksFactory.Core.Commands
{
    using Contracts;
    using System;

    public class Fight : Command, IExecutable
    {
        public Fight(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return "";
        }
    }
}
