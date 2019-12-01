using MongoDB.Bson.Serialization;

namespace AliceChan.DB
{
  public class BsonMaps
  {
    public BsonMaps()
    {
      BsonClassMap.RegisterClassMap<Board>();
      BsonClassMap.RegisterClassMap<Thread>();
      BsonClassMap.RegisterClassMap<Post>();
      BsonClassMap.RegisterClassMap<Content>();
    }
  }
}