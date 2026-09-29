using UnityEngine;

[CreateAssetMenu(fileName = "SO_TowerData", menuName = "Scriptable Objects/SO_TowerData")]
public class SO_TowerData : ScriptableObject
{
    [SerializeField] int damage;
    [SerializeField] float shotCooldown;
}
