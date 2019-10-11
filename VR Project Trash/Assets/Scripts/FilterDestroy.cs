using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterDestroy : MonoBehaviour
{
    public Score score;             //The Score object
    public int addPointAmount;      //The amount of points to add when player is correct
    public int takePointAmount;     //The amount of points to deduct when player is incorrect

    public string tagName;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == tagName)
        {
            Destroy(other.gameObject);
            score.PlayerScore = score.PlayerScore + addPointAmount; //Add the proper amount of points
        }
        else
        {
            Destroy(other.gameObject);
            score.PlayerScore = score.PlayerScore - takePointAmount;    //Deduct the proper amount of points
        }
    }
}
