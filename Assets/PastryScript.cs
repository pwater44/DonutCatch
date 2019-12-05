using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastryScript : MonoBehaviour
{
    [SerializeField] AudioClip BaRing;
    [SerializeField] AudioClip missSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Entered");
        if (collision.gameObject.tag.Equals("Player"))
        {
            AudioSource.PlayClipAtPoint(BaRing, transform.position);
            GameManager.gm.incrementScore();

            print("Enteredy");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag.Equals("Boundary")) {
            AudioSource.PlayClipAtPoint(missSound, transform.position);
            GameManager.gm.decreaseLives();
            Destroy(gameObject);
        }
    }
}

