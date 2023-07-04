using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    public float speed = 10f;
    [SerializeField] private Rigidbody rb;
    bool alive = true;
    float horizontalInput;
    float horizontalMultiplier = 1.7f;
    public float playerMovementPerPoint = 0.1f;
    private void FixedUpdate()
    {
        if(!alive)
        {
            return;
        }
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput* speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.y < -5)
        {
            Die();
        }
    }
    public void Die()
    {
        alive = false;
        Invoke("Restart", 2);
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
