using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    private UIManager uiManager;
    private bool juegoTerminado = false;

    void Start()
    {
        Time.timeScale = 1;
        uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (timer > 0 && !juegoTerminado)
        {
            timer -= Time.deltaTime;
            uiManager.UpdateTimer(timer);
        }
        else if (timer <= 0 && !juegoTerminado)
        {
            juegoTerminado = true;
            uiManager.MostrarPantallaGameOver();
            Time.timeScale = 0;
        }

        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}