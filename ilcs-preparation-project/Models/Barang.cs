using System.Text.Json.Serialization;

namespace ilcs_preparation_project.Models;

public class Barang
{
    [JsonPropertyName("hs_code_format")]
    public string HsCodeFormat { get; set; }
    
    [JsonPropertyName("uraian_id")]
    public string UraianId { get; set; }
    
    [JsonPropertyName("sub_header")]
    public string SubHeader { get; set; }
    
    
}