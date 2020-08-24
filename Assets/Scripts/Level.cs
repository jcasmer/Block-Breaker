﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
   [SerializeField] int breakableBlocks;

    SceneLoader sceneLoader;

  
    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
