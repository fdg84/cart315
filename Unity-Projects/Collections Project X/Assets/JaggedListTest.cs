using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaggedListTest : MonoBehaviour
{
    public List<List<string>> jaggedList;

    // Use this for initialization
    void Start () {
    jaggedList = new List<List<string>>();

    // Add a couple List<string>s to jaggedList
    jaggedList.Add( new List<string>() );
    jaggedList.Add( new List<string>() );

    // Add two strings to jaggedList[0]
    jaggedList[0].Add ("Hello");
    jaggedList[0].Add ("World");

    // Add a third List<string> to jaggedList, including data
    jaggedList.Add ( new List<string>( new string[] {"complex",
    "initialization"} ) ); // 2

    string str = "";
    foreach (List<string> sL in jaggedList) {
    foreach (string sTemp in sL) {
    if (sTemp != null) {
    str += " | "+sTemp;
    } else {
    str += " | ";
    }
    }
    str += " | \n";
    }
    print( str );
    }
    
}
