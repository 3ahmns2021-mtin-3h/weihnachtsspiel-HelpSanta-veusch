using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyVideoPlayer : MonoBehaviour
{
    private float timeSec;
    
    // Start is called before the first frame update
    void Start()
    {
        timeSec = 21f;
    }

    // Update is called once per frame
    void Update()
    {
        timeSec -= Time.deltaTime;
        if (timeSec <= 0f) {
            Destroy(gameObject);
           // Destroy(gameObject, 22f);
            SceneManager.LoadScene("Hu");
        }
    }
}
