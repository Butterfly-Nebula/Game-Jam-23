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
    public GameObject anotherPlayer;
    public bool Dead = false;
    public GameObject Collision;
    public GameObject Drop;

    public GameObject canvas;
    public GameObject destroyTrigger;
    public PlayerController playerController;

    //public ScoreScript scoreScript;

    void Start()
    {
        playerController = anotherPlayer.GetComponent<PlayerController>();
        //scoreScript = canvas.GetComponent<ScoreScript>();
    }

    void Update()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (destroyTrigger.activeInHierarchy == true)
        {
            Teleport();
            //playerController.activeMoveSpeed = -20;
            Instantiate(Collision, transform.position, Quaternion.identity);
            Instantiate(Drop, transform.position, transform.rotation);

            //scoreScript.ScoreNum += 1;
           //scoreScript.MyscoreText.text = "Score: " + scoreScript.ScoreNum;

        }
 
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY,maxY);

        anotherPlayer.transform.position = new Vector3(X, Y, 0);

        //Vector3 randomPos = Random.insideUnitCircle * Radius;
    }

    void Teleport()
    {
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY,maxY);
        
        //yield return new WaitForSeconds(0.1f);
        anotherPlayer.transform.position = new Vector3(X, Y, 0);
        //yield return new WaitForSeconds(0.1f);
        Dead = true;

    }
}
