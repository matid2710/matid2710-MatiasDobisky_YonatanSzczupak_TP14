using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 30f;
    private UIManager uiManager;
    private bool juegoTerminado = false;

    void Start()
   {
    Time.timeScale = 1;
    uiManager = FindObjectOfType<UIManager>();

    Debug.Log("Timer inicial: " + timer);

    uiManager.UpdateTimer(timer);
}

    void Update()
    {
        if (!juegoTerminado)
        {
            timer -= Time.deltaTime;

            if (timer < 0)
                timer = 0;

            uiManager.UpdateTimer(timer);

            if (timer <= 0)
            {
                juegoTerminado = true;
                uiManager.MostrarPantallaGameOver();
                Time.timeScale = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}