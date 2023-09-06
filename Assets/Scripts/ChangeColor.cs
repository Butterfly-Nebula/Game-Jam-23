using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public SpriteRenderer head;

    public Color white;
    public Color black;
    public Color red;
    public Color yellow;
    public Color purple;

    public int whatColor = 1;

    void Start()
    {
    
        
    }

    void Update()
    {
        if(whatColor == 1)
        {
            head.color = white;

        }else if(whatColor == 2)
        {
            head.color = black;
        }else if(whatColor == 3)
        {
            head.color = red;
        }else if(whatColor == 4)
        {
            head.color = yellow;
        }else if(whatColor == 5)
        {
            head.color = purple;
        }
    }

    public void ChangeToWhite()
    {
        whatColor = 1;
    }
    public void ChangeToBlack()
    {
        whatColor = 2;
    }
    public void ChangeToRed()
    {
        whatColor = 3;
    }
    public void ChangeToYellow()
    {
        whatColor = 4;
    }
    public void ChangeToPurple()
    {
        whatColor = 5;
    }
}
