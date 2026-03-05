using UnityEngine;
using UnityEngine.Rendering;

public class EnemyFollowCursor : MonoBehaviour
{

    private Vector3 Mouse;
    [SerializeField] private float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mouse = Camera.main.ScreenToWorldPoint(Mouse);
        transform.position = Vector2.Lerp(transform.position, Mouse, speed);
    }
}
