using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public float speed = 3f;
    public float moveDistance = 3f;

    private float targetX;

    void Start()
    {
        PickRandomTarget();
    }

    void Update()
    {
        // Move toward the target
        Vector3 targetPos = new Vector3(targetX, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // When reached, pick a new random position
        if (Mathf.Abs(transform.position.x - targetX) < 0.1f)
        {
            PickRandomTarget();
        }
    }

    void PickRandomTarget()
    {
        targetX = transform.position.x + Random.Range(-moveDistance, moveDistance);
    }
}
