using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    public int ScoreNum;

    public DestroyEffect destroyEffect;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score: " + ScoreNum;
        destroyEffect = GetComponent<DestroyEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyEffect.Dead == true)
        {
            ScoreNum += 1;
            MyscoreText.text = "Score: " + ScoreNum;
        }
    }
}
