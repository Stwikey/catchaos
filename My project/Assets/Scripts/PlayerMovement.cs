using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Vector2 movement;
    private Rigidbody2D rb;
    public GameObject inv;
    private Animator anim;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Set(InputSys.Movement.x, InputSys.Movement.y);
        rb.linearVelocity = movement * speed;
        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            transform.localScale = new Vector3 (3.5f, 3.5f, 3.5f);
        }
        else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            transform.localScale = new Vector3(-3.5f, 3.5f, 3.5f);
        }
      
        AnimationChecker();




    }

    private void OnTriggerStay2D(Collider2D other) {
        if (Input.GetKeyDown(KeyCode.E) && other.gameObject.tag == "Item") {
            Debug.Log(other.gameObject.name);
            other.gameObject.SetActive(false);
            inv.GetComponent<InventorySystem>().AddToInventory(other.gameObject);

        }

    }

    public void AnimationChecker()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("isFacingBackward", true);
            anim.SetBool("isFacingForward", false);
            anim.SetBool("isFacingSide", false);

        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("isFacingBackward", true);
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isFacingBackward", false);

        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("isFacingBackward", false);
            anim.SetBool("isFacingForward", true);
            anim.SetBool("isFacingSide", false);

        }


        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("isFacingForward", true);
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isFacingForward", false);

        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("isFacingBackward", false);
            anim.SetBool("isFacingForward", false);
            anim.SetBool("isFacingSide", true);

        }


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isFacingSide", true);
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("isFacingSide", false);
            anim.SetBool("isWalking", false);
        }

        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)))
        {
            anim.SetBool("isFacingBackward", false);
            anim.SetBool("isFacingForward", false);
            anim.SetBool("isFacingSide", true);

        }
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            anim.SetBool("isFacingSide", true);
            anim.SetBool("isWalking", true);
        }

        if ((Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow)))
        {
            anim.SetBool("isFacingSide", false);
            anim.SetBool("isWalking", false);
        }
        
        



    }
}
