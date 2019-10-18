using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public TextMesh Score;
    public Score s;

    // Update is called once per frame
    void FixedUpdate()
    {
        Score.text = "Score: " + s.PlayerScore;
    }
}
