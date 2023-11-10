using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorChange : MonoBehaviour
{   
    public GameObject Player;
    public DestroyEffect destroyEffect;
    public Renderer rend;
    public Renderer rendMat;

    public Color colorToTurnTo;
    public Color colorParticle;
    public PlayerController playerController;

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
        Debug.Log("Dead");
        }

        if (playerController.dashCoolCounter > 0)
        {
            Color cooldownColor = new Color(colorToTurnTo.r - 0.24f, colorToTurnTo.g - 0.24f, colorToTurnTo.b - 0.24f);
            rend.material.color = cooldownColor;
            Invoke("ChangeColor", 1f);
        }

    }

    public void RandomColor()
    {
        colorToTurnTo = new Color32(
        (byte)Random.Range(0, 256),
        (byte)Random.Range(0, 256),
        (byte)Random.Range(0, 256),
        255
        );
        
        colorParticle = new Color32(
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
