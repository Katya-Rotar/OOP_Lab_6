﻿class InvalidSongException : Exception{
    public InvalidSongException(string message = "Invalid song.") : base(message)
    {
    }
}
class InvalidArtistNameException : InvalidSongException {
    public InvalidArtistNameException(string message = "Artist name should be between 3 and 20 symbols.") : base(message) { }
}
class InvalidSongNameException : InvalidSongException{
    public InvalidSongNameException(string message = "Song name should be between 3 and 30 symbols.") : base(message) { }
}
class InvalidSongLengthException : InvalidSongException {
    public InvalidSongLengthException(string message = "Invalid song length.") : base(message) { }
}
class InvalidSongMinutesException : InvalidSongLengthException {
    public InvalidSongMinutesException(string message = "Song minutes should be between 0 and 14.") : base(message) { }
}
class InvalidSongSecondsException : InvalidSongLengthException {
    public InvalidSongSecondsException (string message = "Song seconds should be between 0 and 59.") : base(message) { }
}