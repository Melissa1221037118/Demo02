using NorthWind.Entities.ValueObjects.Interfaces;

internal class AppLoger
{
    private IUserActionWriter writer;

    public AppLoger(IUserActionWriter writer)
    {
        this.writer = writer;
    }

    internal void WriteLog(string v)
    {
        throw new NotImplementedException();
    }
}