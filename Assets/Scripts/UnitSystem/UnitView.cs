using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UnitSystem
{
    public class UnitView : MonoBehaviour
    {
        [SerializeField]private UnitView _prefUnitView;
        [SerializeField]private Text _name;
        private Button _unitButton;
        private IUnit _unit;

        public IUnit Unit
        {
            set
            {
                _unit = value;
                _name.text = value.Name;
            }
        }

        UnitView(string name)
        {
            _unitButton = this.GetComponent<Button>();
        }

       public UnitView CreateUnitView(Transform parent)
        {
            UnitView unitView = Instantiate(_prefUnitView, parent.transform);
            return unitView;
        }
    }
}
