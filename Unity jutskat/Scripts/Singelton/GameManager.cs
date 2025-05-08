using UnityEngine;

namespace Singelton
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; set; } //Ominaisuus

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