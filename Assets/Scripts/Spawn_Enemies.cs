using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemies : MonoBehaviour
{
    // Start is called before the first frame update
    private float enemyTimer = 0f;
    // public Enemy Enemy;
    // public Enemy Enemy2;
    public GameObject Enemy;
    public GameObject Enemy2;

    public int numWalkEnemies;
    public int numShieldEnemies;
    private GameObject Temp;
    
    public float spawnCoordinate_x;
    public float spawnCoordinate_y;
    public float enemySpawnTimer;

    public bool Clicked;
    private int enemyCount1 = 0;
    private int enemyCount2 = 0;
    // public List<Enemy> enemyList = new List<Enemy>();
    public List<GameObject> enemyList = new List<GameObject>();

    public void Update() {
        if (Clicked)
        {
            if (enemyCount1 < numWalkEnemies)
            {

                if (enemyTimer > enemySpawnTimer)
                {
                    SpawnEnemies(Enemy);
                    enemyCount1++;
                    enemyTimer = 0f;
                }
            }
            else if (enemyCount1 >= numWalkEnemies)
            {
                if (enemyCount2 < numShieldEnemies)
                {
                    if (enemyTimer > enemySpawnTimer)
                    {
                        SpawnEnemies(Enemy2);
                        enemyCount2++;
                        enemyTimer = 0f;
                    }
                }
            }
            enemyTimer += Time.deltaTime;
            /*  for (int z = 0; z < enemyList.Count; z++)
              {
                  if (enemyList[z].GetComponent<Enemy>().health <= 0f) {
                      toDelete = enemyList[z];
                      enemyList.Remove(enemyList[z]);

                      Destroy(toDelete.gameObject);

                  }
              }*/
        }
    }




  /*  public void startSpawn() {
        if (numShieldEnemies > 0)
        {
            for (int i = 0; i < numShieldEnemies; i++) {
                SpawnEnemies(Enemy2);
            }
            
        }
        if (numWalkEnemies > 0)
        {
            for (int i = 0; i < numWalkEnemies; i++)
            {
                SpawnEnemies(Enemy);
            }
        }

    }*/
    public void SpawnEnemies(GameObject EnemyToSpawn) {
        enemyTimer = 0f;
            while (enemyTimer < enemySpawnTimer)
            {
                enemyTimer += Time.deltaTime;
               
            }
            Temp = Instantiate(EnemyToSpawn, new Vector3(spawnCoordinate_x, spawnCoordinate_y, 0), Quaternion.identity);
            enemyList.Add(Temp);
      


        
    }
}
