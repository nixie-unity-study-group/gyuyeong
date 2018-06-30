using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualPilot : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }
    //Update is called once per frame
    private void Update() {
     if (Input.GetKey(KeyCode.UpArrow)) {
         Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
         Vector2 nextPosition = new Vector2(transform.position.x, 5);
         transform.position = Vector2.MoveTowards(currentPosition, nextPosition, 0.1f);	
	} else if (Input.GetKey(KeyCode.DownArrow)) {
       Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
       Vector2 nextPosition = new Vector2(transform.position.x, -5);
       transform.position = Vector2.MoveTowards(currentPosition, nextPosition, 0.1f);
    } else if (Input.GetKey(KeyCode.LeftArrow)) { 
        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
        Vector2 nextPosition = new Vector2(-5, transform.position.y);
        transform.position = Vector2.MoveTowards(currentPosition, nextPosition, 0.1f);
    } else if(Input.GetKey(KeyCode.RightArrow)) { 
        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
        Vector2 nextPosition = new Vector2(5,transform.position.y);
        transform.position = Vector2.MoveTowards(currentPosition, nextPosition, 0.1f);
         }
    }
  }
