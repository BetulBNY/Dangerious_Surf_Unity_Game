using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class crash : MonoBehaviour
{
   CircleCollider2D playerHead;
   [SerializeField] ParticleSystem dropeffect;
    void Start()
    {
       playerHead=GetComponent<CircleCollider2D>(); 
    }

    void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.tag=="ground" && playerHead.IsTouching(other.collider)){
    
      dropeffect.Play();
      FindObjectOfType<player_movement>().DisableControls();
     Invoke("ReloadScene",2f);
    }
   }

   void ReloadScene(){
       SceneManager.LoadScene(0);
   }
}
