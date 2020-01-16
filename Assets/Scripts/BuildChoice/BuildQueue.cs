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
    public class BuildQueue<T>
    {
        private BuildQueueView _buildQueueView;
        private readonly Queue<IUnit> _unitQueue = new Queue<IUnit>();

        public BuildQueue(BuildQueueView buildQueueView)
        {
            _buildQueueView = new BuildQueueView().CreateBuildQueueView(buildQueueView);
        }

        public void Enqueue(IUnit t, float buildtime)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += (sender, args) => OnTimedEvent(t, aTimer, sender, args);
            aTimer.Interval = buildtime * 1000;
            aTimer.Enabled = true;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            UnityEngine.Debug.Log(stopWatch.ElapsedMilliseconds);
            if (stopWatch.ElapsedMilliseconds >= buildtime*1000)
            {
                UnityEngine.Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                _unitQueue.Enqueue(t);
                stopWatch.Stop();
            }
            _buildQueueView.CreateUnitQueueView(t,ref stopWatch);
        }

        private void OnTimedEvent(IUnit t, Stopwatch b, sender, args)
        {
            _unitQueue.Enqueue(t);
        }
    }
}
