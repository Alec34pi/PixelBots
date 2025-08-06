using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float climbSpeed;
    public float jumpForce;

    [HideInInspector]
    public bool isJumping;
    [HideInInspector]
    public bool isGrounded;
    [HideInInspector]
    public bool isClimbing;

    [HideInInspector]
    public Transform GroundCheck;
    [HideInInspector]
    public float groundCheckRadius;
    [HideInInspector]
    public LayerMask collisionLayers;

    [HideInInspector]
    public Rigidbody2D rb;
    [HideInInspector]
    public Animator animator;
    [HideInInspector]
    public SpriteRenderer spriteRenderer;
    public CapsuleCollider2D playerCollider;

    private Vector3 velocity = Vector3.zero;
    private float horizontalMovement;
    private float verticalMovement;

    public static PlayerMovement instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plusieurs instance de PlayerMouvement dans la scène !");
            return;
        }

        instance = this;
    }


    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, groundCheckRadius, collisionLayers);

        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime;
        verticalMovement = Input.GetAxis("Vertical") * climbSpeed * Time.fixedDeltaTime;

        if(Input.GetButtonDown("Jump") && isGrounded && !isClimbing)
        {
            isJumping = true;
        }

        Flip(rb.linearVelocity.x);

        float characterVelocity = Mathf.Abs(rb.linearVelocity.x);
        animator.SetFloat("Speed", characterVelocity);
        animator.SetBool("IsClimbing", isClimbing);
    }

    void FixedUpdate()
    {
        MovePlayer(horizontalMovement, verticalMovement);
    }



    void MovePlayer(float _horizontalMovement, float _verticalMovement)
    {
        
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.linearVelocity.y);
        rb.linearVelocity = Vector3.SmoothDamp(rb.linearVelocity, targetVelocity, ref velocity, .05f);

        if(!isClimbing)
        {
            if(isJumping)
            {
                rb.AddForce(new Vector2(0f, jumpForce));
                isJumping = false;
            }
        }else
        {
            Vector3 targetVelocity2 = new Vector2(0, _verticalMovement);
            rb.linearVelocity = Vector3.SmoothDamp(rb.linearVelocity, targetVelocity2, ref velocity, .05f);
        }
    }

    void Flip(float _velocity)
    {
        if(_velocity > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if(_velocity < -0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(GroundCheck.position, groundCheckRadius);
    }
}
