using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour
{

    public GameObject tongueGO;
    public GameObject targetGO;

    public Transform mouth;

    public MousePosition mouse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0)) {
        print("hello!");

        targetGO.SetActive(true);
        tongueGO.SetActive(true);
        // use mouse position to set the transform of the target
	//
	
	Vector3 mouthPos = mouth.position;
	Vector3 targetPos = targetGO.transform.position;

        targetGO.transform.position = mouse.transform.position;


        // stretch the tongue so that it reaches from tip of head to
        // the target
	//
	// 
	Vector3 midpoint = (mouth.position + 
			    targetGO.transform.position) / 2;
	tongueGO.transform.position = midpoint;
			   
	
	// probably want position = midpoint(mouth, target)
	// and rotation = angle(mouth, target) or sometthing
	// and scale = distance(mouth, target)


      }

        
    }
}
