using UnityEngine;

public class Bullet : MonoBehaviour
{
    IKillableEntity killableEntity;
    IPoolableObject poolableObject;

    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            enemy.TakeDamage(damage);
            //killableEntity = collision.GetComponent<IKillableEntity>();
            //if (killableEntity != null)
            //{
            //    killableEntity.TakeDamage(1);
            //    poolableObject = GetComponent<IPoolableObject>();
            //    if (poolableObject != null)
            //    {
            //        poolableObject.ReturnToPool();
            //    }
            //    else
            //    {
            //        Destroy(gameObject);
            //    }
            //}
        }
    }
}
