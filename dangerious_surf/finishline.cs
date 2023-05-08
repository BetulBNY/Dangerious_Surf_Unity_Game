using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finishline : MonoBehaviour
{
   [SerializeField] ParticleSystem finishEffect;
   void OnTriggerEnter2D(Collider2D other) {
    if(other.tag=="Player"){
     finishEffect.Play();
      Invoke("ReloadScene",2f);
       
    }
   
   }
   
   void ReloadScene()
   {
      SceneManager.LoadScene(0);
   } 
}
