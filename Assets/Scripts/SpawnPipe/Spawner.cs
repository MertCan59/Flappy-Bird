using MertCan.FlappyBird.Player;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public GameObject pipes;
    public PlayerController player;
    public float height;

    private void Start()
    {
        StartCoroutine(SpawnObject());
        
    }

    public IEnumerator SpawnObject()
    {
        while (!player.isDead)
        {
           Instantiate(pipes, new Vector3(9f,Random.Range(-height, height), 0),Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
        
    }
}
