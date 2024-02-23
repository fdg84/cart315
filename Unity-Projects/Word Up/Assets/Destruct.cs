using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct : MonoBehaviour
{

    bool canBeDestroyed = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x < 6.3f)
        {
            canBeDestroyed = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bullet bullet = collision.GetComponent<Bullet>();
        if (bullet != null)
        {
            if (!bullet.isEnemy)
            {
                Destroy(gameObject);
                Destroy(bullet.gameObject);
            }
        
        }
    }

}
