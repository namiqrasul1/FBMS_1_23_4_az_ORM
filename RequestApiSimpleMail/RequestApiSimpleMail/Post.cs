using System.Text.Json.Serialization;

namespace RequestApiSimpleMail;

internal class Post
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("body")]
    public string Body { get; set; }

    /*
     "userId": 1,
    "id": 1,
    "title": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
    "body": "qui
     */
}
