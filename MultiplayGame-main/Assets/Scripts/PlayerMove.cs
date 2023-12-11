using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMove : MonoBehaviourPunCallbacks
{
    public float speed = 1f;
    public float rspeed = 5f;


    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-speed * Time.deltaTime, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed * Time.deltaTime, 0f, 0f);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0f, 0f, speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0f, 0f, -speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(0f, -rspeed * Time.deltaTime, 0f);
            }

            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(0f, rspeed * Time.deltaTime, 0f);
            }
        }

 
    }
}
