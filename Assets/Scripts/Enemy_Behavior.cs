using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Enemy;
    float enemyTimer = 0f;
    void Start()
    {
        Instantiate(Enemy, new Vector3(-5.5f, 4.5f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyTimer > 1f) {
            Instantiate(Enemy, new Vector3(-5.5f, 4.5f, 0), Quaternion.identity);
            enemyTimer = 0f;
        }
        enemyTimer += Time.deltaTime;
    }

    void FixedUpdate() {
        

    }
}
