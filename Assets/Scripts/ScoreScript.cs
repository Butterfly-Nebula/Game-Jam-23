using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    public int ScoreNum;
    public int winScore;

    public DestroyEffect destroyEffect;

    public float slowMotionTimeScale;

    private float startTime;
    private float startFixedDeltaTime;
    private float startTimeScale;

    public GameObject fire;

    public GameObject playerOneText;
    public GameObject playerTwoText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = -1;
        MyscoreText.text = "Score: " + ScoreNum;
        destroyEffect = GetComponent<DestroyEffect>();

        startTimeScale = Time.timeScale;
        startFixedDeltaTime = Time.fixedDeltaTime;
        fire.SetActive(false);
        playerOneText.SetActive(false);
        playerTwoText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyEffect.Dead == true)
        {
            ScoreNum += 1;
            MyscoreText.text = "Score: " + ScoreNum;
        }

        if (ScoreNum == winScore - 1)
        {
            fire.SetActive(true);
        }
        
        if (ScoreNum == winScore)
        {
            

            if (name == "Player1")
            {
                Invoke("PlayerOneWin", 1f);
                //StartSlowMotion();
            }
            
            if (name == "Player2")
            {
                Invoke("PlayerTwoWin", 1f);
                //StartSlowMotion();
            }
        }
    }
    void StartSlowMotion()
    {
        Time.timeScale = slowMotionTimeScale;
        Time.timeScale = startFixedDeltaTime * slowMotionTimeScale;
    }

    void StopSlowMotion()
    {
        Time.timeScale = startTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime;
    }
    void PlayerOneWin()
    {
        StopSlowMotion();
        playerOneText.SetActive(true);
    }

    void PlayerTwoWin()
    {
        StopSlowMotion();
        playerTwoText.SetActive(true);
    }
}
