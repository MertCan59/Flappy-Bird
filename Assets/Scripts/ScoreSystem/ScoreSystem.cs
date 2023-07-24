using MertCan.FlappyBird.Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    private int score=0;
    [SerializeField] private TextMeshProUGUI text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Score"))
        {
            score++;
            text.text="Score: "+score.ToString();
            Destroy(collision.gameObject);
        }
    }
}

