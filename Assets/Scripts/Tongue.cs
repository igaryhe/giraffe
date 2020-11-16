using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour
{

    public GameObject tongueGO;
    public GameObject targetGO;

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
        // use mouse position to set the transform of the target

        targetGO.transform.position = mouse.transform.position;

        tongueGO.SetActive(true);

        // stretch the tongue so that it reaches from tip of head to
        // the target


      }

        
    }
}
