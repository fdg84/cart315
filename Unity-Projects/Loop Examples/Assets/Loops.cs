using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // // for Loops
        // for ( int i=0; i<3; i++ ) {
        // print( "Loop: "+i );
        // }

        // // foreach Loops
        // string str = "Hello";
        // foreach( char chr in str ) {
        // print( chr );
        // }

        // // break
        for ( int i=0; i<10; i++ ) {
        print( i );
        if ( i==3 ) {
        break;
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
