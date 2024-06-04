using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
    }
    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }
}