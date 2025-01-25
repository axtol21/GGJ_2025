using Unity.VisualScripting;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    [field: SerializeField] public float playerHealth { get; set; } = 5.0f;
    [field: SerializeField] public float playerDamage { get; set; } = 1.0f;
    [field: SerializeField] public float maxTime { get; set; } = 20f;
    [field: SerializeField] public float addTime { private get; set; }
    [field: SerializeField] public float attackSpeed { get; set; } = 5f;
    [field: SerializeField] public bool canAttack { get; private set; } = true;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && canAttack)
        {
            canAttack = false;
            StartCoroutine(UpdateAttack());
        }

        Debug.Log(canAttack);

        if (playerHealth <= 0)
        {
            PlayerDead();
        }
    }

    void PlayerDead ()
    {
        Destroy(gameObject);
    }

    private IEnumerator UpdateAttack ()
    {
        Debug.Log("Here");
        yield return new WaitForSeconds(attackSpeed);
        canAttack = true; 
    }

}
