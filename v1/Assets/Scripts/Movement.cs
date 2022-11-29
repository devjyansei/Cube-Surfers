using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float slideSpeed;


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")*slideSpeed*Time.deltaTime;
        transform.Translate(horizontal, 0, speed * Time.deltaTime);
    }
}
