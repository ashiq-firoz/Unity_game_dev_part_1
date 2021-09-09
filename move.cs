using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{ 
    // code to move a object in unity 3d using the arrow keys on the keyboard
    
    public Transform cam; //To link the transform(position data) with the script
    void Update()
    {
        cam.position = this.transform.position; //sets the position of cam to be equal to the position of the object(ball) to which the script is linked
        
        if(Input.GetKey(KeyCode.UpArrow)){ // checks if uparrow is pressed
            this.transform.Translate(Vector3.forward*10*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)){ // checks if downarrow is pressed
            this.transform.Translate(Vector3.back*10*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){ // checks if leftarrow is pressed
            this.transform.Translate(Vector3.left*10*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)){ // checks if rightarrow is pressed
            this.transform.Translate(Vector3.right*10*Time.deltaTime);            
        }
    }
}

