using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonHorror : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera Eyes;
    public Rigidbody RB;
    public float MouseSensitivity = 3;
    public float WalkSpeed = 10;



    public AudioSource AS;
    public AudioClip AC;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        AS = GetComponent<AudioSource>();
    }


    void Update()
    {
        float xRot = Input.GetAxis("Mouse X") * MouseSensitivity;
        float yRot = -Input.GetAxis("Mouse Y") * MouseSensitivity;
        transform.Rotate(0, xRot, 0);
        Eyes.transform.Rotate(yRot, 0, 0);

        if (WalkSpeed > 0)
        {
            Vector3 move = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
                move += transform.forward;
            if (Input.GetKey(KeyCode.W)) 
            {
                if (!AS.isPlaying)
                {
                    AS.Play();
                }
            }
            else
            {
                AS.Stop();
            }

            if (Input.GetKey(KeyCode.S))
                move -= transform.forward;
            if (Input.GetKey(KeyCode.W))
            {
                if (!AS.isPlaying)
                {
                    AS.Play();
                }
            }
            else
            {
                AS.Stop();
            }


            if (Input.GetKey(KeyCode.A))
                move -= transform.right;
            if (Input.GetKey(KeyCode.W))
            {
                if (!AS.isPlaying)
                {
                    AS.Play();
                }
            }
            else
            {
                AS.Stop();
            }

            if (Input.GetKey(KeyCode.D))
                move += transform.right;
            if (Input.GetKey(KeyCode.W))
            {
                if (!AS.isPlaying)
                {
                    AS.Play();
                }
            }
            else
            {
                AS.Stop();
            }

            move = move.normalized * WalkSpeed;

            RB.velocity = move;

        }



    }
}

   

    

