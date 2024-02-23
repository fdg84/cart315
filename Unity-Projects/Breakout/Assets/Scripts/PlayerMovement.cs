using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed=9;
    public float maxX =9.5f;

    float movementHorizontal;

    void Start()
    {
        
    }

    void Update()
    {
        movementHorizontal = Input.GetAxis("Horizontal");
        if((movementHorizontal>0 && transform.position.x<maxX) || (movementHorizontal<0 && transform.position.x > -maxX))
        {
             transform.position +=Vector3.right*movementHorizontal*speed*Time.deltaTime;

        }
    }
}
