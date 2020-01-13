using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorView : MonoBehaviour
{
    GameObject cursorPref;


    private void UpdateCursor(Vector3 _currentPos)
    {
        this.transform.position = _currentPos;
    }
}
