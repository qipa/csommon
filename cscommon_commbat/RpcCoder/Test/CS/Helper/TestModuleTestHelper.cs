﻿#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using GenPB;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;





public class TestModuleTestHelper : MonoBehaviour
{




}

[CustomEditor(typeof(TestModuleTestHelper))]
public class TestModuleTester : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        


    }

}
#endif