using System.Collections;
using System.Collections.Generic;
using UnityEngine;


var Counter : int = 0;   
    
 public class Score : MonoBehaviour
{


}


    function Update()
{
    // I want to remove the score so do I 
    guiText.text = "Score: " - Counter;
}

 function React()
{
    Counter--;
}


public void ResetScore()
{
    score = 0;
}
using UnityEngine;
using System.Collections;

public class DestroyCubes : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        //you can name specific objs
        if (col.gameObject.name == "prop_powerCube")
        {
            Destroy(col.gameObject);
        }
    }
}