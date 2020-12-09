using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float upperBound;
    [SerializeField] private float lowerBound;

    private void Update()
    {
        var pos = transform.position;
        transform.position += Vector3.right * (Time.deltaTime * speed);
        if (Mathf.Abs(pos.x) > upperBound)
        {
            transform.position = new Vector3(lowerBound, pos.y, pos.z);
        }
    }
}