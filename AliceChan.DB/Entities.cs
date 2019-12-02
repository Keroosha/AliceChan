using System;
using System.Collections.Generic;
using AliceChan.Shared;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace AliceChan.DB
{
  public class Content
  {
    [BsonId(IdGenerator = typeof(CombGuidGenerator))]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; set; }
    
    [BsonRepresentation(BsonType.Int32)]
    public ContentType ContentType { get; set; }
    
    public Uri Link { get; set; }
  }
  
  public class Post
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public long PostNumber { get; set; }
    public string Text { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    [BsonRepresentation(BsonType.ObjectId)]
    public IEnumerable<Guid> ContentsIds { get; set; }
  }
  
  public class Thread
  {
    [BsonId(IdGenerator = typeof(CombGuidGenerator))]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; set; }
    
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid BoardId { get; set; }
    
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    
    [BsonRepresentation(BsonType.ObjectId)]
    public IEnumerable<Guid> PostsIds { get; set; }
  }
  
  public class Board
  {
    [BsonId(IdGenerator = typeof(CombGuidGenerator))]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    [BsonRepresentation(BsonType.ObjectId)]
    public IEnumerable<Guid> ThreadsIds { get; set; }
    
    [BsonRepresentation(BsonType.ObjectId)]
    public IEnumerable<Guid> MessagesIds { get; set; }
  }
}