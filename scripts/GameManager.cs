using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    public Text scoreText;
    [SerializeField] Player_Movement playerMovement;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        playerMovement.speed += playerMovement.playerMovementPerPoint;
    }
    private void Awake()
    {
        inst = this;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
