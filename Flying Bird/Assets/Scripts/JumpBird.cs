using UnityEngine;

public class JumpBird : MonoBehaviour
{
    public bool isDead;
    public Rigidbody2D bird;
    public float jumpSpeed = 5f;
    public GameManager scoreBoard;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            bird.velocity = Vector2.up * jumpSpeed;
    }

    /*private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Score")
        {
            scoreBoard.UpdateScore();
        }
    }*/

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Score")
        {
            scoreBoard.UpdateScore();
        }
    }
}
