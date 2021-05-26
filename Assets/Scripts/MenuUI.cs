using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public Button PlayButton;
    public Button creditsButton;
    public Button xButton;
    public GameObject canvas;

    // Use this for initialization
    void Start ()
    {
        Button btn = PlayButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadGame);

        Button btnCredits = creditsButton.GetComponent<Button>();
        btnCredits.onClick.AddListener(OpenCredits);

        Button btnX = xButton.GetComponent<Button>();
        btnX.onClick.AddListener(CloseCredits);

      

        canvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    public void LoadGame()
    {
        SceneManager.LoadScene("SpaceFloater");
    }

    public void OpenCredits()
    {
        canvas.SetActive(true);
    }

    public void CloseCredits()
    {
        canvas.SetActive(false);
    }
}
