using UnityEngine;

public class Bubble : MonoBehaviour
{
    // Placeholders
    public Rigidbody2D rb;
    public int size = 1;
    public int health = 1;
    [SerializeField] private new Collider2D collider;
    [SerializeField] private new SpriteRenderer renderer;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Bubble Here!");

        this.transform.localScale = new Vector3(size, size, 1);

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown ()
    {
        Debug.Log("Clicked!!");
        health--;
    }
}
