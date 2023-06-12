using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{

    int score;

    public void AddPoint()
    {
        // increase a score
        score++;
        var text = GetComponent<TMP_Text>();
        text.SetText(score.ToString()); // convert our number into some text 
        
    }
}
