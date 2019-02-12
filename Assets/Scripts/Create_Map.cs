using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Map : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform Enemy;
    public GameObject Path_Tile;
    public GameObject Non_Path_Tile;
    private GameObject Temp;

    public float mapWidth;
    public float mapHeight;
    private int count;

    private float last_y_Position = 0f;
    private float last_x_Position = 0f;

    void Start()
    {
        CreateMap();
        //Instantiate(Enemy, new Vector3(-5.5f, 4.5f, 0), Quaternion.identity);
      
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void FixedUpdate()
    {


    }

    void CreateMap()
    {
        for (int width_index = 0; width_index < mapWidth; width_index++) {
            for (int height_index = 0; height_index < mapHeight; height_index++) {
                Instantiate(Non_Path_Tile, new Vector3(0.5f + width_index,-0.5f - height_index, 0f), Quaternion.identity);
             
            }

        }
        AddPath();
    }

    void AddPath() {
        for (count = 0; count < 4; count++) {
            Instantiate(Path_Tile, new Vector3(1.5f, -0.5f - count, 0f), Quaternion.identity);
            
        }
        last_y_Position = -0.5f - count + 1;
        last_x_Position = 1.5f;
        for (count = 1; count < 7; count++)
        {
            Instantiate(Path_Tile, new Vector3(last_x_Position + count, last_y_Position, 0f), Quaternion.identity);
            
        }
        last_x_Position = last_x_Position + count;
        for (count = 0; count < 3; count++)
        {
            Instantiate(Path_Tile, new Vector3(last_x_Position, last_y_Position + count, 0f), Quaternion.identity);
        }
        last_y_Position = last_y_Position + count -1;
        for (count = 1; count < 5; count++)
        {
            Instantiate(Path_Tile, new Vector3(last_x_Position + count, last_y_Position, 0f), Quaternion.identity);
        }
        last_x_Position = last_x_Position + count - 1;
        for (count = 1; count < 6; count++)
        {
            Instantiate(Path_Tile, new Vector3(last_x_Position, last_y_Position - count, 0f), Quaternion.identity);
        }
        last_y_Position = last_y_Position - count + 1;
        for (count = 1; count < 7; count++)
        {
            Instantiate(Path_Tile, new Vector3(last_x_Position-count, last_y_Position, 0f), Quaternion.identity);
        }
        last_x_Position = last_x_Position - count + 1;
        Instantiate(Path_Tile, new Vector3(last_x_Position, last_y_Position-1, 0f), Quaternion.identity);
    }
}
