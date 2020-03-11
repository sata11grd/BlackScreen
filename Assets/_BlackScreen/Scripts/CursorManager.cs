using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlackScreen
{
    public class CursorManager : MonoBehaviour
    {
        private void Awake()
        {
            Cursor.visible = false;
        }
    }
}