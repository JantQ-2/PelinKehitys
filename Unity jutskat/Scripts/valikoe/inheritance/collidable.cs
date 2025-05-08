using Unity.VisualScripting;
using UnityEngine;

public class collidable : MonoBehaviour
{
    [SerializeField] BoxCollider BoxCollider;

    public virtual void Start()
    {
        
    }

    public virtual void OnCollide(Collider2D coll)
    {

    }
}
