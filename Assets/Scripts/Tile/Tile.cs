using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TileSystem
{
    public class Tile : ITile
    {
        public int Column { get; private set; }
        public int Row { get; private set; }

        private bool _content;
        private bool _selected;

        public event EventHandler ContentChanged;
        public event EventHandler Selection;

        public Tile()
        {

        }

        public bool Content
        {
            get => _content;
            set
            {
                _content = value;
                ContentChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public bool Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                Selection?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Reset()
        {
            Content = false;
            Selected = false;
        }

    }
}