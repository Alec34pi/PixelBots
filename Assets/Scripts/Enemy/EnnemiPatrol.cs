using UnityEngine;

public class EnnemiPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    public int damageOnCollision = 20;

    [HideInInspector]
    public SpriteRenderer graphics;
    [HideInInspector]
    public BoxCollider2D damageCollider;
    [HideInInspector]
    public BoxCollider2D weakSpotCollider;

    private Transform target;
    private int destPoint;

    void Start()
    {
        target = waypoints[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];

            // Change la direction et retourne les colliders
            graphics.flipX = !graphics.flipX;
            FlipAllColliders();
        }
    }

    private void FlipAllColliders()
    {
        FlipCollider(damageCollider);
        FlipChildColliders();
    }

    private void FlipChildColliders()
    {
        // Flip le weakSpotCollider
        if (weakSpotCollider != null)
        {
            Vector3 localPos = weakSpotCollider.transform.localPosition;
            localPos.x *= -1; // Inverse uniquement l'axe X
            weakSpotCollider.transform.localPosition = localPos;
        }
    }



    private void FlipCollider(BoxCollider2D collider)
    {
        if (collider != null)
        {
            // Inverse l'offset horizontal
            Vector2 offset = collider.offset;
            offset.x *= -1;
            collider.offset = offset;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damageOnCollision);
        }
    }
}
