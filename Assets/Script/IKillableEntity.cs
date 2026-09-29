using UnityEngine;

public interface IKillableEntity
{
    virtual void GetHurt(int damage)
    {
    }

    virtual void Die()
    {
    }
}
