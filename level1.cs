using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour
{
    public GameObject canvas;
    public Text text;

    void Start(){
        PlayerPrefs.SetInt("count",0);
        Debug.Log(PlayerPrefs.GetInt("count"));
    }

    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag=="Player"){
            PlayerPrefs.SetInt("count",PlayerPrefs.GetInt("count")+1);
            Debug.Log("Player arrived");
            canvas.SetActive(true);
            text.text= ""+PlayerPrefs.GetInt("count")+"st";
        }
        if(collision.collider.tag=="enemy"){
            PlayerPrefs.SetInt("count",PlayerPrefs.GetInt("count")+1);
        }
        
    }

    public void next(){
        SceneManager.LoadScene("Home");
    }
}
