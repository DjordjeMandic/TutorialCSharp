using System;

namespace Events
{
    internal class Video
    {
        public event EventHandler<VideoEventArgs> ImeSePromenilo;

        private string _Ime;

        public string Ime
        {
            get { return _Ime; }
            set
            {
                var tempIme = _Ime;
                _Ime = value;
                ImeSePromenilo?.Invoke(this, new VideoEventArgs
                {
                    StaroIme = tempIme,
                    NovoIme = _Ime
                });
            }
        }

        public Video(string ime)
        {
            _Ime = ime;
        }
    }

    internal class VideoEventArgs : EventArgs
    {
        public string StaroIme { get; set; }
        public string NovoIme { get; set; }
    }
}