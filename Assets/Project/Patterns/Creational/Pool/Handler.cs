using UnityEngine;


namespace Patterns.Creational.PoolPattern
{
    public class Handler : MonoBehaviour
    {
        [SerializeField] private PoolableObject _poolableObject;
        [SerializeField] private Transform _container;
        [SerializeField] private int _capacity;
        [SerializeField] private bool _isExpandable;

        private ObjectPool _objectPool;


        private void Start()
        {
            //Создаем новую форму и заполняем ее для получения пула
            var poolPreset = new PoolPreset();
            poolPreset.poolableObject = _poolableObject;
            poolPreset.container = _container;
            poolPreset.capacity = _capacity;
            poolPreset.isExpandable = _isExpandable;

            //Генерируем пул, передаем туды форму
            _objectPool = new(poolPreset);
        }


        private void Update()
        {
            //Если по каким-либо внезапным обстоятельствам объекты в пуле обладают логикой...

            //(Также здесь может быть какая-либо другая логика, в том числе по изъятию
            //объектов из пула)
        }
    }
}