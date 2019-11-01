using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Score : MonoBehaviour
{
    public int countLeft = 0,
               countRight = 0;
    
    public GameObject scoreLeft;    //left side of table
    public GameObject scoreRight;    //right side of table

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Ball") )
            countLeft++;
        
        else if (hit.gameObject.CompareTag("Ball") )
            countRight++;
        
        Debug.Log(countLeft);
        Debug.Log(countRight);
    }
}
