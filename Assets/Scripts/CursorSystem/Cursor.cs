using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CursorSystem
{
    class Cursor
    {
        public Vector3 CurrentPos
        {
            get
            {
                return _currentPos;
            }
            set => _currentPos = value;
        }
        private Vector3 _currentPos;

        Cursor(Vector3 startPos)
        {
            _currentPos = startPos;
        }

        void CursorCheckBoundaries()
        {

        }

        void CursorMove()
        {

        }
    }
}
