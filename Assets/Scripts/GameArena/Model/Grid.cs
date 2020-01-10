using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid<T>
{
    public const int GridColumns = 3;
    public const int GridRows = 3;

    private T _tile;
    public Grid(int rows = GridRows, int columns = GridColumns)
    {
        CreateGrid(rows, columns);
    }

    private void CreateGrid(int rows,int columns)
    {
        T[,] _tiles = new T[rows, columns];
        for (int row = 0; row < _tiles.GetLength(0); row++)
        {
            for (int column = 0; column < _tiles.GetLength(1); column++)
            {
                Debug.Log("Test");
                _tiles[row, column] = _tile;
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



