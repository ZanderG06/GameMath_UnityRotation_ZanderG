using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject childCube;
    public GameObject orbit;
    public float speed = 1f;
    private float time;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        childCube.transform.position = transform.position + transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(orbit.transform.position - transform.position), time);
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
