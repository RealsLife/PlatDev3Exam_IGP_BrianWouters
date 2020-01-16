using System.Collections;
using System.Collections.Generic;
using TileSystem;
using UnityEngine;
using System;
 [Serializable] public class TileView : MonoBehaviour, ITileView
{

    public int Row { get; set; }
    public int Column { get; set; }

    void GetGridPosition()
    {

    }

        //public interface ITileView
        //{
        //    event EventHandler Clicked;
        //    Player ActivatePlayer { set; }
        //}

        //public class TileView : MonoBehaviour, ITileView
        //{
        //    public event EventHandler Clicked;

        //    [SerializeField] Material _player1, _player2;
        //    [SerializeField] Renderer _renderer;

        //    public Vector3 Size
        //    {
        //        get { return _renderer.bounds.size; }
        //    }

        //    public Tile _tile { get; set; }
        //    public Tile Tile
        //    {
        //        get => _tile;
        //        set
        //        {
        //            _tile = value;
        //        }
        //    }

        //    public void ActivatePlayer1() =>
        //        _renderer.sharedMaterial = _player1;

        //    public Player ActivatePlayer
        //    {
        //        set
        //        {
        //            switch (value)
        //            {
        //                case Player.Player1:
        //                    ActivatePlayer1();
        //                    break;
        //                case Player.Player2:
        //                    ActivatePlayer2();
        //                    break;
        //            }
        //        }
        //    }
        //}
    }
