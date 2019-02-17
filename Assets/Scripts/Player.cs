using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    // Start is called before the first frame update
    public int Money;
    public int Health;
    public int Score;

    void Start()
    {
        Money = 100;
        Health = 10;
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
