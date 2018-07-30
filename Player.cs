using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Vector2 targetPos;    

    public float Xincrement = 1.6f;
    public float sideSpeed = 100f;
    public float maxX = 1.6f;
    public float minX = -1.6f;

    public bool isAlive = true;

    // Update is called once per frame
    void Update () {
        // Identifica toque na tela e define o movimento do jogador
        Touch touch = Input.GetTouch(0);        

        if(touch.position.x > Screen.width/2 && touch.phase == TouchPhase.Began && transform.position.x < maxX) {
            targetPos = new Vector2(transform.position.x + Xincrement, -3.5f);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, sideSpeed * Time.deltaTime);
        }
        else if(touch.position.x < Screen.width/2 && touch.phase == TouchPhase.Began && transform.position.x > minX) {
            targetPos = new Vector2(transform.position.x - Xincrement, -3.5f);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, sideSpeed * Time.deltaTime);
        }        
	}

    
}
