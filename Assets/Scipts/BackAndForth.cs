using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed = 1f;
    public float amp = 3f;
    
    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * amp;
        transform.eulerAngles = new Vector3(0, offset, 0);
    }
}
