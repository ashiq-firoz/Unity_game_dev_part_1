using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel_rotate : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            this.transform.Rotate(-Vector3.up*500*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            this.transform.Rotate(Vector3.up*500*Time.deltaTime);
        }
    }
}
