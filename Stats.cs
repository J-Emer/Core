using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;


namespace Core
{
    public class Stats
    {
        private static Dictionary<string, Func<string>> _callbacks = new Dictionary<string, Func<string>>();
        
        private static SpriteFont font;
        public static Vector2 Position { get; set; }
        public static float YOffset { get; set; }
        public static Color DrawColor { get; set; }
       

        public static void Init(SpriteFont _font, Vector2 _position, Color _drawColor)
        {
            font = _font;
            Position = _position;
            DrawColor = _drawColor;
            YOffset = 20;
        }
        public static void Add(string _title, Func<string> _callBack)
        {
            if(!_callbacks.ContainsKey(_title))
            {
                _callbacks.Add(_title, _callBack);
            }
        }
        public static void Remove(string _title)
        {
            if(_callbacks.ContainsKey(_title))
            {
                _callbacks.Remove(_title);
            }
        }
        public static void Draw(SpriteBatch _spritebatch)
        {
            _spritebatch.Begin();

            int i = 0;

            foreach (var item in _callbacks)
            {
                string _title = item.Key;
                string _message = item.Value.Invoke();

                float y = (YOffset * i) + Position.Y;

                _spritebatch.DrawString(font, $"{_title} : {_message}", new Vector2(Position.X, y), DrawColor);

                i += 1;
            }

            _spritebatch.End();
        }


    }
}
