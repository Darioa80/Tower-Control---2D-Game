using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform Enemy;
    public float enemySpeed;
    float enemyTimer = 0f;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0f, -enemySpeed * Time.deltaTime , 0f));
      
    }

    void FixedUpdate() {
        

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
    }

}
