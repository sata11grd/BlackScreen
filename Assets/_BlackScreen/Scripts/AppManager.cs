using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlackScreen
{
    public class AppManager : MonoBehaviour
    {
        private static void Quit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
#endif
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Quit();
            }
        }
    }
}