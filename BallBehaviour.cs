using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private Vector3 _velocity;
    [SerializeField] private ScoreEvent onScore;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x + _velocity.x * Time.deltaTime, 
            transform.position.y,
            transform.position.z + _velocity.z * Time.deltaTime);
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Horizontal"))
        {
            _velocity = new Vector3(_velocity.x, _velocity.y,-_velocity.z); 
        }
        else if (collision.gameObject.tag.Equals("Paddle 1 goal"))
        {
            onScore.Invoke(2); 
        }
        else if (collision.gameObject.tag.Equals("Paddle 2 goal"))
        {
            onScore.Invoke(1);

        }
        else
        {
            _velocity = new Vector3(-_velocity.x, _velocity.y, _velocity.z);    

        }
    }

     
}
