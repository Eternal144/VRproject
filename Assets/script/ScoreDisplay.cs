using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
   public Rigidbody rb;
    public Transform Player;
    public Text Scoretext;
    public Text overNofify;
    public Text overText;
    private double finalScore;


    private void Start()
    {
        overNofify.gameObject.SetActive(false);
        overText.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

        if (rb.name == "over")
        {
            Scoretext.text = "scores:" + finalScore.ToString("0");
            overNofify.gameObject.SetActive(true);
            overText.gameObject.SetActive(true);
            Debug.Log("i am here ");
            overNofify.text = "Game Over!";
            overText.text = "您的得分：" +  finalScore.ToString("0");
        }
        else
        {
            finalScore = Player.position.z + 100;
            Scoretext.text = "scores:" + finalScore.ToString("0");

        }

    }
    private void FixedUpdate()
    {

    }

}
