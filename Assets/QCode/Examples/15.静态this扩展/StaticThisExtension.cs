﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QCode
{
    public static class StaticThisExtension
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("QCode/Examples/15.静态this扩展", false, 15)]
        static void MenuClicked()
        {
            new object().Test();
            "string".Test();
        }
#endif
        // Use this for initialization
        static void Test(this object selfObj)
        {
            Debug.Log(selfObj);
        }
    }
}