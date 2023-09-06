using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;


public class DestroyEffect : MonoBehaviour
{   

    public GameObject Player2;
    public bool Dead = false;
    public GameObject Collision;
    public GameObject Drop;
    void Start()
    {

    }

    void Update()
    {

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
}
