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
    public Spawn_Enemies EnemyManager;
    //public List<Enemy> TargetList = new List<Enemy>();
    public List<GameObject> TargetList = new List<GameObject>();
    public Vector3 towerPosition;
    public Projectile currProjectile;
    private Projectile tempProjectile;
    private bool enemyManagerExists = false;
    private float interpolationValue = 0f;
    private bool shot;

    void Start()
    {
        towerPosition = new Vector3(xCoordinate, yCoordinate, 0f);
        shot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyManagerExists)
        {
            if (EnemyManager.enemyList.Count > 0)
            {
                
                FindEnemy();
                checkTargets();
                Fire();
               
            }
        }
        else {
            EnemyManager = GameObject.FindWithTag("EnemyManager").GetComponent<Spawn_Enemies>();
            print(enemyManagerExists);
            if (EnemyManager != null) {
                enemyManagerExists = true;
            }
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

    public void Fire() {
        if (!shot) {
            if (TargetList.Count > 0) {
                tempProjectile = Instantiate<Projectile>(currProjectile, new Vector3(towerPosition.x, towerPosition.y, 0), Quaternion.identity);
                
                tempProjectile.InstantiateProjectile(TargetList, this);
                shot = true;
                //tempProjectile.HitTarget();
                tempProjectile.CalculateFinalLocation();
                tempProjectile.HitTarget();

            }
        }

       

    }

    public void UpdateShot() {
        shot = false;
    }
}
