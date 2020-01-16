using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSystem
{
    class PawnUnit : IUnit
    {
        private string _name = "Pawn";
        private float _buildTime = 5;
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
            return BuildConditions.DependentOnUnits(6, 6);
        }

        public IUnit Spawn()
        {
           return new PawnUnit();
        }
    }
}
