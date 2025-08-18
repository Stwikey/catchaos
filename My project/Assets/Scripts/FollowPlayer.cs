using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private float depth = -5f;
    [SerializeField] private float Xaxis = 0;
    [SerializeField] private float Yaxis = 0;

    public Transform playerPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPos.transform.position + new Vector3 (Xaxis, Yaxis, depth);
    }
}
