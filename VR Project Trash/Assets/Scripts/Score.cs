using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScoreObject")]
public class Score : ScriptableObject
{
    //This class allows us to create a Scriptable Object called "Score"
    //Score objects contain a "PlayerScore", and can be manipulated through
    //other scripts that reference the Score object.



    public int PlayerScore;
}