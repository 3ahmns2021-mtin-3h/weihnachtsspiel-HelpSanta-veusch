using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timeInSec;
    public TextMeshProUGUI timer;

    void Start()
    {
        timeInSec = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        timeInSec -= Time.deltaTime;
        float minutes = Mathf.FloorToInt(timeInSec / 60);
        float seconds = Mathf.FloorToInt(timeInSec % 60);

        if (timeInSec > 0)
        {

            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            Time.timeScale = 0;
            Debug.Log("stop game");
        }
    }
}
