using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightLeft : MonoBehaviour
{

    public float moveSpeed = 1;

    void Start()
    {
        
    }

    void Update()
    {
        
        Vector2 pos = transform.position;

        pos.x -= moveSpeed * Time.fixedDeltaTime;

        if (pos.x < -2) 
        {
            Destroy(gameObject);
        }
        
        transform.position = pos;

    }
}
