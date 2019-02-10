using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemies : MonoBehaviour
{
    // Start is called before the first frame update
    private float enemyTimer = 0f;
    public Transform Enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyTimer > 0.5f)
        {
            Instantiate(Enemy, new Vector3(-5.5f, 4.5f, 0), Quaternion.identity);
            enemyTimer = 0f;
        }
        enemyTimer += Time.deltaTime;
    }
}
