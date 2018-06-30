using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPilot : MonoBehaviour {
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update() {
        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
        Vector2 nextPosition = getNextPosition();
        transform.position = Vector2.MoveTowards(currentPosition, nextPosition, 0.1f);

    }


    Vector2 getNextPosition() { 
            Vector2 pos = new Vector2(transform.position.x, transform.position.y);
            if (Input.GetKey(KeyCode.UpArrow)) {
               pos = new Vector2(transform.position.x, 5);
            } else if (Input.GetKey(KeyCode.DownArrow)) {
               pos = new Vector2(transform.position.x, -5);
            } else if (Input.GetKey(KeyCode.LeftArrow)) {
               pos = new Vector2(-5, transform.position.y);
            } else if (Input.GetKey(KeyCode.RightArrow)) {
               pos = new Vector2(5, transform.position.y);
           
         } 

            return pos;      
        
     }	
	}




  
