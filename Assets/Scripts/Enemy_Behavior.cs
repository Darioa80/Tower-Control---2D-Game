using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform Enemy;
    public float enemySpeed;
    float enemyTimer = 0f;
    private float horizontalSpeed = 0f;
    private float verticalSpeed = 0f;
    void Start()
    {
        verticalSpeed = enemySpeed * Time.deltaTime;
        this.transform.Translate(new Vector3(horizontalSpeed, -verticalSpeed, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(horizontalSpeed, -verticalSpeed, 0f));
    }

    void FixedUpdate() {
        

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (verticalSpeed < 0f)
        {
            horizontalSpeed = verticalSpeed;
            verticalSpeed = 0f;
        }
        else if (horizontalSpeed > 0f) {
            verticalSpeed = horizontalSpeed;
            horizontalSpeed = 0f;
        }
    }

}
