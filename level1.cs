using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1 : MonoBehaviour
{
    void Start(){
        PlayerPrefs.SetInt("final_count",0);   //PlayerPrefs database in unity
        Debug.Log(PlayerPrefs.GetInt("final_count"));  //to print the value in the database on the console in unity editor
    }
    void OnCollisionEnter(Collision collision){
        PlayerPrefs.SetInt("final_count",PlayerPrefs.GetInt("final_count")+1);  //Incrementing value of final_count when an object enters the final point.
        Debug.Log(PlayerPrefs.GetInt("final_count"));    //to print the value in the database on the console in unity editor
   }
}
