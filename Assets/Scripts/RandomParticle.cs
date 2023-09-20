using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomParticle : MonoBehaviour
{
    public GameObject Particle;
    private Renderer dropMat;
    public Color colorParticle;
    private ColorChange colorChange;
    
    // Start is called before the first frame update
    void Start()
    {
        dropMat = Particle.GetComponent<Renderer>();
        colorChange = GetComponent<ColorChange>();
        //colorChange.RandomColor();
        //dropMat.material.color = colorParticle;
       
    }

    // Update is called once per frame
    void Update()
    {
        colorChange.RandomColor();
        dropMat.material.color = colorParticle;
    }
}
