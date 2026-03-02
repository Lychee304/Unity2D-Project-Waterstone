using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private PlayerHealth _playerHealth;
    private int _damage = 20;
    void Start()
    {

    }
    
    void Update()
    {

    }

    // void da warrenty hahaaa gottem

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerHealth.TakeDamage(_damage);
        }
    }
}
