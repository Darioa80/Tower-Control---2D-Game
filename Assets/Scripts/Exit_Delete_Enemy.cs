﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Delete_Enemy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onTriggerEnter2D(Collider2D col) {
        print("tag: " + col.gameObject.tag);
        if (col.gameObject.CompareTag("Enemy")) {
            Destroy(col.gameObject);
        }
    }
}
