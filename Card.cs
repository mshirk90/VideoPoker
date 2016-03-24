using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VideoPoker
{
    public class Card : IDisposable
    {

        #region  Private Members 
        private string _Suit = string.Empty;
        private uint _Value = 0;
        private Image _FrontImage = null;
        private Image _BackImage = null;
        private Image _HoldImage = null;
        private PictureBox _Card = null;
        private bool _IsHeld = false;
        


        #endregion

        #region  Public Properties
        public string Suit
        {
            get
            {
                return _Suit;
            }
            set
            {
                _Suit = value;
            }
        }
        public uint Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        public Image FrontImage
        {
            get
            {
                return _FrontImage;
            }
            set
            {
                _FrontImage = value;
            }
        }
        public Image BackImage
        {
            get
            {
                return _BackImage;
            }
            set
            {
                _BackImage = value;
            }
        }
        public Image HoldImage
        {
            get
            {
                return _HoldImage;
            }
            set
            {
                _HoldImage = value;
            }
        }
        public bool IsHeld
        {
            get
            {
                return _IsHeld;
            }
            set
            {
                _IsHeld = value;
            }
        }
        public PictureBox CARD
        {
            get
            {
                return _Card;
            }
        }
        #endregion

        #region  Private Methods 

        #endregion

        #region Public Methods

        #endregion

        #region Public Events
        
        #endregion

        #region Public Event Handlers
        private void _Card_Click(object sender, EventArgs e)
        {
            _IsHeld = !_IsHeld;
            if (_IsHeld == true)
            {
                _Card.Image = _HoldImage;
            }
            else
            {
                _Card.Image = _FrontImage;
            }
        }

        private void _Card_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void _Card_MouseEnter(object sender, EventArgs e)
        {
        
        }
        #endregion

        #region Construction

        public Card()
        { 

            _Card = new PictureBox();
            _Card.MouseEnter += _Card_MouseEnter;
            _Card.MouseLeave += _Card_MouseLeave;
            _Card.Click += _Card_Click;


        }

        #endregion

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

    }
}



/****************
 _form = f;
 _Card = new PictureBox();
 //Load image of 1 card
 Bitmap bmp = new Bitmap("Images/s1.gif");
 _Card.Width = bmp.Width;
 _Card.Height = bmp.Height;
 _Card.Image = bmp;
 ***********************/
