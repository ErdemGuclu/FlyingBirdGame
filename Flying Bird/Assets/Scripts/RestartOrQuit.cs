using UnityEngine;

public class RestartOrQuit : MonoBehaviour
{
    [SerializeField] private GameObject restartMenuUI;
    public AudioSource birdDie;
    AudioListener listener;

    void OnCollisionEnter2D(Collision2D other)
    {
        Time.timeScale = 0f;
        restartMenuUI.SetActive(true);
        birdDie.Play(0);
    }
}
