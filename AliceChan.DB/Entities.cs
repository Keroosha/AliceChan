using System;
using System.Collections.Generic;

namespace AliceChan.DB
{
  public enum ContentType
  {
    Picture,
    Video,
    Link,
    Audio,
  }
  
  public class Content
  {
    public Guid Id { get; set; }
    public ContentType ContentType { get; set; }
    public Uri Link { get; set; }
  }
  
  public class Post
  {
    public Guid Id { get; set; }
    public long PostNumber { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; }
    public IEnumerable<Content> Contents { get; set; }
  }
  
  public class Thread
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public IEnumerable<Post> Posts { get; set; }
  }
  
  public class Board
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<Thread> Threads { get; set; }
    public IEnumerable<Post> Messages { get; set; }
  }
}