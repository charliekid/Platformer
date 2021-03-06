﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelStats : MonoBehaviour
{
    [SerializeField] public Text scoreText;

    [SerializeField] public Text levelText;

    [SerializeField] public Text  timeText;

    [SerializeField] public Text coinText;
    
    private float currentTime = 400;

    public float score = 0;

    public float coins = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        levelText.text = "1-1";
        scoreText.text = String.Format("{0:000000}", score);
        coinText.text = String.Format("x{0:00}", coins);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            timeText.text = Math.Floor(currentTime) + ""; 
        }
        
        // Raycasting Physics stuff
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Destroy(hit.collider.gameObject);
                // if we hit a question box give us 100 points
                if (hit.collider.gameObject.name.Equals("Question(Clone)"))
                {
                    //score += 100;
                    //scoreText.text = String.Format("{0:000000}", score);

                    coins += 1;
                    coinText.text = String.Format("x{0:00}", coins);
                }
            }
            
        }
    }
    
    
}
