using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawner : MonoBehaviour {

    public GameObject barrierR;
    public GameObject barrierW;
    private GameObject[] barriers;
    

    //private float waitDelay = 2.0f;
    private float distance = 0.0f; //going to use time to get distance
    private float distScale = 12.0f; // easy speed - can change
    public static float totTime = 0;




    void Start()
    {
        //LightsOut();
        //distScale = Barrier.moveSpeed; //will be accessed via settings script eventually
        barriers = new GameObject[]{ barrierR, barrierW };
        StartCoroutine(Wave());
        Spawner.totTime = 0;
    }

	void Update ()
    {
        //distance += distScale * 0.1f;
        //Debug.Log(distance);
        if(EndMenu.isCrashed == false)
        {
            totTime += Time.deltaTime;
            //Debug.Log(totTime);
        }
        
    }

    private void SpawnBarrier(float xPos)
    {
        float randPos = xPos;
        GameObject newBarrier = Instantiate(barriers[1]) as GameObject;
        newBarrier.transform.position = new Vector3(randPos, 0.5f, 40.0f);
    }

    int waveNum = 0;


    IEnumerator Wave()
    {
   
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.1f, 1.0f));
            int quantity = Random.Range(1, 3);
            int quantSpawned = 0;

            Debug.Log("waveNum" + waveNum);

            while (quantSpawned < quantity)
            {
                float[] spawnpoints = new float[quantity]; //store previous spawnpoints

                if (quantSpawned == 0)
                {
                    float spawnpoint = Random.Range(-8.0f, 8.0f);
                    SpawnBarrier(spawnpoint); //spawn 1st barrier
                    spawnpoints[quantSpawned] = spawnpoint;
                    //quantSpawned++;
                    Debug.Log("quantSpawned == 0");
                }
                else if (quantSpawned == 1)
                {
                    float spawnpoint = Random.Range(-7.5f, 7.5f);

                    while (System.Math.Abs(spawnpoint - spawnpoints[0]) <= 1.5f)
                    {
                        spawnpoint = Random.Range(-7.5f, 7.5f);
                    }

                    SpawnBarrier(spawnpoint);
                    spawnpoints[quantSpawned] = spawnpoint;
                    //quantSpawned++;
                    Debug.Log("quantSpawned == 1");
                }
                else if (quantSpawned == 2)
                {
                    float spawnpoint = Random.Range(-7.5f, 7.5f);

                    while ((System.Math.Abs(spawnpoint - spawnpoints[0]) <= 1.5f) || (System.Math.Abs(spawnpoint - spawnpoints[1]) <= 1.5f))
                    {
                        spawnpoint = Random.Range(-7.5f, 7.5f);
                    }

                    SpawnBarrier(spawnpoint);
                    spawnpoints[quantSpawned] = spawnpoint;
                    //quantSpawned++;
                    Debug.Log("quantSpawned == 2");
                }
                else if (quantSpawned == 3)
                {
                    float spawnpoint = Random.Range(-7.5f, 7.5f);

                    while ((System.Math.Abs(spawnpoint - spawnpoints[0]) <= 1.5f) || (System.Math.Abs(spawnpoint - spawnpoints[1]) <= 1.5f) || (System.Math.Abs(spawnpoint - spawnpoints[2]) <= 1.5f))
                    {
                        spawnpoint = Random.Range(-7.5f, 7.5f);
                    }

                    SpawnBarrier(spawnpoint);
                    spawnpoints[quantSpawned] = spawnpoint;
                    //quantSpawned++;
                    Debug.Log("quantSpawned == 3");
                }
                else { Debug.Log("ELSE"); }

                quantSpawned++;

            }
            waveNum++;
        }    
    }

    

        public void LightsOut()
    {
        /*
         show lights
         countdown
         lightsout
         start distance timer --- Spawner.totTime = 0;
         */
    }

}

