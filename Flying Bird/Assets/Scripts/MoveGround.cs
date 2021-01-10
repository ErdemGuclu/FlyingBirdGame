using UnityEngine;

public class MoveGround : MonoBehaviour
{
    public float groundSpeed = -1f;

    void Update()
    {
        transform.Translate(groundSpeed * Time.deltaTime, 0, 0);
    }
}