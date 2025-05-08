using UnityEngine;

public class HealthManager1 : MonoBehaviour
{

    public static HealthManager1 Instance { get; set; }
    [SerializeField] private float hp = 100;
    
    public delegate void OnHealthChange();// Delegate -muuttujan m‰‰ritys
    public OnHealthChange onHealthChange;
    private void Awake()
    {
        // Singelton
        Instance = this;
    }
    private void Start()
    {

        // Deat() -metodi suoritetaan kun tapahtuma k‰ynnistyy
        onHealthChange += Death;
    }

    // V‰hent‰‰ terveytt‰
    public void TakeDamage(float amount)
    {
        hp -= amount;
        if (hp < 0)
        {
            print("Pelaaja kuoli!");
            // Tapahtuma k‰ynnistyy
            onHealthChange?.Invoke();
        }
    }
    // Metodi suoritetaan kun tapahtuma k‰ynnistyy
    private void Death()
    {
        // Tuhoa pelaaja
        Destroy(gameObject);
    }
    // Metodi suoritetaan kun tapahtuma k‰ynnistyy
    
} 