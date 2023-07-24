using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MertCan.FlappyBird.Player
{
    public class PlayerController : MonoBehaviour
    {
        public bool isDead;
        Rigidbody2D rigidbody;
        [SerializeField] private float jumpForce;
        // Start is called before the first frame update
        void Start()
        {
            rigidbody= GetComponentInChildren<Rigidbody2D>();
        }
        public void OnJump(InputValue jumpValue)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            if(isDead==true)
            {
                rigidbody.AddForce(Vector3.zero);
            }
        }
    }
}

