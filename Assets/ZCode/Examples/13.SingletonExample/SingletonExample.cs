﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZCode
{
    public class SingletonExample : Singleton<SingletonExample>
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("ZCode/Examples/13.SingletonExample", false, 13)]
        static void MenuClicked()
        {
            var initInstance = SingletonExample.Instance;
            initInstance = SingletonExample.Instance;
        }

#endif
       private SingletonExample()
        {
            Debug.Log("SingletonExample ctor");
        }
    }
}