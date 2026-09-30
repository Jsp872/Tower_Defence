using UnityEngine;

public class Enemy : MonoBehaviour
{
    public SO_EnemyData enemyData;
    IKillableEntity killableEntity;
    [SerializeField] EnemyPath enemyPath;
    [SerializeField] Pool pool;
    [SerializeField] EventManager eventManager;

    private float health;

    private void Start()
    {
        health = enemyData.hp;
        StartCoroutine(enemyPath.FollowPath(this));
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
