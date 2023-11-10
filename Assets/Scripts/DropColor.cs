using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropColor : MonoBehaviour
{
    public GameObject Drop;
    private Renderer dropMat;
    private ColorChange colorChange;
    
    void Start()
    {
        dropMat = Drop.GetComponent<Renderer>();
        //colorChange = GetComponent<ColorChange>();
        colorChange = GameObject.FindObjectOfType<ColorChange>();
        //dropMat.material.color = colorChange.colorToTurnTo;
    }

    void Update()
    {
        dropMat.material.color = colorChange.colorToTurnTo;
    }
}
