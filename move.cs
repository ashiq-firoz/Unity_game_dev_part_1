using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{ 
    public Transform cam;
    void Update()
    {
        cam.position = this.transform.position;
        if(Input.GetKey(KeyCode.UpArrow)){
            this.transform.Translate(Vector3.forward*10*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            this.transform.Translate(Vector3.back*10*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            this.transform.Translate(Vector3.left*10*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            this.transform.Translate(Vector3.right*10*Time.deltaTime);            
        }
    }
}

