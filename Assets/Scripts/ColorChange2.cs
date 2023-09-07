using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorChange2 : MonoBehaviour
{   
    public GameObject Player2;
    public DestroyEffect destroyEffect;
    public Renderer rend;
    public Renderer rendMat;
    //public Renderer dropMat;
    public Color colorToTurnTo;

    public PlayerController playerController;

    //public DropColor dropColor;
    void Start()
    {
        destroyEffect = Player2.GetComponent<DestroyEffect>();
        rend = GetComponent<Renderer>();
        //dropMat = GetComponent<Renderer>();
        //dropColor.dropMat = dropColor.GetComponent<Renderer>();
    }

    void Update()
    {
        rendMat.material.color = colorToTurnTo;
        //dropColor.dropMat.material.color = colorToTurnTo;
        
        if (destroyEffect.Dead == true)
        {
        RandomColor();
        ChangeColor();
        //destroyEffect.Dead = false;

        }

        if (playerController.dashCoolCounter > 0)
        {
            Color cooldownColor = new Color(colorToTurnTo.r - 0.24f, colorToTurnTo.g - 0.24f, colorToTurnTo.b - 0.24f);
            rend.material.color = cooldownColor;
            Invoke("ChangeColor", 1f);
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
        rend.material.color = colorToTurnTo;
    }
}
