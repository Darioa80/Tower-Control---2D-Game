using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Map : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Enemy;
    public Transform Path_Tile;
    float enemyTimer = 0f;
    public float mapWidth;
    public float mapHeight;


    void Start()
    {
        CreateMap();
        //Instantiate(Enemy, new Vector3(-5.5f, 4.5f, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyTimer > 0.75f)
        {
            Instantiate(Enemy, new Vector3(-4.5f, 4.5f, 0), Quaternion.identity);
            enemyTimer = 0f;
        }
        enemyTimer += Time.deltaTime;
    }

    void FixedUpdate()
    {


    }

    void CreateMap() {
        for (float indexWidth = 0f; indexWidth < mapWidth; indexWidth++)
        {
            for (float indexHeight = 0f; indexHeight < mapHeight; indexHeight++)
            {
                if (indexWidth != -4.5f && indexHeight > 0f)
                {
                    Instantiate(Path_Tile, new Vector3(indexWidth - 6.5f, indexHeight - 4.5f, 0), Quaternion.identity);
                }
            }
        }

    }
}
