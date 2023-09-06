using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorChange : MonoBehaviour
{   
    public GameObject Player;
    public DestroyEffect destroyEffect;
    private Renderer rend;
    public Renderer rendMat;
    public Color colorToTurnTo;
    void Start()
    {
        destroyEffect = Player.GetComponent<DestroyEffect>();
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        rendMat.material.color = colorToTurnTo;
        
        if (destroyEffect.Dead == true)
        {
        RandomColor();
        ChangeColor();  
        destroyEffect.Dead = false;

        }
        
    }

    void RandomColor()
{
    colorToTurnTo = new Color32(
        (byte)Random.Range(0, 256),
        (byte)Random.Range(0, 256),
        (byte)Random.Range(0, 256),
        255
    );
}

    void ChangeColor()
    {
        RandomColor();
        rend.material.color = colorToTurnTo;
    }
}
