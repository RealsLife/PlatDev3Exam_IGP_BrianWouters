using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TileSystem
{
    public class TilePresenter
    {
        ITileView _tileView;
        ITile _tileModel;

        public TilePresenter(ITileView tileView, ITile tileModel)
        {
            _tileView = tileView;
            _tileModel = tileModel;

            //_model.ContentChanged += (sender, args) => _view.ActivatePlayer = _model.Content;
            //_view.Clicked += (sender, args) => dataModel.Place(_model.Row, _model.Column);
        }
    }
}
