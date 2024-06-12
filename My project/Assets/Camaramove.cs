using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaramove : MonoBehaviour
{
    Transform PlayerTransform;
    Vector3 Offset;


     void Awake()
    {
    PlayerTransform= GameObject.FindGameObjectWithTag("Player").transform;    
        Offset= transform.position - PlayerTransform.position;

    
    }
    // Start is called before the first frame update
    void LateUpdate()
    {
        transform.position = PlayerTransform.position + Offset;
    }

   


      }
