namespace Vandar.Presenter.Models.SettingAggregate;

public class Setting
{
    public int WagePercent { get; private set; }
    public int ConfirmationDay { get; private set; }
    public int SendDay { get; private set; }
    public int DefaultSellerId { get; private set; }
    public Status404 Status404 { get; private set; }
    public Vandar Vandar { get; private set; }
    public IPG IPG { get; private set; }
    public int DeActiveProductDay { get; private set; }

    private Setting()
    {

    }
    public Setting(int wagePercent, int confirmationDay, int sendDay, int defaultSellerId, int deActiveProductDay) : this()
    {
        WagePercent = wagePercent;
        ConfirmationDay = confirmationDay;
        SendDay = sendDay;
        DefaultSellerId = defaultSellerId;
        DeActiveProductDay = deActiveProductDay;
    }
    public Setting SetDeActiveProductDay(int deActiveProductDay)
    {
        DeActiveProductDay = deActiveProductDay;
        return this;
    }
    public Setting SetwagePercent(int wagePercent)
    {
        WagePercent = wagePercent;
        return this;
    }
    public Setting SetconfirmationDay(int confirmationDay)
    {
        ConfirmationDay = confirmationDay;
        return this;
    }
    public Setting SetSendDay(int sendDay)
    {
        SendDay = sendDay;
        return this;
    }
    public Setting SetDefaultSellerId(int defaultSellerId)
    {
        DefaultSellerId = defaultSellerId;
        return this;
    }
    public Setting Set404(string imagename, string title, string description)
    {
        Status404 = new Status404(imagename, title, description);
        return this;
    }
    public Setting SetIPG(string baseUrl, string token)
    {
        IPG = new IPG(baseUrl, token);
        return this;
    }
    public Setting SetVandar(string baseUrl, string token, string refreshToken, string business)
    {
        Vandar = new Vandar(baseUrl, token, refreshToken, business);
        return this;
    }
    public Setting SetVandarToken(string token, string refreshToken)
    {
        Vandar = Vandar with { Token = token, RefreshToken = refreshToken };
        return this;
    }
}
