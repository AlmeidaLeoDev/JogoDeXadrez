namespace tabuleiro
{
    //O exception é herdado do próprio C#
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
