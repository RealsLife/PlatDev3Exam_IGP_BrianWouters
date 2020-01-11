using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TileSystem;
namespace GridSystem
{
    public class GridView<T,U> : MonoBehaviour where U : Component
    {
        [SerializeField] U _tilePrefab;
        private Renderer _tileRenderer;
        private U _tileView;
        private void Start()
        {
            _tileRenderer = _tilePrefab.GetComponent<Renderer>();
        }

        public void CreateTileView(T tile)
        {
            _tileView = GameObject.Instantiate(_tilePrefab, this.transform);
        }

        public void AllocateTilePosOnGrid(int row, int column)
        {
            Vector3 size = _tileRenderer.bounds.size;
            _tileView.transform.localPosition = new Vector3(column * size.x, 0, row * size.z);
        }




            //Vector3 size = _renderer.bounds.size;
            //GameObject jaja = GameObject.Instantiate(_tilePrefabssss, this.transform);
            //GameObject.Instantiate<U>(_tilePrefab, this.transform);
            //Instantiate<U>(_tilePrefab, this.transform);
            //U test = jaja.GetComponent<U>();
            //aa.transform.localPosition = new Vector3(tile.Column * size.x, 0, tile.Row * size.z);

            //Vector3 size = _renderer.bounds.size;
            //TileView aa = GameObject.Instantiate(_tilePrefab, this.transform);
            //aa.transform.localPosition = new Vector3(tile.Column * size.x, 0, tile.Row * size.z);
        
    }
}

