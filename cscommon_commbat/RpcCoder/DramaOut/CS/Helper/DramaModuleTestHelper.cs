﻿#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using GenPB;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;





public class DramaModuleTestHelper : MonoBehaviour
{




}

[CustomEditor(typeof(DramaModuleTestHelper))]
public class DramaModuleTester : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        


    }

}
#endif