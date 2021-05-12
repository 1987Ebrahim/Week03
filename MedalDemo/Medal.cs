using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedalDemo
{
    class Medal
    {
        public string Name { get; }
        public string TheEvent { get; }
        public string Color { get; }
        public int Year { get; }
        public bool IsRecord { get; }

        public Medal(string name, string theEvent, string color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;
        }
        public override string ToString()
        {
            return $"{Year} - {TheEvent}{(IsRecord ? "(R) " : " ")} {Name}({Color})";
        }
    }
}
