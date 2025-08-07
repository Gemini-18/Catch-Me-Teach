using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 2f;
    public float resetX = -20f;
    public float startX = 20f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= resetX)
        {
            transform.position = new Vector2(startX, transform.position.y);
        }
    }
}
