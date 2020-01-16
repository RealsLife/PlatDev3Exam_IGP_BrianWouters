using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using UnitSystem;
using UnityEngine;

namespace BuildQueueSystem
{
    public class BuildQueueView : MonoBehaviour
    {
        [SerializeField] private UnitQueueView _unitViewPrefab;

        public BuildQueueView CreateBuildQueueView(BuildQueueView buildQueuePrefab)
        {
            return Instantiate(buildQueuePrefab, Application.Instance.transform);
        }

        public UnitQueueView CreateUnitQueueView(IUnit unit,ref Stopwatch timer)
        {
            UnitQueueView unitQueueView = _unitViewPrefab.CreateUnitQueueView(this.transform);
            unitQueueView.Unit = unit;
            unitQueueView.TransitionTime = (float)timer.ElapsedMilliseconds;
            return unitQueueView;
        }
    }
}
