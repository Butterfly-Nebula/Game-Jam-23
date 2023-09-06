using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerClone : MonoBehaviour
{       
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    //public float Radius = 1;

    public GameObject Player2;
    public DestroyEffect destroyEffect;
    
    void Start()
    {
        GetComponent<DestroyEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if(destroyEffect.Dead == true)
        {
            Spawn();
            destroyEffect.Dead = false;
        }
    }

     void Spawn()
    {
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY,maxY);

        Player2 = Instantiate(Player2, transform.position + new Vector3(X, Y, 0), transform.rotation);

        //Vector3 randomPos = Random.insideUnitCircle * Radius;
    }
}
