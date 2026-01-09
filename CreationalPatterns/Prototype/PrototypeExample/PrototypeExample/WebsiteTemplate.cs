

namespace PrototypeExample;

public class WebsiteTemplate : IWebsiteTemplate
{
    public string Theme { get; set; }
    public int Pages { get; set; }

    public WebsiteTemplate(string theme, int pages)
    {
        Theme = theme;
        Pages = pages;
    }
    public IWebsiteTemplate Clone()
    {
        return new WebsiteTemplate(Theme, Pages);
    }

    public void ShowTemplate()
    {
        Console.WriteLine($"Website with theme '{Theme}' and {Pages} pages");
    }
}
