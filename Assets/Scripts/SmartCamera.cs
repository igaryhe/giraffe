using System.Collections;
using Cinemachine;
using UnityEngine;

public class SmartCamera : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam;
    [SerializeField] private float size;

    private float elapsedTime;
    private float lastTime = 1.5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("head"))
        {
            StartCoroutine(LerpFloat());
        }
    }

    private IEnumerator LerpFloat()
    {
        Debug.Log("hahahah");
        while (elapsedTime < lastTime)
        {
            cam.m_Lens.OrthographicSize = Mathf.Lerp(cam.m_Lens.OrthographicSize, size, elapsedTime / lastTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        elapsedTime = 0;
    }
}
