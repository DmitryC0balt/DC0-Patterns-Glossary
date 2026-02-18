using UnityEngine;

namespace Patterns.Creational.PoolPattern
{
    public struct PoolPreset
    {
        public PoolableObject poolableObject;
        public Transform container;
        public int capacity;
        public bool isExpandable;
    }
}