
using UnityEngine;

public class followBox : MonoBehaviour
{
    
    public Transform box;
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = box.position + offset;
    }
}
