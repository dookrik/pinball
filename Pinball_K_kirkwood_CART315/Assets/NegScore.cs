using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//neg score counter
public class NegScore : MonoBehaviour
{
    int score = 0;
    int multiplier = 1;

    public TMPro.TextMeshPro multipliertext;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        this.GetComponent<TMPro.TextMeshPro>().text = score.ToString();
        multipliertext.text = "x" + multiplier.ToString();
    }

    public void AddScore(int points)
    {
        //changed + to -
        score = score - points * multiplier;
    }

    public void Addmultiplier(int multiplierpoints)
    {
        multiplier = multiplier + multiplierpoints;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void ResetMultiplier()
    {
        multiplier = 1;
    }
}