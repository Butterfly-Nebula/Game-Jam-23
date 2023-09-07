using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropColor2 : MonoBehaviour
{
    public GameObject Drop2;
    public Renderer dropMat;
    private ColorChange2 colorChange2;
    
    // Start is called before the first frame update
    void Start()
    {
        dropMat = Drop2.GetComponent<Renderer>();
        //colorChange = GetComponent<ColorChange>();
        colorChange2 = GameObject.FindObjectOfType<ColorChange2>();
        dropMat.material.color = colorChange2.colorToTurnTo;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
