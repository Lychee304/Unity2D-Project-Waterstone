using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _health = _maxHealth;
    }


    public void TakeDamage(int amount)
    {
        _health -= 20;
        if(_health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
