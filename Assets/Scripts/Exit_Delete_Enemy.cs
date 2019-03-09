using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;


public class Exit_Delete_Enemy : MonoBehaviour
{
    private TextMeshProUGUI HealthText;
    private Player player;
    private Spawn_Enemies EnemyManager;
    int toDel;
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
        EnemyManager = GameObject.FindWithTag("EnemyManager").GetComponent<Spawn_Enemies>();
        if (col.gameObject.CompareTag("Enemy")) {
            player.health = player.health - 1;
            HealthText.text = "" + player.health;
            if (player.health <= 0) {
                //SceneManager.LoadScene(4);
            }
            toDel = SearchEnemyList(col.gameObject);
            EnemyManager.enemyList.Remove(EnemyManager.enemyList[toDel]);
            Destroy(col.gameObject);
        }
    }

    public int SearchEnemyList(GameObject searchFor) {
        print("col: " + searchFor);
        for (int i = 0; i < EnemyManager.enemyList.Count; i++) {
            print("enemy " + EnemyManager.enemyList[i]);
            if (searchFor == EnemyManager.enemyList[i]) {
                return i;
            }
        }
        return -1;
    }
}
