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
    public Transform EnemyHold;
    private List<Enemy> enemyList = new List<Enemy>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindEnemy();
    }

    public void FindEnemy() {

       // for (int i = 0; i < EnemyHold.)
    }
}
