using UnityEngine;

public class Car : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private Vector2 dir;
    [SerializeField] private float speed;
    [SerializeField] private float upbound;
    [SerializeField] private float lowbound;
    
    

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var pos = transform.position;
        if (Mathf.Abs(pos.x) > upbound)
        {
            transform.position = new Vector3(lowbound, pos.y, pos.z);
        }
    }

    private void LateUpdate()
    {
        _rb.velocity = Vector2.Lerp(_rb.velocity, dir * speed, Time.deltaTime);
    }
}
