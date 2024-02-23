using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountItHigher : MonoBehaviour
{
    private int _num = 0; // 1

    void Update() {
    print( nextNum );
    }

    public int nextNum { // 2
    get {
    _num++; // Increase the value of _num by 1
    return( _num ); // Return the new value of _num
    }
    }

    public int currentNum { // 3
    get { return( _num ); } // 4
    set { _num = value; } // 4
    }
}
