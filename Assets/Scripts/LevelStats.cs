using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelStats : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    [SerializeField] private Text levelText;

    [SerializeField] private Text  timeText;

    private float initialTime = 400;

    private float currentTime = 400;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            timeText.text = Math.Floor(currentTime) + ""; 
        }
        
    }
}
