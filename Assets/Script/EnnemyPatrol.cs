using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    public SpriteRenderer graphics;
    private Transform target;
    private int destPoint = 0;

    void Start() // Au lancement, le point suivis est le numero 0 de la liste (soit le premier)
    {
        target = waypoints[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position; // Calcul du vecteur
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World); // Effectue le deplacement

        // Si l'ennemi est quasiment arrivé à sa destination
        if(Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length; // le modulo permet de toujours suivre un point existant (reset a 0 une fois le dernier atteint)
            target = waypoints[destPoint]; // on change le point suivis
            graphics.flipX = !graphics.flipX; // On inverse lorsqu'on touche le point.
        }
    }
}