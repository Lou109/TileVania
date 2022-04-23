using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxTest : MonoBehaviour
{
    [SerializeField] Transform cam;
    [SerializeField] float relativeMove = .3f;


    void Update()
    {
        transform.position = new Vector2
       (cam.position.x * relativeMove, cam.position.y * relativeMove);
    }
}
