using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeExample : MonoBehaviour
{
    // Definition of a Function
    public int numTimesCalled = 0; // 1

    void Update() {
    numTimesCalled++; // 2
    CountUpdates(); // 3
    }

    void CountUpdates() { // 4
    string outputMessage = "Updates: "+numTimesCalled; // 5
    print( outputMessage ); // Output example: "Updates: 1" // 6
    }






}
