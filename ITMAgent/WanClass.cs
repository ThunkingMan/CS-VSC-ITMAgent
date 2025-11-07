namespace ITMAgent;

internal class WanClass
{
    string m_BaseURL;
    string m_UUID;

    static readonly HttpClient httpClient = new HttpClient();

    internal WanClass() { }

    internal bool Init()
    {
        return true;
    }
}