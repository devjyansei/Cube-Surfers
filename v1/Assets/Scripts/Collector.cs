using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public static Collector Instance;
    GameObject mainCube;
    public int height;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Stack") &&  other.gameObject.GetComponent<StackableCube>().isCollected == false)
        {
            height++;
            other.gameObject.GetComponent<StackableCube>().isCollected = true;
            other.gameObject.GetComponent<StackableCube>().SetIndex(height);

            other.gameObject.transform.parent = mainCube.transform;

        }
        
    }
    public void DecraseHeight()
    {
        height--;
    }
}
