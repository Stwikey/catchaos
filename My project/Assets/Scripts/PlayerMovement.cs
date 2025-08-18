using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Vector2 movement; 
    private Rigidbody2D rb;
    public GameObject inv;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Set(InputSys.Movement.x, InputSys.Movement.y);
        rb.linearVelocity = movement*speed;
        
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (Input.GetKeyDown(KeyCode.E) && other.gameObject.tag == "Item"){
            Debug.Log(other.gameObject.name);
            other.gameObject.SetActive(false);
            inv.GetComponent<InventorySystem>().AddToInventory(other.gameObject);

        }

    }
}
