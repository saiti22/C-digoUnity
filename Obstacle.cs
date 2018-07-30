using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public float speed = 1f;   

    // Update is called once per frame
    void Update () {
        // Movimento do obstáculo
        transform.Translate(Vector2.down * speed * Time.deltaTime);

	}

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.CompareTag("LimitBottom") || collision.transform.CompareTag("Player")) {            
            Destroy(gameObject);            
        }
    }
}
