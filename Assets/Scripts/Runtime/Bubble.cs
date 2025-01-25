using System;
using System.Collections;
using System.IO;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    // Placeholders
    public Rigidbody2D rb;
    public float size = 1.0f;
    public float health = 1.0f;
    public float time = 1.0f;
    [SerializeField] private new Collider2D collider;
    [SerializeField] private new SpriteRenderer renderer;
    [SerializeField] private GameObject playerPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Player player = playerPrefab.GetComponent<Player>();

        this.transform.localScale = new Vector3(size, size, 1);

        StartCoroutine(TimeToPOP());

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }


    }

    private IEnumerator TimeToPOP()
    {
        yield return new WaitForSeconds(time);
        Player.playerHealth = Player.playerHealth - 1;
        Destroy(gameObject);
    }

    void OnMouseDown ()
    {
        ApplyDamage(1);
    }

    protected virtual void ApplyDamage (float player_damage)
    {
        health -= player_damage;
    }
}
