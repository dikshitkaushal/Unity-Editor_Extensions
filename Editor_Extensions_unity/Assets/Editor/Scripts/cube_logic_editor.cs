using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Cube_Logic))]
public class cube_logic_editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Cube_Logic cube = (Cube_Logic)target;
        GUILayout.Label("Press button to genereate random color");
        if(GUILayout.Button("Generate Color"))
        {
            if(cube)
            {
                cube.GenerateColor();
            }
        }
    }
}
