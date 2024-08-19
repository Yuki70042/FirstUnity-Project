using Unity.VisualScripting;
using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public GameObject objectToDestroy;
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.CompareTag("Player")) // Si l'objet "Joueur" entre en collision
        {
            Destroy(objectToDestroy); // On detruit la lsite d'object
        }
    }
}
