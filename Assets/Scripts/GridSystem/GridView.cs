using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TileSystem;
using System;

namespace GridSystem
{
    [Serializable] public class GridView<U> : MonoBehaviour, IGridView where U : Component, ITileView, new()
    {
        public event EventHandler GridViewInitialize;
        public GameObject GridContainer
        {
            get { return _gridContainer; }
            set
            {
                GridViewInitialize?.Invoke(this, EventArgs.Empty);
                _gridContainer = value;
            }
        }
        [SerializeField] private U _tilePrefab;
        private Renderer _tileRenderer;
        private Vector3 _tileViewSize;
        private GameObject _gridContainer;

        public void InitializeGridView(object sender, EventArgs e)
        {
            GetPrefabSize();
        }
        public ITileView CreateTileView(int gridRow, int gridColumn)
        {     
        U tileView = Instantiate(_tilePrefab, _gridContainer.transform);            
        tileView.transform.position = new Vector3(gridColumn * _tileViewSize.x, 0, gridRow * _tileViewSize.z);
        return tileView;
        }    

        private void GetPrefabSize()
        {
            _tileRenderer = _tilePrefab.GetComponent<Renderer>();
            _tileViewSize = _tileRenderer.bounds.size;
        }

        public void CreateGridViewContainer()
        {
            GridContainer = new GameObject("GridView");
            GridContainer.transform.parent = GameArena.Instance.transform;
        }
    }
}

