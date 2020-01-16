using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSystem
{
    class QueenUnit : IUnit
    {
        private string _name = "Queen";
        private float _buildTime = 10;
        private bool _buildable;
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public float BuildTime
        {
            get
            {
                return _buildTime;
            }
        }
        public bool Buildable
        {
            get
            {
                return _buildable = Condition();
            }
        }
        public bool Condition()
        {
            return false;
        }

        public IUnit Spawn()
        {
           return new QueenUnit();
        }
    }
}
