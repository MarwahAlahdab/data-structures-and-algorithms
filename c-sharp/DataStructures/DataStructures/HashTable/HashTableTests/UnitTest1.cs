namespace HashTableTests;
using HashTables; // Assuming your HashMap class is in this namespace


public class UnitTest1
{

  [Fact]
  public void SettingKeyAndValueAddsToHashtable()
  {
    var hashMap = new HashMap(10);
    hashMap.Set("key1", "value1");
    Assert.Equal("value1", hashMap.Get("key1"));
  }


  [Fact]
  public void RetrieveByKeyReturnsStoredValue()
  {
    var hashMap = new HashMap(10);
    hashMap.Set("key1", "value1");
    hashMap.Set("key2", "value2");
    Assert.Equal("value1", hashMap.Get("key1"));
    Assert.Equal("value2", hashMap.Get("key2"));
  }


  [Fact]
  public void RetrieveNonExistentKeyReturnsNull()
  {
    var hashMap = new HashMap(10);
    Assert.Null(hashMap.Get("nonexistent"));
  }


  [Fact]
  public void GetUniqueKeysReturnsListOfKeys()
  {
    var hashMap = new HashMap(10);
    hashMap.Set("key1", "value1");
    hashMap.Set("key2", "value2");
    hashMap.Set("key3", "value3");
    var keys = hashMap.Key();
    Assert.Contains("key1", keys);
    Assert.Contains("key2", keys);
    Assert.Contains("key3", keys);
    Assert.Equal(3, keys.Count);
  }


  [Fact]
  public void HandleCollisionWithinHashtable()
  {
    var hashMap = new HashMap(10);
    // These keys will have the same hash index
    hashMap.Set("key1", "value1");
    hashMap.Set("key11", "value11");
    Assert.Equal("value1", hashMap.Get("key1"));
    Assert.Equal("value11", hashMap.Get("key11"));
  }


  [Fact]
  public void RetrieveValueFromBucketWithCollision()
  {
    var hashMap = new HashMap(10);
    // These keys will have the same hash index
    hashMap.Set("key1", "value1");
    hashMap.Set("key11", "value11");
    Assert.Equal("value1", hashMap.Get("key1"));
    Assert.Equal("value11", hashMap.Get("key11"));
  }


  [Fact]
  public void HashKeyToInRangeValue()
  {
    var hashMap = new HashMap(10);
    int hashValue = hashMap.Hash("myKey");
    Assert.InRange(hashValue, 0, 9);
  }



}