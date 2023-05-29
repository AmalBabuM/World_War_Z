using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float timer = 11f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer-= Time.deltaTime;
        /*Debug.Log(timer);*/
        if (timer<=0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
