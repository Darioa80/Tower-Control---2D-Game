using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemies : MonoBehaviour
{
    // Start is called before the first frame update
    private float enemyTimer = 0f;
    public Transform Enemy;
    public GameObject Parent;
    public int numEnemies;
    private Transform Temp;
    public float spawnCoordinate_x;
    public float spawnCoordinate_y;
    private int enemyCount = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount < numEnemies)
        {
            if (enemyTimer > 2f)
            {
                Temp = Instantiate(Enemy, new Vector3(spawnCoordinate_x, spawnCoordinate_y, 0), Quaternion.identity);
                Temp.parent = Parent.transform;
                enemyCount++;
                enemyTimer = 0f;
            }
            enemyTimer += Time.deltaTime;
        }
    }
}
