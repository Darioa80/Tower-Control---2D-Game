using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    public float fireRate;
    public float xCoordinate;
    public float yCoordinate;
    public float range;
    public int damage;
    public string name;
    public int cost;
    public int Level;
    public Projectile currPorjectile;
    public Spawn_Enemies EnemyManager;
    //public List<Enemy> TargetList = new List<Enemy>();
    public List<GameObject> TargetList = new List<GameObject>();
    private Vector3 towerPosition;
    void Start()
    {
        towerPosition = new Vector3(xCoordinate, yCoordinate, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyManager.enemyList.Count > 0) {
            FindEnemy();
            checkTargets();
        }
    }

    public void FindEnemy() {


        for(int i = 0; i < EnemyManager.enemyList.Count; i++) {
            if (!TargetList.Contains(EnemyManager.enemyList[i])) {
                if (Vector3.SqrMagnitude(EnemyManager.enemyList[i].transform.position - towerPosition) < 4) {
                    TargetList.Add(EnemyManager.enemyList[i]);
                }
            

            }

        }

    }

    public void checkTargets()
    {
        for (int i = 0; i < TargetList.Count; i++)
        {
            if (Vector3.SqrMagnitude(TargetList[i].transform.position - towerPosition) > 4)
            {
                TargetList.Remove(TargetList[i]);
            }
        }
    }
}
