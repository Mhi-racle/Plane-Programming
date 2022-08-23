using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
  

    // Update is called once per frame
    void FixedUpdate()
    {
         transform.Rotate(0,0,90f);
    }
}
