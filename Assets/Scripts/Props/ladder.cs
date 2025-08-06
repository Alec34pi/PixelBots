using UnityEngine;

public class ladder : MonoBehaviour
{
    private bool isInRange;

    private PlayerMovement playerMovement;
    [HideInInspector]
    public new BoxCollider2D collider;


    void Awake()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if(isInRange && (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow)))
       {
        playerMovement.isClimbing = true;
        collider.isTrigger = true;
       }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isInRange = false;
            playerMovement.isClimbing = false;
            collider.isTrigger = false;
        }
    }
}
