using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemyattac : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem blooeffect;
    void OnTriggerEnter2D(Collider2D other) {
    if(other.tag=="Player")
    {
       Invoke("ReloadScene",0.8f);
       blooeffect.Play();
    }  }
    // Update is called once per frame
    void ReloadScene(){
        SceneManager.LoadScene(0); 
    }
}
