namespace MvcEmployees.Models;

// this model helps manage and display error messages to users when something goes wrong.
public class ErrorViewModel
{
    // This property holds the unique request identifier associated with the current HTTP request.
    public string? RequestId { get; set; }

    // This property checks if the RequestId is not null or empty, and returns a boolean value.      
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
