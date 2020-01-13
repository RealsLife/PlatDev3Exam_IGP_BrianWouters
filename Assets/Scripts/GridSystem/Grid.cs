using System;
using System.Collections;
using System.Collections.Generic;
using TileSystem;
using UnityEngine;

namespace GridSystem
{
    public class Grid<T> where T : ITile,new()
    {
        public T[,] Tiles
        {
            get { return _tiles; }
        }
        public int Rows 
        {
            get { return _gridRows; }
        }
        public int Columns
        {
            get { return _gridColums; }     
        }

        private int _gridRows;
        private int _gridColums;  
        private T[,] _tiles;
        private GridPresenter<T> _gridPresenter;

        public Grid(int rows = 10, int columns = 10)
        {
            _gridRows = rows;
            _gridColums = columns;
            InitializeGridModel();
            _gridPresenter = new GridPresenter<T>(this);
        }

        private void InitializeGridModel()
        {
            CreateGrid();
        }

        private void CreateGrid()
        {
            _tiles = new T[_gridRows, _gridColums];
            for (int row = 0; row < _gridRows; row++)
            {
                for (int column = 0; column < _gridColums; column++)
                {
                    T tile = new T();
                    _tiles[row, column] = tile;
                }
            }
        }
    }
}



