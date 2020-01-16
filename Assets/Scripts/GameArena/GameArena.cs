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

    //public void Place(int row, int column)
    //{
    //    if (!(row < BoardDimension))
    //        throw new ArgumentException($"{nameof(row)} should be between 0 and {BoardDimension} (inclusive), passed value was {row}");

    //    if (!(column < BoardDimension))
    //        throw new ArgumentException($"{nameof(column)} should be between 0 and {BoardDimension} (inclusive), passed value was {column}");


    //    _currentTile = _tiles[row, column];
    //    _currentTile.Content = CurrentPlayer;

    //    if (CheckWinCondition(CurrentPlayer))
    //    {
    //        Winner = CurrentPlayer;
    //        GameOver?.Invoke(this, EventArgs.Empty);
    //    }

    //    SwapPlayer();
    //}
}

