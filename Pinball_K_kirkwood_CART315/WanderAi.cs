﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAi : MonoBehaviour{

    public float moveSpeed = 10f;
    public float rotSpeed = 200f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

// init
void Start()
{

}

    //called once per frame
void Update()
{
    if (isWandering == false)
    {
        StartCoroutine(Wander());
    }
    if(isRotatingRight == true)
    {
        transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
    }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }
        if (isWalking == true)
        {
            transform.position +- transform.forward * moveSpeed * Time.deltaTime;
        }
    }

IEnumerator Wander()
{
    int rotTime = Random.Range(1, 3);
    int rotWait = Random.Range(1, 4);
    int rotLorR = Random.Range(0, 3);
    int walkWait = Random.Range(1, 5);
    int walkTime = Random.Range(1, 14);

    isWandering = true;

    yield return new WaitForSeconds(walkWait);
    isWalking = true;
    yield return new WaitForSeconds(walkTime);
    isWalking = false;
    yield return new waitForSeconds(rotWait);
    if (rotLorR == 1)
    {
        isRotatingRight = true;
        yield return new WaitForSeconds(rotTime);
        isRotatingRight = false;
    }
    if (rotLorR == 2)
    {
        isRotatingLeft = true;
        yield return new WaitForSeconds(rotTime);
        isRotatingLeft = false;
    }
    isWandering = false;
     }
}