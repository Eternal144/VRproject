using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Transform Player;
    public Text Scoretext;

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = "Scores:" + (Player.position.z+100).ToString("0");
        
    }
}
