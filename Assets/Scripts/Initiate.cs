using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class Initiate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject EnemySpawner;

    public TextMeshProUGUI TextBox;
    public bool Clicked = false;


    public void Start() {
  
    }
    public void InitiateGameObject() {
 
            Instantiate(EnemySpawner, new Vector3(10, 10, 0), Quaternion.identity);

            TextBox.text = "Hover over a tower icon to learn its details. \nClick on the tower to purchase it. \n\nClick on the music icon to turn music on or off.";
            Clicked = true;
            EnemySpawner.GetComponent<Spawn_Enemies>().Clicked = true;
        
    }
}
