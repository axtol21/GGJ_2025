using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public static float playerHealth { get; set; } = 5.0f;
    [field: SerializeField] public static float playerDamage { get; set; } = 1.0f;
    [field: SerializeField] public static float maxTime { get; set; } = 20f;
    [field: SerializeField] public static float addTime { private get; set; }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
