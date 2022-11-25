// using System.Text.Json;
// using Blog.Shared;
// using Blog.Shared.Models;
//
// namespace Blog.FileData;
//
// public class FileContext
// {
//     private const string filePath = "data.json";
//     private DataContainer? dataContainer;
//
//     public ICollection<Post> Posts
//     {
//         get
//         {
//             LoadData();
//             return dataContainer!.Posts;
//         }
//     }
//     
//     public ICollection<Comment> Comments
//     {
//         get
//         {
//             LoadData();
//             return dataContainer!.Comments;
//         }
//     }
//     public ICollection<User> User
//     {
//         get
//         {
//             LoadData();
//             return dataContainer!.Users;
//         }
//     }
//     
//     private void LoadData()
//     {
//         if (dataContainer != null) return;
//     
//         if (!File.Exists(filePath))
//         {
//             dataContainer = new()
//             {
//                 Posts = new List<Post>(),
//                 Comments = new List<Comment>(),
//                 Users = new List<User>()
//             };
//             return;
//         }
//         string content = File.ReadAllText(filePath);
//         dataContainer = JsonSerializer.Deserialize<DataContainer>(content);
//     }
//     public void SaveChanges()
//     {
//         string serialized = JsonSerializer.Serialize(dataContainer, new JsonSerializerOptions
//         {
//             WriteIndented = true
//         });
//         File.WriteAllText(filePath, serialized);
//         dataContainer = null;
//     }
// }