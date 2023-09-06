using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DestroyEffect : MonoBehaviour
{   
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    //public float Radius = 1;
    public GameObject Player2;
    private bool Dead = false;
    public GameObject Collision;
    public GameObject Drop;
    void Start()
    {

    }

    void Update()
    {
        if(Dead == true)
        {
            Spawn();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Instantiate(Collision, transform.position, Quaternion.identity);
            Instantiate(Drop, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Dead = true;
            return;
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
