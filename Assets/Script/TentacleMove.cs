using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleMove : MonoBehaviour
{
    private float startY;
    private float moveTentacle = 6f;
    private float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = startY + Mathf.PingPong(Time.time * moveSpeed, moveTentacle);
        transform.position = new Vector2(transform.position.x, moveY);
    }
}
