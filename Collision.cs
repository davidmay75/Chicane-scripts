using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Collision : MonoBehaviour {

    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        GameObject explosion1 = Instantiate(explosion) as GameObject;
        explosion1.transform.position = transform.position;
        this.gameObject.SetActive(false);
   
       // SceneManager.LoadScene("MainMenu");
        EndMenu.isCrashed = true;
    }
}
