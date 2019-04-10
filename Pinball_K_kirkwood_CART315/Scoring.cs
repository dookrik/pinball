using System.Collections;



var Counter : int = 0;


public class Class1
{
	public Class1()
	{
	}
}

function Update()
{
    guiText.text = "score: " + Counter;
    Counter += 10;


}