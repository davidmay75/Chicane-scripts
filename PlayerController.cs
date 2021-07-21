using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour {


    private float moveSpeed = 10.0f;
    private float turnSpeed = 10.0f;

    void Update()
    {
        /// LEFT ///
        if( ( (Input.GetKey(KeyCode.LeftArrow) ) || (Input.GetKey(KeyCode.A)) ) && (transform.position.x > -8))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0f, 0f);
        }

        /// RIGHT ///
        else if (((Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.D))) && (transform.position.x < 8))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
        }
        else
        {
            transform.Translate(0 * Time.deltaTime, 0f, 0f);
        }
        
    }
}
