using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barrier : MonoBehaviour {

    public float moveSpeed;// = 12.0f;//set in settings


    private void Start()
    {
       moveSpeed = Settings.speed;
       Debug.Log(moveSpeed);
    }

    void Update ()
    {
        transform.Translate(0f, 0f, -moveSpeed * Time.deltaTime);

        if(transform.position.z < -14)
        {
            Destroy(this.gameObject);
        }
    }

    /*private void FixedUpdate()
    {
        transform.Translate(0f, 0f, -moveSpeed);

       

        if (transform.position.z < -14)
        {
            Destroy(this.gameObject);
        }
    }*/
}
