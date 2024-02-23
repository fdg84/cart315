using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaggedArrayEx : MonoBehaviour
{
    public string[][] jArray; // 1

    void Start () {
    jArray = new string[4][]; // 2

    jArray[0] = new string[4]; // 3
    jArray[0][0] = "A";
    jArray[0][1] = "B";
    jArray[0][2] = "C";
    jArray[0][3] = "D";

    // The following lines use single-line Array initialization // 4
    jArray[1] = new string[] { "E", "F", "G" };
    jArray[2] = new string[] { "H", "I" };

    jArray[3] = new string[4]; // 5
    jArray[3][0] = "J";
    jArray[3][3] = "K";

    print( "The Length of jArray is: "+jArray.Length ); // 6
    // Outputs: The Length of jArray is: 4

    print( "The Length of jArray[1] is: "+jArray[1].Length ); // 7
    // Outputs: The Length of jArray[1] is: 3

    string str = "";
    foreach (string[] sArray in jArray) { // 8
    foreach( string sTemp in sArray ) {
    if (sTemp != null) {
    str += " | "+sTemp; // 9
    } else {
    str += " | "; //10
    }
    }
    str += " | \n";
    }

    print( str );
    }

        
    }
