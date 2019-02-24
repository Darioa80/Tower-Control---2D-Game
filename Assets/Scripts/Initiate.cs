using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initiate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject EnemySpawner;

    public void InitiateGameObject() {
        Instantiate(EnemySpawner, new Vector3(10, 10, 0), Quaternion.identity);

    }
}
