using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEffect : MonoBehaviour
{   
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
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
        }
    }
    void Spawn()
    {
        //float X = Random.Range(minX, maxY);
        //float Y = Random.Range(minY,maxY);

        //Instantiate(Player2, transform.position + new Vector2(X, Y), transform.rotation);
    }
}
