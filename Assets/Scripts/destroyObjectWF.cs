﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObjectWF : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "breakableObject")
        {
            Destroy(col.gameObject);
        }
    }
}
    
