using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;

public class BirdController : MonoBehaviour
{
    [Header("Bird Settings")]
    [Range(1f, 10f)]
    public float jumpForce = 5f;
    
    private Rigidbody2D rb;

    private Animator m_Animator;
    
    public InputAction jumpAction;
    
    private bool m_jump;

    public TMP_Text gameOver;
    
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        m_jump = false;
        jumpAction = InputSystem.actions.FindAction("Jump");
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.currentGameState = GameManager.GameState.GameOver;
            Die();
        }
    }

    public void Die()
    {
        Time.timeScale = 0f;
        gameOver.gameObject.SetActive(true);

    }

    
    void Update()
    {
        if (GameManager.currentGameState == GameManager.GameState.Playing)
        {
            
            if (jumpAction.WasReleasedThisFrame())
            {
                m_jump = true;
                rb.linearVelocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            }
            else m_jump = false;

            if (m_jump == false)
            {
                m_Animator.SetBool("fly", false);
            }

            if (m_jump)
            {
                m_Animator.SetBool("fly", true);
            }
        }

    
    }
}
