using RequestApiSimpleMail.Services;

//https://jsonplaceholder.typicode.com/posts

//var client = new HttpClient();
//client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

// GET Request (api'dan data almaq uchun get requesti atiriq)
//var result = await client.GetFromJsonAsync<List<Post>>("/posts");
//var result = await client.GetFromJsonAsync<Post>("/posts/5");
//var result = await client.GetFromJsonAsync<object[]>("/posts/5/comments");

// POST Request (servere data gondermek uchun post requesti atiriq)

//var postObj = new Post { Body = "ahsjdaskjd", Title = "babat title", UserId = 2 };
//var result = await client.PostAsJsonAsync("/posts", postObj);

//Console.WriteLine(result.StatusCode);
//Console.WriteLine(result.RequestMessage);

// DELETE Request

//var postId = 3;

//var result = await client.DeleteAsync($@"/posts/{postId}");



// ljgb fqte vzss ncxk

var mailService = new MailService();
mailService.SendMail("namiq_rasullu@itstep.org", "just for fun", "<h1 style='color:red'>Ne var ne yox?</h1>", true);





Console.WriteLine();
Console.WriteLine();