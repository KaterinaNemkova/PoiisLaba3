﻿namespace Poiis3
{
    public abstract class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            Name = name;
        }
    }
}