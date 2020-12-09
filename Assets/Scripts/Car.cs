using UnityEngine;

public class Car : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private Vector2 dir;
    [SerializeField] private float speed;
    [SerializeField] private float upperBound;
    [SerializeField] private float lowerBound;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var pos = transform.position;
        if (pos.x > upperBound)
        {
            transform.position = new Vector3(lowerBound, pos.y, pos.z);
        } else if (pos.x < lowerBound)
        {
            transform.position = new Vector3(upperBound, pos.y, pos.z);
        }
    }

    private void LateUpdate()
    {
        _rb.velocity = Vector2.Lerp(_rb.velocity, dir * speed, Time.deltaTime);
    }
}
