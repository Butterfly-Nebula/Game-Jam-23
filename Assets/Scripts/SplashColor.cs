using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashColor : MonoBehaviour
{
    public GameObject Drop;
    private Renderer dropMat;
    public Color colorToTurnTo;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    //public float TimeBetweenSpawn;

    private ColorChange colorChange;
    private float SpawnTime;
    //private DestroyEffect destroyEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        dropMat = Drop.GetComponent<Renderer>();
        ChangeColor();
        colorChange = GameObject.FindObjectOfType<ColorChange>();
        dropMat.material.color = colorChange.colorToTurnTo;
        //destroyEffect = GameObject.FindObjectOfType<DestroyEffect>();
        

        //InvokeRepeating("Spawn", 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }*/

        /*SpawnTime -= Time.deltaTime;
        if(SpawnTime <= 0f)
        {
            Spawn();
            SpawnTime = 100f;
        }*/
        

        /*if(destroyEffect.Dead == true)
        {
            Spawn();
        }*/
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY,maxY);

        Instantiate(Drop, new Vector3(X, Y, 0), transform.rotation);
        ChangeColor();

        //Vector3 randomPos = Random.insideUnitCircle * Radius;
    }

    void ChangeColor()
    {
        /*colorToTurnTo = new Color32(
        (byte)Random.Range(0, 256),
        (byte)Random.Range(0, 256),
        (byte)Random.Range(0, 256),
        255
        );*/


    }
}
