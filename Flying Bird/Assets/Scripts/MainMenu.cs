using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private Canvas scoreCanvas;

    private void Awake()
    {
        scoreCanvas.gameObject.SetActive(false);
        Time.timeScale = 0f;
        ActivateMenu();
    }

    public void StartFlying()
    {
        scoreCanvas.gameObject.SetActive(true);
        Time.timeScale = 1f;
        mainMenuUI.SetActive(false);
    }

    void ActivateMenu()
    {
        mainMenuUI.SetActive(true);
    }

    void DeactivateMenu()
    {
        Time.timeScale = 1f;
        mainMenuUI.SetActive(false);
    }
}
