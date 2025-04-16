using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int currentSpriteIndex = 0;

    private Vector3 direction;
    public float gravity = -9.8f;
    public float jumpForce = 5f;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;

        direction = Vector3.zero;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * jumpForce;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * jumpForce;
            }
        }


        // because gravity is m^2 we multiply it by deltaTime twice
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private void AnimateSprite()
    {
        currentSpriteIndex++;
        if (currentSpriteIndex >= sprites.Length)
        {
            currentSpriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[currentSpriteIndex];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            // Costly function
            FindAnyObjectByType<GameManager>().GameOver();
        }
        else if (collision.CompareTag("Scoring"))
        {
            FindAnyObjectByType<GameManager>().IncreaseScore();
        }
    }
}
