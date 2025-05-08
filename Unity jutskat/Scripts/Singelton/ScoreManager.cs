using UnityEngine;

namespace SingeltonScore
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager Instance { get; set; } //Ominaisuus

        public int score;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Debug.LogError("Pelissä on liikaa GameManager objekteja");
                Destroy(gameObject);
                //return;
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

    }

}