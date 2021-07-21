using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Manager : MonoBehaviour {

    public Slider diffSlider;
   // public Toggle carColor;


    void Start () {
		
	}
	
	
	void Update ()
    {
        if (Input.touchCount == 0)//smoothes the slider 
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
        }
    }
}
