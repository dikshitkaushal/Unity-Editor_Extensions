﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Logic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GenerateColor();
    }
    public void GenerateColor()
    { 
        MeshRenderer mesh_renderer = GetComponent<MeshRenderer>();
        if(mesh_renderer)
        {
            Color color = Random.ColorHSV();
            mesh_renderer.sharedMaterial.color = color;
        }
    }
}
