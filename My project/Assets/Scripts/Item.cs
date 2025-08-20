using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject hover;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            hover.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        hover.SetActive(false);
    }
}
