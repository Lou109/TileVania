using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [Range(0f, 1f)][SerializeField] float volume = 0.2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position, volume);
            Destroy(gameObject);
        }    
    }
}
