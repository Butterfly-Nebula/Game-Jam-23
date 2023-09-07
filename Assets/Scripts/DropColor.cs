using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropColor : MonoBehaviour
{
    public GameObject Drop;
    public Renderer dropMat;
    private ColorChange colorChange;
    
    // Start is called before the first frame update
    void Start()
    {
        dropMat = Drop.GetComponent<Renderer>();
        //colorChange = GetComponent<ColorChange>();
        colorChange = GameObject.FindObjectOfType<ColorChange>();
    }

    // Update is called once per frame
    void Update()
    {
        dropMat.material.color = colorChange.colorToTurnTo;
    }
}
