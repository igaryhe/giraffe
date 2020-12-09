using UnityEngine;

public class Giraffe : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 9)
        {
            AudioManager.Instance.PlayCollide();
        }
    }
}
