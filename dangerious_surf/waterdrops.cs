using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterdrops : MonoBehaviour
{
 CapsuleCollider2D surfboard;
 [SerializeField] ParticleSystem dropeffect;
    void Start()
    {
      surfboard=GetComponent<CapsuleCollider2D>();  
    }

  void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.tag=="ground")
    {
        dropeffect.Play();
    }

   }
    void OnCollisionExit2D(Collision2D other) {
    if(other.gameObject.tag=="ground")
    {
      dropeffect.Stop();  
    }        
   }
   
   
}
