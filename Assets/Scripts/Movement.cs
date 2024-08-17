using UnityEngine;
using Random = UnityEngine.Random;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float movementSpeed = 0.01f;
    [SerializeField] private KeyCode keyUp = KeyCode.W;
    [SerializeField] private KeyCode keyDown = KeyCode.S;
    [SerializeField] private KeyCode keyLeft = KeyCode.A;
    [SerializeField] private KeyCode keyRight = KeyCode.D;
    
    [Header("Rotate")]
    [SerializeField] private KeyCode keyRotateRight = KeyCode.E;
    [SerializeField] private KeyCode keyRotateLeft = KeyCode.Q;
    
    [Header("Colors")]
    [SerializeField] private KeyCode keyChangeColor = KeyCode.R;
    
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (GameManager.IsGamePaused) return;
        
        Vector3 pos = transform.position;
        
        if (Input.GetKey(keyUp))
        {
            pos.y += movementSpeed;
        }
        
        if (Input.GetKey(keyRight))
        {
            pos.x += movementSpeed;
        }
        
        if (Input.GetKey(keyDown))
        {
            pos.y -= movementSpeed;
        }
        
        if (Input.GetKey(keyLeft))
        {
            pos.x -= movementSpeed;
        }
        
        if (Input.GetKeyDown(keyRotateRight))
        {
            transform.Rotate(Vector3.back, 10);
        }
        
        if (Input.GetKeyDown(keyRotateLeft))
        {
            transform.Rotate(Vector3.forward, 10);
        }

        if (Input.GetKeyUp(keyChangeColor))
        {
            spriteRenderer.color = new Color(
                Random.Range(0f, 1f), 
                Random.Range(0f, 1f), 
                Random.Range(0f, 1f)
            );
        }
        
        transform.position = pos;
    }

    public void SetMovementSpeed(float speed)
    {
        if (speed is < 0.01f or > 1) return;

        movementSpeed = speed;
    }
}
