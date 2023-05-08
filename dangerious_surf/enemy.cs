using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : controller      
{
   //oncelikle 2 nokta belirledik, dusman bu 2 nokta(p1, p2) arasinda gidip gelicek
   [SerializeField]
    private Transform[] spots;   //spots nokta anlaminda, 2 tane oldugu icin [] koyduk.
    void Start()
    {
        facingRight= true;  
        
    }

   
    void Update()
    {
   

    if(facingRight) //eger saga donmusse
    {
        transform.position=Vector2.MoveTowards(transform.position, spots[1].position, speed*Time.deltaTime);
    

        if(Vector2.Distance(transform.position, spots[1].position)<.5f) //ilk nokta ve hedef nokta arasindaki mesafe.
        
        {
            facingRight=false; 
        }
    }
    else   
    {          
    transform.position=Vector2.MoveTowards(transform.position, spots[0].position, speed*Time.deltaTime);
       
       if(Vector2.Distance(transform.position, spots[0].position)<.5f)
       {
        facingRight= true;
       }
    }

  

    }
}
