using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSystem
{
    public interface IUnit
    {
        string Name { get; }
        float BuildTime { get; }
        bool Buildable{get;}

        bool Condition();

        IUnit Spawn();
    }
}
