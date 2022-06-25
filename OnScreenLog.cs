using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Core
{
    public static class OnScreenLog
    {
        private static List<string> messages = new List<string>();

        private static SpriteFont font;

        public static Vector2 Position;

        public static Color DrawColor;

        private static bool ShowLog;

        public static void Init(SpriteFont _font, Vector2 _position, Color _drawColor)
        {
            font = _font;
            Position = _position;
            DrawColor = _drawColor;
            ShowLog = true;
        }

        /// <summary>
        /// Logs a message
        /// </summary>
        public static void Log(string _message)
        {
            messages.Add(_message);
        }

        /// <summary>
        /// Clears the OnScreenLog
        /// </summary>
        public static void Clear()
        {
            messages.Clear();
        }

        /// <summary>
        /// Show / Hide the OnScreenLog
        /// </summary>
        public static void ToggleLog()
        {
            ShowLog = !ShowLog;
        }

        public static void Draw(SpriteBatch _spriteBatch)
        {
            if (!ShowLog) { return; }

            _spriteBatch.Begin();

            float yPos = Position.Y;

            for (int i = 0; i < messages.Count; i++)
            {
                yPos = (i * 20);

                _spriteBatch.DrawString(font, messages[i], new Vector2(Position.X, yPos), DrawColor);
            }

            _spriteBatch.End();
        }

    }
}
