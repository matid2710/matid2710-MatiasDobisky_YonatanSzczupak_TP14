using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    private int score = 0;
    public int maxScore = 1; // cambiá este número según cuántos conos tengas
    private UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            score++;
            uiManager.UpdateScore(score);
            Destroy(other.gameObject);

            if (score >= maxScore)
            {
                uiManager.MostrarPantallaWin();
                Time.timeScale = 0;
            }
        }
    }
}