using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.PoolPattern
{
    public class ObjectPool
    {
        private PoolableObject _formular;
        private Transform _container;
        private int _capacity;
        private bool _isExpandable;


        private List<PoolableObject> _prefabList;


        public ObjectPool(PoolPreset poolPreset)
        {
            SetupPool(poolPreset);
            CreatePool();
        }


        public void OnDispose()
        {
            _prefabList.Clear();
            _prefabList = null;
        }


        private void SetupPool(PoolPreset poolPreset)
        {
            _formular = poolPreset.poolableObject;
            _container = poolPreset.container;
            _capacity = poolPreset.capacity;
            _isExpandable = poolPreset.isExpandable;
        }


        private void CreatePool()
        {
            _prefabList = new List<PoolableObject>();

            for (int i = 0; i < _capacity; i++)
            {
                CreatePrefab();
            }
        }


        private PoolableObject CreatePrefab()
        {
            var createdPrefab = Object.Instantiate(_formular, _container);
            createdPrefab.gameObject.SetActive(false);
            return createdPrefab;
        }


        public PoolableObject GetPrefab()
        {
            if (TryGetPrefab(out var prefab))
            {
                return prefab;
            }

            if (_isExpandable)
            {
                var createdPrefab = CreatePrefab();
                createdPrefab.Show();
                return createdPrefab;
            }

            Debug.Log($"No more {nameof(PoolableObject)} in pool!");
            return null;
        }


        private bool TryGetPrefab(out PoolableObject targetPrefab)
        {
            targetPrefab = null;

            foreach (var prefab in _prefabList)
            {
                if (!prefab.gameObject.activeInHierarchy)
                {
                    targetPrefab = prefab;
                    targetPrefab.Show();
                    return true;
                }
            }

            return false;
        }

    }
}