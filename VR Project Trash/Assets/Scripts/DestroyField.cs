using UnityEngine;
using System.Collections;

public class DestroyField : MonoBehaviour
{
    public Score score; //The score object
    public Score lives; //The lives object
    public int takePointAmount;  //The points to deduct when the player misses a toss
    public int takeLifeAmount;   //The amount of lives that are deducted when the player deserves a penalty

    public string trashName1;
    public string trashName2;
    public string trashName3;
    void Start()
    {
        score.PlayerScore = 0;          //Reset the score at the start of the game
        lives.PlayerScore = 9;          //Reset the lives at the start of the game
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == trashName1)
        {
            Destroy(other.gameObject);
            score.PlayerScore = score.PlayerScore - takePointAmount;    //Deduct the proper amount of points
            lives.PlayerScore = lives.PlayerScore - takeLifeAmount;     //Take away life equal to the amount provided in the public variable
        }
        else if(other.tag == trashName2){
            Destroy(other.gameObject);
            score.PlayerScore = score.PlayerScore - takePointAmount;    //Deduct the proper amount of points
            lives.PlayerScore = lives.PlayerScore - takeLifeAmount;     //Take away life equal to the amount provided in the public variable
        }
        else if (other.tag == trashName3){
            Destroy(other.gameObject);
            score.PlayerScore = score.PlayerScore - takePointAmount;    //Deduct the proper amount of points
            lives.PlayerScore = lives.PlayerScore - takeLifeAmount;     //Take away life equal to the amount provided in the public variable
        }
    }
    
}
