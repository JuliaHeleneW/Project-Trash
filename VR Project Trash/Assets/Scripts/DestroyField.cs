using UnityEngine;
using System.Collections;

public class DestroyField : MonoBehaviour
{
    public Score score; //The score object
    public int takePointAmount;  //The points to deduct when the player misses a toss

    public string trashName1;
    public string trashName2;
    public string trashName3;
    void Start()
    {
        score.PlayerScore = 0;          //Reset the score at the start of the game
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == trashName1)
        {
            Destroy(other.gameObject);
            score.PlayerScore = score.PlayerScore - takePointAmount;    //Deduct the proper amount of points
        }
        else if(other.tag == trashName2){
            Destroy(other.gameObject);
            score.PlayerScore = score.PlayerScore - takePointAmount;    //Deduct the proper amount of points
        }
        else if (other.tag == trashName3){
            Destroy(other.gameObject);
            score.PlayerScore = score.PlayerScore - takePointAmount;    //Deduct the proper amount of points
        }
    }
    
}
