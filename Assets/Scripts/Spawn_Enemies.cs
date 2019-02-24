using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemies : MonoBehaviour
{
    // Start is called before the first frame update
    private float enemyTimer = 0f;
    public Enemy Enemy;
    public Enemy Enemy2;
    public int numWalkEnemies;
    public int numShieldEnemies;
    private Enemy Temp;
    public float spawnCoordinate_x;
    public float spawnCoordinate_y;
    public float enemySpawnTimer;
    private int enemyCount1 = 0;
    private int enemyCount2 = 0;
    public List<Enemy> enemyList = new List<Enemy>();


    public void Update() {
        if (enemyCount1 < numWalkEnemies) {

         if (enemyTimer > enemySpawnTimer) {
                SpawnEnemies(Enemy);
                enemyCount1++;
                enemyTimer = 0f;
          }
        }
        else if (enemyCount1 >= numWalkEnemies) {
            if (enemyCount2 < numShieldEnemies) {
                if (enemyTimer > enemySpawnTimer)
                {
                    SpawnEnemies(Enemy2);
                    enemyCount2++;
                    enemyTimer = 0f;
                }
            }
        }
        enemyTimer += Time.deltaTime;
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
    public void SpawnEnemies(Enemy EnemyToSpawn) {
        enemyTimer = 0f;
            while (enemyTimer < enemySpawnTimer)
            {
                enemyTimer += Time.deltaTime;
                print(enemyTimer);
            }
            Temp = Instantiate(EnemyToSpawn, new Vector3(spawnCoordinate_x, spawnCoordinate_y, 0), Quaternion.identity);
            enemyList.Add(Temp);
      


        
    }
}
