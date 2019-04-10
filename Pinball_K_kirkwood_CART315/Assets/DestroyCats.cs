/*
using System.Collections;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class ScoreAndHealthSystem : MonoBehaviour
{
    //starting point
    public int currentScore = 0;
    //end point for good
    public int maxScore = 50;
    public int minScore = -50;

    public int currentHealth = 0;
    public int maxHealth = 9;
    public int damage = 1;
    public int minHealth = -1;


    void Start()
    {

    }
    /*
    void Update()
    {
        if (currentScore > maxScore)
        {
            //reset once max score is reached
            currentScore = maxScore;
        }
        if (currentScore == maxScore)
        {
            GameOverGood();
            currentScore == 0;
        }
        if (currentScore == minScore)
        {
            GameOverEvil();
            currentScore = 0;
        }

    }

        //ourplayer can go all the way down to -50 but once they go past this point reset it.
        if (currentScore< -50)
        {
            currentScore = 0;
        }

        if (currentScore == maxScore)
        {
            //we could implement something extra where we reach a new level
            GiveExtraLife();
        }
        // you are a ded boi
        if (currentHealth< -50)
        {
            currentHealth = 0;
            GameOver();
        }

        //player cannot go past this point
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
            //Destroy(col.gameObject);
            currentHealth = 0;
            GameOver();
        }
    }
    
    void GiveExtraLife()
{
    currentHealth++;
   
}
//I want to apply the tag collectble to the stores
void OnTriggerEnter(Collider col)
{
    if (col.tag == "Collectible")
    {
    currentHealth++;
        currentScore++;
        //dont know if destroyy is the right answer...
       // Destroy(col.gameObject);
       //you can collect nine lives then the cat goes to heaven
    }
}

// send out message either good or evil for the player then reset the scene. 
void GameOver()
{
//put in a  particle animation for fun
}
}
/* OnTriggerEnter(Collider col) {
    if(col.tag == "Example") {
       DoSomething()
    }
    
    if(col.tag == "Example_two") {
       DoSomething()
    }
 }
*/
/*
public class DestroyCats : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cats")
        {
            NineLives =
        }
        else if (NineLives == 9)
        {
            Destroy(col.gameObject);
        }
    }
}
*/
