using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerDemo
{
    class Pet
    {
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public int Age { get; private set; }
        public string Description { get; private set; }
        public bool IsHouseTrained { get; private set; }

        public Pet(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
            Owner = "no one";
            IsHouseTrained = false;
        }

        public void SetOwner(string owner)
        {
            Owner = owner;
        }
        public void Train()
        {
            IsHouseTrained = true;
        }

        public override string ToString()
        {
            return $"Hi, My name is {Name}, I am {Age} years old, I am {Description}, My owner is {Owner} and I am {(IsHouseTrained ? "" : "Not ")}house trained";
        }
    }
}
