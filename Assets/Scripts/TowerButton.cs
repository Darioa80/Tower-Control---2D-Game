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
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI ScoreText;
    public Player player;
    private bool towerClicked;

    void Start()
    {
        towerClicked = false;
       // UpdateToOriginalText();
        HealthText.text = "" + player.health;
        MoneyText.text = "" + player.money;
        ScoreText.text = "" + player.score;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (towerClicked) {
            CreateTower();
            

        }
    }

    public void Click() {
        if (currTower.cost <=  player.money) {
            if (currTower.name == "Health")
            {
                print("clicked on health");
                towerClicked = false;
                UpdatePlayerInfo();
            }
            else
            {
                TextBox.text = "You have selected the " + currTower.name + " Tower. Click on any area of dirt to place the tower.";
                UpdatePlayerInfo();
                towerClicked = true;
                //CreateTower();
                //Instantiate()
            }
        }
    }

    public void CreateTower() {
        TextBox.text = "You have selected the " + currTower.name + " Tower. Click on any area of dirt to place the tower.";
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 mouseLoc = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseLoc.z = 0f;
            Tower tempTower = Instantiate(currTower, mouseLoc, Quaternion.identity);
            tempTower.xCoordinate = mouseLoc.x;
            tempTower.yCoordinate = mouseLoc.y;
            //towerMap.SetTile(new Vector3Int((int)Mathf.Round(tempTower.xCoordinate), (int)Mathf.Round(tempTower.yCoordinate), 0), tempTower); 
            towerClicked = false;
            UpdateToOriginalText();
        }


    }
    public void UpdateToOriginalText() {
        TextBox.text = "Hover over a tower icon to learn its details. \nClick on the tower to purchase it. \n\nClick on the music icon to turn music on or off.";
        //TextBox.text = "Hover over a tower icon to learn its details. \n\nClick on the tower to purchase it.";
    }

    public void onHover() {
        print("Tower Name: " + currTower.name);
        if (currTower.name == "Health")
        {
            TextBox.text = "Purchase Health. This option gives you one health point for the following cost:" +
                "\nCost: " + currTower.cost
                ;
        }
        else
        {
            TextBox.text = "This is the " + currTower.name + " Tower. \n" +
                "Fire Rate: " + currTower.fireRate +
                "\nRange: " + currTower.range +
                "\nDamage: " + currTower.damage +
                "\nCost: " + currTower.cost
                ;
        }
    }

    public void UpdatePlayerInfo() {
        print("Update Player Info - Tower: " + currTower.name);
        if (currTower.name == "Health")
        {
            player.health++;
            player.money = player.money - currTower.cost;
            HealthText.text = "" + player.health;
            MoneyText.text = "" + player.money;
        }
        else {
            player.money = player.money - currTower.cost;
            MoneyText.text = "" + player.money;
        }
    }
}
