using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Settings : MonoBehaviour {

    public const float speedEasy = 12.0f;
    public const float speedMed = 15.0f;
    public const float speedHard = 20.0f;

    private float[] speeds;

    //public spawnRate;



    public static float speed = speedEasy;//no movement when i start the game

    void Start ()
    {
        speeds = new float[] { speedEasy, speedMed, speedHard };
        
	}
	

	void Update ()
    {

    }

    public void SetDifficulty(float diff)
    {
        if (diff >= 0.5f && diff < 1.5f)
        {
            diff = 1.0f;
        }
        else if (diff >= 1.5f)
        {
            diff = 2.0f;
        }
        else diff = 0.0f;
        Debug.Log(diff);

        speed = speeds[(int)diff];
    }


    public void SetColor()
    {

    }

}


/* MOVE TO GUI_Manager
if(Input.touchCount == 0)//smoothes the slider 
{
    if (diffSlider.value >= 0.5f && diffSlider.value < 1.5f)
    {
        diffSlider.value = 1.0f;
    }
    else if (diffSlider.value >= 1.5f)
    {
        diffSlider.value = 2.0f;
    }
    else diffSlider.value = 0.0f;
}*/
