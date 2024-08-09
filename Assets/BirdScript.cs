using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D rigidbody;
    [SerializeField]    
    private float velocity;
    [SerializeField]
    private LogicScript logic;

    private bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        birdIsAlive=true;
        gameObject.name = "Birbie";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&birdIsAlive)
        {
            rigidbody.velocity = Vector2.up * velocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
