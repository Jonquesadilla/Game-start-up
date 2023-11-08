using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareWall : MonoBehaviour
{

    public Animator ele;
    public AudioSource AS;
    public AudioClip AC;

    // Start is called before the first frame update
    void Start()
    {
        //ele = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.name == "Capsule")
        {
            
           ele.enabled = true;
            AS.PlayOneShot(AC);
        }


    }
}
