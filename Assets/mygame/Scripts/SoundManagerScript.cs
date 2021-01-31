using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip playerHitPresent, playerHitEnemy;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        playerHitEnemy = Resources.Load<AudioClip>("playerHitEnemy");
        playerHitPresent = Resources.Load<AudioClip>("playerHitPresent");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "playerHitEnemy":
                audioSrc.PlayOneShot(playerHitEnemy);
                break;

            case "playerHitPresent":
                audioSrc.PlayOneShot(playerHitPresent);
                break;
        }




    }
}
