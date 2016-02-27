﻿using Entitas;
using UnityEngine;

public static class PoolExtensions {

    public static Entity CreateBullet(this Pool pool, Vector3 position, Vector3 velocity, ObjectPool<GameObject> gameObjectPool) {
        return pool.CreateEntity()
            .IsBullet(true)
            .AddPosition(position)
            .AddVelocity(velocity)
            .AddDamage(1)
            .AddGameObjectObjectPool(gameObjectPool);
    }

    public static Entity CreateEnemy0(this Pool pool, Vector3 position) {
        return pool.CreateEntity()
            .AddPosition(position)
            .AddHealth(1)
            .AddResource(Res.Enemy0);
    }

    public static Entity CreateEnemy1(this Pool pool, Vector3 position) {
        return pool.CreateEntity()
            .AddPosition(position)
            .AddHealth(2)
            .AddResource(Res.Enemy1);
    }
}