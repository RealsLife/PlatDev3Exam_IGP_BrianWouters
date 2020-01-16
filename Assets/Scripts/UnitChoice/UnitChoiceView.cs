using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitSystem;
using UnityEngine;

namespace UnitChoiceSystem
{
    public class UnitChoiceView : MonoBehaviour
    { 
        [SerializeField] private UnitView _unitViewPrefab;

        public UnitChoiceView CreateUnitChoiceView(UnitChoiceView unitChoicePrefab)
        {
            return Instantiate(unitChoicePrefab,Application.Instance.transform);
        }

        public UnitView CreateUnitView(IUnit unit)
        {
            UnitView unitView = _unitViewPrefab.CreateUnitView(this.transform);
            unitView.Unit = unit;
            return unitView;
        }

        //public void UpdateUnitChoiceView(int currentSelected,)
        //{

        //}


    }
}
