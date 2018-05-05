﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFire.bullet
{
    public class GameObject
    {
        #region Properties
        protected ContentManager _content;
        protected Texture2D _skin;
        protected Rectangle _desRectSkin;
        protected Vector2 _speed;
        protected Vector2 _index;
        protected bool _visible;
        protected bool _isMove;
        protected float _heart;
        virtual public Rectangle Bounds
        {
            get => _desRectSkin;
        }

        public bool Visible { get => _visible; set => _visible = value; }
        #endregion

        #region Constructor
        public GameObject(ContentManager content, Vector2 speed, Vector2 index, Rectangle position)
        {
            this.Visible = true;
            this._content = content;
            this._speed = speed;
            _desRectSkin = position;
            _index = index;
        }
        #endregion

        #region Destructor
        ~GameObject()
        {
            Unload();
        }
        #endregion

        #region Method
        virtual protected void Load()
        {

        }
        virtual protected void Unload()
        {
            _skin = null;
            _content = null;
        }
        virtual public void Update(GameTime gameTime)
        {

        }
        virtual public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color color)
        {
            if (Visible == true)
                spriteBatch.Draw(_skin, _desRectSkin, color);
        }
        
        #endregion
    }
}