using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TileSystem;

namespace GridSystem
{
    public class GridPresenter<T> where T : ITile,new()
    {
        private Grid<T> _gridModel;
        private IGridView _gridView;

        public GridPresenter(Grid<T> gridModel)
        {
            GameArena gameArena = GameArena.Instance;
            _gridModel = gridModel;
            _gridView = gameArena.GridView;
            _gridView.GridViewInitialize += _gridView.InitializeGridView;
            _gridView.CreateGridViewContainer();      
            LinkTileMVP();       
        }
 
        void LinkTileMVP()
        {
            for (int row = 0; row < _gridModel.Rows; row++)
            {
                for (int column = 0; column < _gridModel.Columns; column++)
                {
                    ITileView _tileView = _gridView.CreateTileView(row,column);
                    TilePresenter presenter = new TilePresenter(_tileView, _gridModel.Tiles[row,column]);
                }
            }         
        }
    }
}
