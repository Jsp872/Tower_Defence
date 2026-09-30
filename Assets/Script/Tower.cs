using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] SO_TowerData towerData;
    [SerializeField] Bullet bullet;
    [SerializeField] Pool pool;
    [SerializeField] Enemy targetEnemy;
    [SerializeField] private List<Enemy> enemies;

    [SerializeField] float range;
    [SerializeField] CircleCollider2D rangeCollider;

    private void Start()
    {
        rangeCollider.radius = range;
        StartCoroutine(Shoot());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy && !enemies.Contains(enemy))
            {
                enemies.Add(enemy);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy && enemies.Contains(enemy))
            {
                enemies.Remove(enemy);
            }
        }
    }

    private IEnumerator Shoot()
    {
        while (true)
        {
            if (enemies.Count != 0)
            {
                targetEnemy = enemies[0];
                if (targetEnemy != null)
                {
                    targetEnemy.TakeDamage(towerData.damage);
                }
            }
            yield return new WaitForSeconds(towerData.shotCooldown);
        }
    }
}
