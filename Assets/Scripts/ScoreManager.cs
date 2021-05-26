using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreTextSmall;
    public Text scoreTextLarge;
    public Text scoreTextHighscore;

    public bool scoreIncreasing = true;
    public float scoreCount = 10.0f;
    public float stopScore = 0.0f;
    public float scoreSmall = 0.0f;
    public float scoreLarge = 0.0f;
    public float scoreHighscore = 0.0f;

    public GameObject scoreTextObject;

    // Use this for initialization

    void Start()
    {
        scoreHighscore = PlayerPrefs.GetFloat("highscore", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing == true)
        {
            scoreSmall += scoreCount * Time.deltaTime;
            scoreTextSmall.text = "" + Mathf.Round(scoreSmall);
        }
        else if (scoreIncreasing == false)
        {
            scoreCount = stopScore;
            scoreTextObject.SetActive(false);

            scoreLarge = scoreSmall;

            scoreTextLarge.text = "" + Mathf.Round(scoreLarge);

            if (scoreLarge > scoreHighscore)
            {
                scoreHighscore = scoreLarge;
                PlayerPrefs.SetFloat("highscore", scoreHighscore);
            }

            scoreTextHighscore.text = "" + Mathf.Round(scoreHighscore);
        }
    }
}
