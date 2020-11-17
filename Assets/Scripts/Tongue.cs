using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour
{

    public MousePosition mouse;

    SpringJoint2D sj;
    LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
      sj = GetComponent<SpringJoint2D>();
      line = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0)) {
        print("hello!");

        transform.position = mouse.transform.position;

      }



      print("mouth: " + sj.connectedBody.transform.position);
      print("end: " + sj.connectedBody.transform.position);

      line.SetPosition(0, sj.connectedBody.transform.position);
      line.SetPosition(1, transform.position);

      // draw red line for tongue (for now)
      // get mouth position
      //

        
    }
}
