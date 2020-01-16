using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace UnitSystem
{
    public class UnitQueueView : MonoBehaviour
    {
        [SerializeField] private UnitQueueView _prefUnitQueueView;
        [SerializeField] private Text _name;
        [SerializeField] private Button _unitButton;
        private IUnit _unit;
        private float _transitionTime = 0;
        public float TransitionTime
        {
            get
            {
                return _transitionTime;
            }
            set
            {
                _transitionTime = value;              
            }
        }
        public IUnit Unit
        {
            set
            {
                _unit = value;
                _name.text = value.Name;
            }
        }

        void Update()
        {
            TransitionFill();
        }

        public void TransitionFill()
        {
            Debug.Log(_transitionTime);
            Button lol = _unitButton;
           // _unitButton.GetComponent<Image>().fillAmount = _transitionTime;
        }

   

        public UnitQueueView CreateUnitQueueView(Transform parent)
        {
            UnitQueueView unitQueueView = Instantiate(_prefUnitQueueView, parent.transform);
            _unitButton = unitQueueView.GetComponent<Button>();
            return unitQueueView;
        }
    }
}
