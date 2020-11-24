namespace Lumina
{
    /// <summary>
    /// Logger extensibility hook - used to capture log messages from lumina in consumers
    /// </summary>
    public interface ILogger
    {
        public void Verbose( string template, params object[] values );
        public void Debug( string template, params object[] values );
        public void Information( string template, params object[] values );
        public void Warning( string template, params object[] values );
        public void Error( string template, params object[] values );
        public void Fatal( string template, params object[] values );
    }
}