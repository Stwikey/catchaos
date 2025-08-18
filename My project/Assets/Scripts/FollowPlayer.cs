using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private float depth = -5f;
    public Transform playerPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPos.transform.position + new Vector3 (0f, 0f, depth);
    }
}
