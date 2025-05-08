using UnityEngine;
public class GameOverDisplay : HealthManager1
{
    [SerializeField] private GameObject gameOverPanel;// Delegate -määritys
    public HealthManager1 healthManager1;
    private void Start()
    {
        // DisplayGameOver() -metodi suoritetaan kun tapahtuma käynnistyy
        healthManager1.onHealthChange += DisplayGameOver;

    }
    private void DisplayGameOver()
    {
        gameOverPanel.SetActive(true);
    }

}

