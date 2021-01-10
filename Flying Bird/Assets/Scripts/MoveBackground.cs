using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float backgroundSpeed = -1f;

    void Update()
    {
        transform.Translate(backgroundSpeed * Time.deltaTime, 0, 0);
    }
}