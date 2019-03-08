using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;


public class Exit_Delete_Enemy : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        HealthText = GameObject.Find("Health Number").GetComponent<TextMeshProUGUI>();
        player = GameObject.FindWithTag("player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col) {
       
        if (col.gameObject.CompareTag("Enemy")) {
            player.health = player.health - 1;
            HealthText.text = "" + player.health;
            if (player.health <= 0) {
                //SceneManager.LoadScene(4);
            }
            Destroy(col.gameObject);
        }
    }
}
