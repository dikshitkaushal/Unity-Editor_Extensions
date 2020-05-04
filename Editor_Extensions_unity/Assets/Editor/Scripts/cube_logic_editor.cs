using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Cube_Logic))]
public class cube_logic_editor : Editor
{
    Color m_color;
    float cubesize;
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
        m_color = EditorGUILayout.ColorField(m_color);
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("set color"))
        {
            if(cube)
            {
                cube.SetColor(m_color);
            }
        }
        if(GUILayout.Button("reset color"))
        {
            if(cube)
            {
                cube.SetColor(Color.white);
            }
        }
        GUILayout.EndHorizontal();
        cubesize = EditorGUILayout.Slider(cubesize, 0, 5);
        if(cube)
        {
            cube.setsize(cubesize);
        }
    }
}
