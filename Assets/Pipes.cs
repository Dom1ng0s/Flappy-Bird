using UnityEngine;
using UnityEngine.Rendering;

public class Pipes : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
