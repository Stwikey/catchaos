using UnityEngine;
using UnityEngine.SceneManagement;
public class House : MonoBehaviour
{
    public int catCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (catCount == 8)
        {
            SceneManager.LoadScene("EndScene");
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
    }
}
