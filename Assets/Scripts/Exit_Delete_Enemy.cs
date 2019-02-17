using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Delete_Enemy : MonoBehaviour
{
    private Enemy En;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onTriggerEnter2D(Collider2D col) {
        print("tag: " + col.tag);
        if (col.CompareTag("Enemy")) {
            Destroy(col.gameObject);
        }
    }
}
