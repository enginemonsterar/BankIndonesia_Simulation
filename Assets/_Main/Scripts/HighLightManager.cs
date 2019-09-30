﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLightManager : MonoBehaviour
{
    // [SerializeField] private HighlightItem[] highlightItems;

    // Start is called before the first frame update
    void Start()
    {
        var highlightItems = (HighlightItem[]) FindObjectsOfType(typeof(HighlightItem));
        for (int i = 0; i < highlightItems.Length; i++)
        {
            Debug.Log(i + ": " + highlightItems[i].name);
            highlightItems[i].Lowting();            
        }   


        // highlightItems[14].Highting();
        // highlightItems[15].Highting();
        // highlightItems[16].Highting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}