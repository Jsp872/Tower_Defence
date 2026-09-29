using UnityEngine;

public class Enemy : MonoBehaviour
{
    SO_EnemyData enemyData;
    IKillableEntity killableEntity;
    EnemyPath enemyPath;
    Pool pool;
    EventManager eventManager;
}
