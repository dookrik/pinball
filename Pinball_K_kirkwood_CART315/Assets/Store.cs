using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    int store = 0;
    int multiplier = 1;

    public TMPro.TextMeshPro multipliertext;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        this.GetComponent<TMPro.TextMeshPro>().text = store.ToString();
        multipliertext.text = "x" + multiplier.ToString();
    }

    public void AddScore(int points)
    {
        store = store + points * multiplier;
    }

    public void Addmultiplier(int multiplierpoints)
    {
        multiplier = multiplier + multiplierpoints;
    }

    public void ResetScore()
    {
        store = 0;
    }

    public void ResetMultiplier()
    {
        multiplier = 1;
    }
}
