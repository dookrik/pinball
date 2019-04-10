using UnityEngine;
using System.Collections;

public class WanderAi : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotSpeed = 100f;
    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;


}

void Start()
{

}

void Update()
{
    if (isWandering == false)
    {
        StartCoroutine(Wander());
    }
}

IEnumerator Wander()
{
    int rotTime = Random.Range(1, 3);
    int rotWait = Random.Range(1, 3);
    int rotLorR = Random.Range(1, 3);
    int walkWait = Random.Range(1, 3);
    int walkTime = Random.Range(1, 4);

    isWandering = true;

    yield return new WaitForSeconds(walkWait);
    isWalking = true;
    yield return new WaitForSeconds(walkTime);
    isWalking = false;
    yield return new waitForSeconds(rotWait);
    if(rotLorR == 1)
    {
        isRotatingRight = true;
        yield return new WaitForSeconds(rotTime);
        isRotatingRight = false;

    }


}