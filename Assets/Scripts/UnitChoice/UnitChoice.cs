using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitSystem;
using UnityEngine.EventSystems;

namespace UnitChoiceSystem
{
    class UnitChoice
    {     
        public int CurrentSelectedUnit
        {
            get
            {
                return _currentSelectedUnit;
            }
            set
            {
                if (value < 0)
                {                 
                    _currentSelectedUnit = 0;
                }
                else if (value > UnitsCatalogue.Count-1)
                {
                    _currentSelectedUnit = UnitsCatalogue.Count-1;
                }
                else
                {
                    _currentSelectedUnit = value;
                }
                EventSystem.current.SetSelectedGameObject(_unitViews[_currentSelectedUnit].gameObject);
                ChangedCurrentSelection?.Invoke(this, EventArgs.Empty);
            }
        }

        public Dictionary<int, IUnit> UnitsCatalogue => _units;
        public EventHandler ChangedCurrentSelection;

        private Dictionary<int, IUnit> _units = new Dictionary<int, IUnit>();
        private int _currentSelectedUnit;
        private UnitChoiceView _unitChoiceView;
        private UnitView[] _unitViews;
        public UnitChoice(UnitChoiceView unitChoiceViewPrefab)
        { 
            InitiliazUnits();
            _unitChoiceView = new UnitChoiceView().CreateUnitChoiceView(unitChoiceViewPrefab);
            CreateUnitViews();
            EventSystem.current.SetSelectedGameObject(_unitViews[_currentSelectedUnit].gameObject);
        }

        private void InitiliazUnits()
        {
            _units.Add(1, new KingUnit());
            _units.Add(2, new QueenUnit());
            _units.Add(3, new PawnUnit());
        }

        private void CreateUnitViews()
        {
            _unitViews = new UnitView[_units.Count];
            foreach (var unit in _units)
            {
                UnitView unitView = _unitChoiceView.CreateUnitView(unit.Value);
                _unitViews[unit.Key - 1] = unitView;
            }
        }

        public void UpdateSelection(int direction)
        {
            CurrentSelectedUnit += direction;        
        }

        public IUnit Build()
        {
            return UnitsCatalogue[_currentSelectedUnit+1].Spawn();
        }
    }
}
