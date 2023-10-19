using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour

{
    float speed;
    GameObject player;
    GameObject targetLook;
    public float minSpeed = 0.05f;
    public float maxSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        targetLook = GameObject.FindGameObjectWithTag("TargetLook");

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
            if (player == null)
            {
                
                return;
            }
            speed = UnityEngine.Random.Range(minSpeed, maxSpeed);   
            transform.LookAt(targetLook.transform);
            transform.position = Vector3.Lerp(transform.position, player.transform.position, speed * Time.deltaTime);
        
    }
}
