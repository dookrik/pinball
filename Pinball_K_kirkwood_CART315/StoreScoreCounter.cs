using System.Collections;
using System.Collections.Generic;
using UnityEngine;


var Counter : int = 0;      
 
     // Start is called before the first frame update
    void Start()
{

}

function Update()
{
    guiText.text = "Score: " + Counter;
}

function React()
{
    Counter++;
}

