using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class GameOverButtons : MonoBehaviour
{
    public Button restartButton;
    public Button menuButton;
    public int adCounter = 0;

	// Use this for initialization
	void Start ()
    {
        adCounter = PlayerPrefs.GetInt("adCounter", 0);

        Button btnRestart = restartButton.GetComponent<Button>();
        btnRestart.onClick.AddListener(RestartGame);

        Button btnMenu = menuButton.GetComponent<Button>();
        btnMenu.onClick.AddListener(GoToMenu);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void RestartGame()
    {
        adCounter++;

        if (adCounter >= 5)
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show();
            }
            adCounter = 0;
        }

        PlayerPrefs.SetInt("adCounter", adCounter);

        SceneManager.LoadScene("SpaceFloater");

        
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("SpaceFloaterMenu");
    }
}
