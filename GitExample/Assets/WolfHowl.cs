using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHowl : MonoBehaviour
{
    public float Timer = 5;
    public AudioSource AS;
    public AudioClip AC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        
        if (Timer <= 0)
        {
            AS.PlayOneShot(AC);
            Timer = 9999;
        }
    }
}
