using UnityEngine;
using Singelton;
using UnityEngine.PlayerLoop;

public class TestiController : MonoBehaviour
{
    private void Update()
    {
        print(GameManager.Instance);
    }
   
    
}
