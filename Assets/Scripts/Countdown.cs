using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Countdown : MonoBehaviour
{

    public float timeLeft = 3f;

    public TMP_Text timerText;

    public GameObject textBox;

    // Update is called once per frame
    void Update()
    {
            if(timeLeft > 0)
            {
                timeLeft -= Time.deltaTime * 2.5f;
                timerText.text = (timeLeft).ToString("0");
            }

            if (timeLeft <= 0)
            {
                textBox.SetActive(false);
            }
        
    }
}
