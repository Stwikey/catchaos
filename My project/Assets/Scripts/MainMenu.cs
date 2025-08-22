using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
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
    void OnMouseOver()
    {
        hover.SetActive(true);
    }

    void OnMouseExit()
    {
        hover.SetActive(false);
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}


