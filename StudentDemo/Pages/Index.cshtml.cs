using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentDemo.Pages;

public class IndexModel : PageModel
{

    public Dictionary<string, string> Query { get; set; } = new Dictionary<string, string>();
    public string? Path { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        foreach(var kv in Request.Headers)
        {
            Query.Add(kv.Key, kv.Value);
        }

        Path = System.IO.Path.GetDirectoryName(typeof(Program).Assembly.Location);

        string filepath = $"/{Path}/{DateTime.Now.Minute}{DateTime.Now.Second}.txt";

        if (System.IO.File.Exists(filepath))
        {
            System.IO.File.Delete(filepath);
        }

        var file = System.IO.File.Create(filepath);

        string txt = DateTime.Now.ToString();
        byte[] txtBytes = Encoding.UTF8.GetBytes(txt);
        file.Write(txtBytes, 0, txtBytes.Length);

    }
}

