using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class move : MonoBehaviour
{
    public Transform cam;
    public float max_speed = 10; 
    float speed = 10;

    void Start(){
         PlayerPrefs.SetFloat("speed",0);
         
    }
    void Update()
    {   
        cam.position = this.transform.position;
        
        speed = PlayerPrefs.GetFloat("speed");

        if(speed>max_speed){
            speed=max_speed;
        }
        if(speed<0){
            speed=0;
        }

        this.transform.Translate(Vector3.forward*speed*Time.deltaTime);
        PlayerPrefs.SetFloat("speed",speed-2);

        if(Input.GetKey(KeyCode.UpArrow)){ // checks if uparrow is pressed
            this.transform.Translate(Vector3.forward*speed*Time.deltaTime);
            PlayerPrefs.SetFloat("speed",speed+3);
        }
        if(Input.GetKey(KeyCode.DownArrow)){ // checks if downarrow is pressed
            this.transform.Translate(Vector3.back*20*Time.deltaTime);
            //PlayerPrefs.SetFloat("speed",speed);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){ // checks if leftarrow is pressed
            //this.transform.Translate(Vector3.left*10*Time.deltaTime);
            this.transform.Rotate(-Vector3.up*38*Time.deltaTime);
            cam.Rotate(-Vector3.up*38*Time.deltaTime);
           
        }
        if(Input.GetKey(KeyCode.RightArrow)){ // checks if rightarrow is pressed
            //this.transform.Translate(Vector3.right*10*Time.deltaTime); 
            this.transform.Rotate(Vector3.up*38*Time.deltaTime);
            cam.Rotate(Vector3.up*38*Time.deltaTime);
                
        }
        
        
    }

    
}
