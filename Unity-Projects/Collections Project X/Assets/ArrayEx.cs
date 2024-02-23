using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayEx : MonoBehaviour
{
    public string[] sArray; // 1

    void Start () {
    sArray = new string[10]; // 2

    sArray[0] = "These"; // 3
    sArray[1] = "are";
    sArray[2] = "some";
    sArray[3] = "words";

    print( "The length of sArray is: "+sArray.Length ); // 4

    string str = "";
    foreach (string sTemp in sArray) { // 5
    str += "|"+sTemp;
    }
    print( str );
        
    }
}
