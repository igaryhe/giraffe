using UnityEngine;

public class Grappler : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private DistanceJoint2D _distanceJoint;

    // hack
    private Rigidbody2D rbtest;

    // Start is called before the first frame update
    void Start()
    {
        _distanceJoint = GetComponent<DistanceJoint2D>();
        _lineRenderer = GetComponent<LineRenderer>();
        _distanceJoint.enabled = false;

        // hack
        rbtest = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _lineRenderer.SetPosition(0, mousePos);
            _lineRenderer.SetPosition(1, transform.position);
            _distanceJoint.connectedAnchor = mousePos;
            _distanceJoint.enabled = true;
            _lineRenderer.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _distanceJoint.enabled = false;
            _lineRenderer.enabled = false;
        }
        if (_distanceJoint.enabled) 
        {
            _lineRenderer.SetPosition(1, transform.position);
        }

        // hacky code to just get giraffe to get off ground for testing
        if (Input.GetKey(KeyCode.Mouse1))
        {
          rbtest.AddForce(Vector2.up*100);
        }
    }
}
