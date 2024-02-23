using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlong : MonoBehaviour
{
    // Start is called before the first frame update
    void LateUpdate() { // 1
    CountItHigher cih=this.gameObject.GetComponent<CountItHigher>(); // 2
    if ( cih != null ) { // 3
    float tX = cih.currentNum/10f; // 4
    Vector3 tempLoc = pos; // 5
    tempLoc.x = tX;
    pos = tempLoc;
    }
    }

    public Vector3 pos { // 6
    get { return( this.transform.position ); }
    set { this.transform.position = value; }
    }

}
