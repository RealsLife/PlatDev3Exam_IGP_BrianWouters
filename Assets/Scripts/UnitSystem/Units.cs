using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections;


namespace UnitSystem
{
    class Units
    {
        public Dictionary<int, IUnit> UnitsCatalogue => _units;
        Dictionary<int, IUnit> _units = new Dictionary<int, IUnit>();
        void CreateUnits()
        {
            _units.Add(1, new KingUnit());
            _units.Add(1, new QueenUnit());
            _units.Add(3, new PawnUnit());
        }
      
     
    }
}
