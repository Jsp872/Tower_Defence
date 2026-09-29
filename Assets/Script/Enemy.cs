using UnityEngine;

public class Enemy : MonoBehaviour
{
    public SO_EnemyData enemyData;
    IKillableEntity killableEntity;
    [SerializeField] EnemyPath enemyPath;
    [SerializeField] Pool pool;
    [SerializeField] EventManager eventManager;

    private void Start()
    {
        StartCoroutine(enemyPath.FollowPath(this));
    }
}
