using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject childCube;
    public GameObject target;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        childCube.transform.position = transform.position + transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position);
    }
}
