using System.Collections;
using System.Collections.Generic;
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
    public GameObject Splash;

    //public GameObject canvas;
    public GameObject destroyTrigger;
    public PlayerController playerController;

    public AudioSource audioSource;

    private Animator animator;
    
    //public AudioClip audioClip;

    //public ScoreScript scoreScript;

    private int rand;
    public Sprite[] Sprite_Pic;

    void Start()
    {
        playerController = anotherPlayer.GetComponent<PlayerController>();
        //scoreScript = canvas.GetComponent<ScoreScript>();
        animator = anotherPlayer.GetComponent<Animator>();
    }

    void Update()
    {
        if (Dead == true)
        {
            Debug.Log("Dead");
        }

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        animator.SetTrigger("TrDead");
        if (destroyTrigger.activeInHierarchy == true && other.gameObject.CompareTag("Player"))
        {
            
            Teleport();
            //playerController.activeMoveSpeed = -20;
            Instantiate(Collision, transform.position, Quaternion.identity);
            Instantiate(Drop, transform.position, transform.rotation);
            Instantiate(Splash, anotherPlayer.transform.position, transform.rotation);

            playerController.textBox2.SetActive(true);
            Invoke("TextRemover", 1f);

            audioSource.Play();    //OneShot(audioClip);
            //Dead = false;
            

            //scoreScript.ScoreNum += 1;
           //scoreScript.MyscoreText.text = "Score: " + scoreScript.ScoreNum;

        }

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

    void TextRemover()
    {
        playerController.textBox2.SetActive(false);
    }
}
