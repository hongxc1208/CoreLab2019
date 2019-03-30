using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingerState : MonoBehaviour
{
    public float timer = 5.0f;
    public GameObject singer;



    private void Start()
    {
        singer.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

       

        if(timer <= 0.0f) {

            timeEnded();
        }

    }

    void timeEnded() {

        Debug.Log("time's up");
        singer.SetActive(true);
    
    }
}
