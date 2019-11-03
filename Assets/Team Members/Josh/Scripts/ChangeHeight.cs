﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHeight : MonoBehaviour
{
    public GameObject table;
    public float minHeight = 0f;
    public float maxHeight = 0.8f;

    public void IncreaseHeight()
    {
        Vector3 pos = table.transform.position;
        if (pos.y < maxHeight)
        {
            pos.y += 0.1f;
        }
        table.transform.position = pos;
    }

    public void DecreaseHeight()
    {
        Vector3 pos = table.transform.position;
        if(pos.y > minHeight)
        {
            pos.y -= 0.1f;
        }       
        table.transform.position = pos;
    }
}
