using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentDemo.Pages;

public class IndexModel : PageModel
{

    public Dictionary<string, string> Query { get; set; } = new Dictionary<string, string>();
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

    }
}

