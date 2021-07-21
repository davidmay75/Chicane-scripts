using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


/// MAKE HANDLE RED INTO WHITE
public class EndMenu : MonoBehaviour {

    public GameObject menuUI;
    public TextMeshProUGUI scoreTxt;

    private int tries;
    private float scoreDist;
    public static bool isCrashed = false;


    private void Start()
    {
        menuUI.SetActive(false);
        
    }
    void Update ()
    {
		if(isCrashed == true)
        {
            MenuUp();
        }
	}

    void MenuUp()
    {
        menuUI.SetActive(true);
        scoreTxt.text = "Distance: " + System.Math.Round(Spawner.totTime, 2)  + " Seconds";
        tries++;
        //update score text
    }

    public void GoMain()
    {
        SceneManager.LoadScene("MainMenu");
        isCrashed = false;
        Spawner.totTime = 0;
        //loadAd
    }

    public void GoRetry()
    {
        SceneManager.LoadScene("GameScene");
        isCrashed = false;
        Spawner.totTime = 0;
        //menuUI.SetActive(false);

    }
}
