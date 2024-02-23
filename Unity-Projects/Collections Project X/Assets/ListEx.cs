using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListEx : MonoBehaviour
{
public List<string> sList; // 4

void Start () {
    sList = new List<string>(); // 5
    sList.Add( "Experience" ); // 6
    sList.Add( "is" );
    sList.Add( "what" );
    sList.Add( "you" );
    sList.Add( "get" );
    sList.Add( "when" );
    sList.Add( "you" );
    sList.Add( "didn't" );
    sList.Add( "get" );
    sList.Add( "what" );
    sList.Add( "you" );
    sList.Add( "wanted." );
    // This quote is from my professor, Dr. Randy Pausch (1960-2008)
    print( "sList Count = "+sList.Count ); // 7
    print( "The 0th element is: "+sList[0] ); // 8
    print( "The 1st element is: "+sList[1] );
    print( "The 3rd element is: "+sList[3] );
    print( "The 8th element is: "+sList[8] );
    
    string str = "";
    foreach (string sTemp in sList) { // 9
    str += sTemp+" ";
    }
    print( str );
        
    }
}
