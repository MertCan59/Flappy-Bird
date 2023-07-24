using MertCan.FlappyBird.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    public PlayerController player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("FlappyBird");
        }
    }
}
