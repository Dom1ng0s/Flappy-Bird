using UnityEngine;

public class Bird2 : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;
    public GameObject GameOver;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        GameOver.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.linearVelocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
