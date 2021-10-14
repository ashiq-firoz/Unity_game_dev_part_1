using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{ 
    // code to move a object in unity 3d using the arrow keys on the keyboard
    
    public Transform cam; //To link the transform(position data) with the script
    pubic float speed = 10 ; // Set speed 10 as a variable 
    void Update()
    {
        cam.position = this.transform.position; //sets the position of cam to be equal to the position of the object(ball) to which the script is linked
        
        if(Input.GetKey(KeyCode.UpArrow)){ // checks if uparrow is pressed
            this.transform.Translate(Vector3.forward*speed*Time.deltaTime);      // Change 10 to speed for the below code
        }
        if(Input.GetKey(KeyCode.DownArrow)){ // checks if downarrow is pressed
            this.transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){ // checks if leftarrow is pressed
           //this.transform.Translate(Vector3.left*speed*Time.deltaTime);
           
           this.transform.Rotate(-Vector3.up*38*Time.deltaTime);   // rotate camera and object
           cam.Rotate(-Vector3.up*38*Time.deltaTime);
            
        }
        if(Input.GetKey(KeyCode.RightArrow)){ // checks if rightarrow is pressed
            //this.transform.Translate(Vector3.right*speed*Time.deltaTime);   
            
            this.transform.Rotate(Vector3.up*38*Time.deltaTime);
            cam.Rotate(Vector3.up*38*Time.deltaTime);
        }
    }
}
