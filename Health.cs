using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    private Player player;
    private GameObject Batery;
    private SpriteRenderer bateryStatus;

    public int charges;
    public int maxCharges = 3;

    public Sprite[] chargesInBatery;
    public Sprite charge;

    private void Start() {
        player = GetComponent<Player>();
        Batery = GameObject.Find("BateryStatus");
        bateryStatus = Batery.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {
        // Verifica a vida do jogador e atualiza na tela
        for (int i = 0; i < chargesInBatery.Length; i++) {
            if(charges == i) {
                bateryStatus.sprite = chargesInBatery[i];
            }            
        }
    }

    // Perde vida ao tocar em um obstáculo
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.CompareTag("Obstacle")) {
            charges -= 1;
            if (charges <= 0) {
                player.isAlive = false;
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
