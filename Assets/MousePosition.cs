using UnityEngine;

public class MousePosition : MonoBehaviour
{
    public Transform connectedTransform;
    
    private void Update()
    {
        Vector2 mousePositionInScreen = Input.mousePosition;
		
        //clamp the mouse position so it's limited to the window bounds
        mousePositionInScreen.x = Mathf.Clamp(mousePositionInScreen.x,0f,Camera.main.pixelWidth);
        mousePositionInScreen.y = Mathf.Clamp(mousePositionInScreen.y,0f,Camera.main.pixelHeight);

        //now translate this position to world coordinates
        var mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionInScreen);

        //move the mouse target to the mouse position
        transform.position = mousePositionInWorld;
    }
    
    void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position,  connectedTransform.position);
    }
}
