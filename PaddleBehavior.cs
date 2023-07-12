using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    [SerializeField] private Transform tf;
    [SerializeField] private float step_size =1f;
    [SerializeField] private KeyCode upKey = KeyCode.UpArrow;
    [SerializeField] private KeyCode downKey = KeyCode.DownArrow;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            tf.transform.position = new Vector3(tf.transform.position.x, tf.transform.position.y,
                tf.transform.position.z + step_size * Time.deltaTime);
        }
        else if (Input.GetKey(downKey))
        {
            tf.transform.position = new Vector3(tf.transform.position.x, tf.transform.position.y,
                tf.transform.position.z - step_size * Time.deltaTime);
        }
    }
}
