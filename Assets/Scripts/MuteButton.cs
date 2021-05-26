using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    public Sprite onButton;
    public Sprite offButton;
    public Button soundButton;
    public Image soundButtonImage;
    public int isMute;

    // Use this for initialization
    void Start ()
    {
        Button btnSound = soundButton.GetComponent<Button>();
        btnSound.onClick.AddListener(ChangeSound);

        isMute = PlayerPrefs.GetInt("isMute", 0);

        if (isMute == 0)
        {
            soundButtonImage.sprite = onButton;
            AudioListener.volume = 1.0f;
            isMute = -1;
        }
        else if (isMute == 1)
        {
            soundButtonImage.sprite = offButton;
            AudioListener.volume = 0.0f;
            isMute = 1;
        }
        else if (isMute == -1)
        {
            soundButtonImage.sprite = onButton;
            AudioListener.volume = 1.0f;
            isMute = -1;  
        }

        PlayerPrefs.SetInt("isMute", isMute);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ChangeSound()
    {
        if (isMute == 1)
        {
            soundButtonImage.sprite = onButton;
            AudioListener.volume = 1.0f;
            isMute = -1;
        }
        else if (isMute == -1)
        {
            soundButtonImage.sprite = offButton;
            AudioListener.volume = 0.0f;
            isMute = 1;
        }

        PlayerPrefs.SetInt("isMute", isMute);
    }
}
