using MertCan.FlappyBird.Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    private int score=0;
    [SerializeField] private TextMeshProUGUI text;
    PlayerController playerController;
   

    void Start()
    {
        StartCoroutine(scoreCount());
    }
    public IEnumerator scoreCount()
    {
       while (true)
        {
            score++;
            text.text = "Score: "+score.ToString();
            yield return new WaitForSeconds(1f);
            isItDead();
        }
    }
    public void isItDead()
    {
        if (playerController.isDead) 
        {
            score = 0;
            text.text= "Score: " + score.ToString();
        }
    }
}
