using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text txt;
    public TargetRotation script;
    public float score;

    //I am updating the score counter in UI through this update method
    void Update()
    {
        score = script.score;
        txt.text = score.ToString("Score: " + score);
    }
}
