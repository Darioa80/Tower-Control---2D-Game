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
    public AudioClip Music;
    public AudioSource MusicSource;
    public TextMeshProUGUI TextBox;
    private bool Clicked = false;


    public void Start() {
        MusicSource.clip = Music;
    }
    public void InitiateGameObject() {
        if (!Clicked)
        {
            Instantiate(EnemySpawner, new Vector3(10, 10, 0), Quaternion.identity);
            Instantiate(MusicSource);
            TextBox.text = "Hover over a tower icon to learn its details. \n\nClick on the tower to purchase it.";
            MusicSource.Play();
            Clicked = true;
        }
    }
}
