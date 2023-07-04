using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Player_Movement playerMovement;
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<Player_Movement>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            playerMovement.Die();
        }
    }

    void Update()
    {
        
    }
}
