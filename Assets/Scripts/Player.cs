using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int money;
    public int health;
    public int score;

    void Start()
    {
        money = 100;
        health = 10;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
