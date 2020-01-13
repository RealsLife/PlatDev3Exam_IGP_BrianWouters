using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using GridSystem;
using TileSystem;


    class GameArena : SingletonMonoBehaviour<GameArena>
    {
        public GridView<TileView> GridView => _gridView;
        [SerializeField]private GridView<TileView> _gridView;

        private Tile _currentTile;
        private Cursor _cursor;

        private void Start()
        {
           InitializeGameArena();
        }

        private void InitializeGameArena()
        {
            new Grid<Tile>(6, 6);
        }       
    }

