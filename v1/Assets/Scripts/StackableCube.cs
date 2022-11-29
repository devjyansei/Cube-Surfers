using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackableCube : MonoBehaviour
{
    public bool isCollected;
    int index;

    private void Start()
    {
        isCollected = false;
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

    }
    private void Update()
    {
        if (isCollected)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    
   
    public void SetIndex(int index)
    {
        this.index = index;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("gds");
            Collector.Instance.DecraseHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

        }
    }

}
