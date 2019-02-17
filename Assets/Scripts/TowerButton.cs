using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Tilemaps;
using TMPro;

public class TowerButton : MonoBehaviour
{
    // Start is called before the first frame update
    public string tag;
    public Tower currTower;
    public Tilemap towerMap;
    public TextMeshProUGUI TextBox;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click() {

        updateText();
        CreateTower();
        //Instantiate()
    }

    public void CreateTower() {

            

    }
    public void updateText() {
        TextBox.text = "You have selected the " + currTower.Name + " Tower. Click on any area of dirt to place the tower.";


    }
}
