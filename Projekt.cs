using System;

namespace CCPTimer
{
    internal class Projekt
    {
        private readonly string name;
        public Projekt(string name)
        {
            this.name = name;
        }

        internal string GetName()
        {
            return name;
        }
    }
}