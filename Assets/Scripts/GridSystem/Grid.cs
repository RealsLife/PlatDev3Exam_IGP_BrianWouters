using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GridSystem
{
    public class Grid<T,U> where T : new() where U : Component
    {
        public const int GridColumns = 3;
        public const int GridRows = 3;
        public T[,] Tiles => _tiles;

        private T[,] _tiles;
        private GridPresenter<T,U> _gridPresenter;
        private Grid<T,U> lol;
        public Grid(int rows = GridRows, int columns = GridColumns)
        {
            CreateGrid(rows, columns);
            _gridPresenter = new GridPresenter<T,U>(this);    
        }

        private void CreateGrid(int rows, int columns)
        {
            _tiles = new T[rows, columns];
            for (int row = 0; row < _tiles.GetLength(0); row++)
            {
                for (int column = 0; column < _tiles.GetLength(1); column++)
                {
                    T tile = new T();
                    _tiles[row, column] = tile;
                }
            }
        }
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




    //private void ResetAllTiles()
    //{
    //    for (int row = 0; row < GridRows; row++)
    //    {
    //        for (int column = 0; column < GridColumns; column++)
    //        {
    //            _grid[row, column].Reset();
    //        }
    //    }
    //}
}



